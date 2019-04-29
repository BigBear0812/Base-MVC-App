using System.Collections.Generic;
using DatabaseModels;

namespace RepositoryLogic
{
    public interface IListRepository
    {
        ToDoList GetList(int id);
        ToDoList CreateList(ToDoList toDoList);
        ToDoList DeleteList(int listId);
        ToDoList UpdateList(ToDoList updatedToDoList);
    }
}
