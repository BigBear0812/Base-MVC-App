using System.Collections.Generic;
using DatabaseModels;
using RepositoryLogic;

namespace BusinessLogic
{
    public interface IToDoManager
    {
        List<ToDoList> GetAllListsAndItems();
        ToDoList GetList(int id);
        ToDoItem GetItem(int id);
        ToDoList CreateNewList(ToDoList toDoList);
        ToDoItem CreateNewItem(ToDoItem toDoItem);
        ToDoList DeleteList(int listId);
        ToDoItem DeleteItem(int itemId);
        ToDoList UpdateList(ToDoList updatedToDoList);
        ToDoItem UpdateItem(ToDoItem updatedToDoItem);
    }
}
