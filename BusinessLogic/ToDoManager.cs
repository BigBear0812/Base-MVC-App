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

        public List<List> GetAllListsAndItems()
        {
            return _commonRepo.GetAllListsAndItems();
        }

        public List GetList(int id)
        {
            return _listRepo.GetList(id);
        }

        public Item GetItem(int id)
        {
            return _itemRepo.GetItem(id);
        }

        public List CreateNewList(string name)
        {
            return _listRepo.CreateList(name);
        }

        public Item CreateNewItem(int listId, string name, int quantity)
        {
            return _itemRepo.CreateItem(listId, name, quantity);
        }

        public List DeleteList(int listId)
        {
            var items = _itemRepo.GetListItems(listId);
            _itemRepo.DeleteItems(items);
            return _listRepo.DeleteList(listId);
        }

        public Item DeleteItem(int itemId)
        {
            return _itemRepo.DeleteItem(itemId);
        }

        public List UpdateList(List updatedList)
        {
            return _listRepo.UpdateList(updatedList);
        }

        public Item UpdateItem(Item updatedItem)
        {
            return _itemRepo.UpdateItem(updatedItem);
        }
    }
}
