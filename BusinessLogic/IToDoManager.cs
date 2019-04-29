using System.Collections.Generic;
using DatabaseModels;
using RepositoryLogic;

namespace BusinessLogic
{
    public interface IToDoManager
    {
        List<List> GetAllListsAndItems();
        List GetList(int id);
        Item GetItem(int id);
        List CreateNewList(string name);
        Item CreateNewItem(int listId, string name, int quantity);
        List DeleteList(int listId);
        Item DeleteItem(int itemId);
        List UpdateList(List updatedList);
        Item UpdateItem(Item updatedItem);
    }
}
