using System.Collections.Generic;
using System.Linq;
using DatabaseModels;

namespace RepositoryLogic
{
    public class ListRepository : IListRepository
    {
        private readonly DataContext _context;

        public ListRepository(DataContext context)
        {
            _context = context;
        }

        public ToDoList GetList(int id)
        {
            return _context.ToDoLists.FirstOrDefault(l => l.ListId == id);
        }

        public ToDoList CreateList(ToDoList toDoList)
        {
            _context.ToDoLists.Add(toDoList);
            _context.SaveChanges();
            return toDoList;
        }

        public ToDoList DeleteList(int listId)
        {
            var delete = _context.ToDoLists.FirstOrDefault(l => l.ListId == listId);
            if (delete != null)
            {
                _context.ToDoLists.Remove(delete);
                _context.SaveChanges();
                return delete;
            }
            return null;
        }

        public ToDoList UpdateList(ToDoList updatedToDoList)
        {
            _context.Update(updatedToDoList);
            _context.SaveChanges();
            return updatedToDoList;
        }
    }
}
