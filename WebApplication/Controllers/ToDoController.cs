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
        public IActionResult CreateList(ToDoList toDoList)
        {
            try
            {
                _todoManager.CreateNewList(toDoList);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(toDoList);
            }
        }

        #endregion

        #region CreateItem

        public IActionResult CreateItem(int listId)
        {
            return View(new ToDoItem
            {
                ListId = listId
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateItem(ToDoItem toDoItem)
        {
            try
            {
                _todoManager.CreateNewItem(toDoItem);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(toDoItem);
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
        public IActionResult EditList(ToDoList toDoList)
        {
            try
            {
                _todoManager.UpdateList(toDoList);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(toDoList);
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
        public IActionResult EditItem(ToDoItem toDoItem)
        {
            try
            {
                _todoManager.UpdateItem(toDoItem);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(toDoItem);
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