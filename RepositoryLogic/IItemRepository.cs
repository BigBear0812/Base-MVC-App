using System.Collections.Generic;
using DatabaseModels;

namespace RepositoryLogic
{
    public interface IItemRepository
    {
        Item GetItem(int id);
        Item CreateItem(int listId, string name, int quantity);
        IEnumerable<Item> GetListItems(int listId);
        Item DeleteItem(int itemId);
        IEnumerable<Item> DeleteItems(IEnumerable<Item> items);
        Item UpdateItem(Item updatedItem);
    }
}
