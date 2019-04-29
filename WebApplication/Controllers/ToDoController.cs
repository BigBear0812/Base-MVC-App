using System;
using BusinessLogic;
using DatabaseModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoManager _todoManager;

        public ToDoController(IToDoManager toDoManager)
        {
            _todoManager = toDoManager;
        }

        public IActionResult Index()
        {
            return View(_todoManager.GetAllListsAndItems());
        }

        #region CreateList

        public IActionResult CreateList()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateList(List list)
        {
            try
            {
                _todoManager.CreateNewList(list.ListName);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(new List
                {
                    ListName = list.ListName
                });
            }
        }

        #endregion

        #region CreateItem

        public IActionResult CreateItem(int listId)
        {
            return View(new Item
            {
                ListId = listId
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateItem(int listId, string itemName, int quantity = 0)
        {
            try
            {
                _todoManager.CreateNewItem(listId, itemName, quantity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(new Item
                {
                    ListId = listId,
                    ItemName = itemName,
                    Quantity = quantity
                });
            }
        }

        #endregion

        #region EditList

        public IActionResult EditList(int listId)
        {
            return View(_todoManager.GetList(listId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditList(List list)
        {
            try
            {
                _todoManager.UpdateList(list);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(list);
            }
        }

        #endregion

        #region EditItem

        public IActionResult EditItem(int itemId)
        {
            return View(_todoManager.GetItem(itemId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditItem(Item item)
        {
            try
            {
                _todoManager.UpdateItem(item);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(item);
            }
        }

        #endregion

        #region DeleteList

        public IActionResult DeleteList(int listId)
        {
            try
            {
                _todoManager.DeleteList(listId);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        #endregion

        #region DeleteItem

        public IActionResult DeleteItem(int itemId)
        {
            try
            {
                _todoManager.DeleteItem(itemId);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        #endregion
    }
}