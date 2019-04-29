using System.Collections.Generic;
using DatabaseModels;

namespace RepositoryLogic
{
    public interface IItemRepository
    {
        ToDoItem GetItem(int id);
        ToDoItem CreateItem(ToDoItem toDoItem);
        IEnumerable<ToDoItem> GetListItems(int listId);
        ToDoItem DeleteItem(int itemId);
        IEnumerable<ToDoItem> DeleteItems(IEnumerable<ToDoItem> items);
        ToDoItem UpdateItem(ToDoItem updatedToDoItem);
    }
}
