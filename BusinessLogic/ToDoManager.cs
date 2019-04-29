using System.Collections.Generic;
using DatabaseModels;
using RepositoryLogic;

namespace BusinessLogic
{
    public class ToDoManager : IToDoManager
    {
        private readonly IListRepository _listRepo;
        private readonly IItemRepository _itemRepo;
        private readonly ICommonRepository _commonRepo;

        public ToDoManager(IListRepository listRepo, IItemRepository itemRepo, ICommonRepository commonRepo)
        {
            _listRepo = listRepo;
            _itemRepo = itemRepo;
            _commonRepo = commonRepo;
        }

        public List<ToDoList> GetAllListsAndItems()
        {
            return _commonRepo.GetAllListsAndItems();
        }

        public ToDoList GetList(int id)
        {
            return _listRepo.GetList(id);
        }

        public ToDoItem GetItem(int id)
        {
            return _itemRepo.GetItem(id);
        }

        public ToDoList CreateNewList(ToDoList toDoList)
        {
            return _listRepo.CreateList(toDoList);
        }

        public ToDoItem CreateNewItem(ToDoItem toDoItem)
        {
            return _itemRepo.CreateItem(toDoItem);
        }

        public ToDoList DeleteList(int listId)
        {
            var items = _itemRepo.GetListItems(listId);
            _itemRepo.DeleteItems(items);
            return _listRepo.DeleteList(listId);
        }

        public ToDoItem DeleteItem(int itemId)
        {
            return _itemRepo.DeleteItem(itemId);
        }

        public ToDoList UpdateList(ToDoList updatedToDoList)
        {
            return _listRepo.UpdateList(updatedToDoList);
        }

        public ToDoItem UpdateItem(ToDoItem updatedToDoItem)
        {
            return _itemRepo.UpdateItem(updatedToDoItem);
        }
    }
}
