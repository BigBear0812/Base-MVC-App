using System.Collections.Generic;
using System.Linq;
using DatabaseModels;

namespace RepositoryLogic
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _context;

        public ItemRepository(DataContext context)
        {
            _context = context;
        }

        public ToDoItem GetItem(int id)
        {
            return _context.ToDoItems.FirstOrDefault(i => i.ItemId == id);
        }

        public ToDoItem CreateItem(ToDoItem toDoItem)
        {
            _context.ToDoItems.Add(toDoItem);
            _context.SaveChanges();
            return toDoItem;
        }

        public IEnumerable<ToDoItem> GetListItems(int listId)
        {
            return _context.ToDoItems.Where(i => i.ListId == listId).ToList();
        }

        public ToDoItem DeleteItem(int itemId)
        {
            var delete = _context.ToDoItems.FirstOrDefault(i => i.ItemId == itemId);
            if (delete != null)
            {
                _context.ToDoItems.Remove(delete);
                _context.SaveChanges();
                return delete;
            }
            return null;
        }

        public IEnumerable<ToDoItem> DeleteItems(IEnumerable<ToDoItem> items)
        {
            var deleteItems = items.ToList();
            _context.ToDoItems.RemoveRange(deleteItems);
            _context.SaveChanges();
            return deleteItems;
        }

        public ToDoItem UpdateItem(ToDoItem updatedToDoItem)
        {
            _context.Update(updatedToDoItem);
            _context.SaveChanges();
            return updatedToDoItem;
        }
    }
}
