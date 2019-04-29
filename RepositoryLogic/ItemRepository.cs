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

        public Item GetItem(int id)
        {
            return _context.Items.FirstOrDefault(i => i.ItemId == id);
        }

        public Item CreateItem(int listId, string name, int quantity)
        {
            var item = new Item
            {
                ListId = listId,
                ItemName = name,
                Quantity = quantity,
            };
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public IEnumerable<Item> GetListItems(int listId)
        {
            return _context.Items.Where(i => i.ListId == listId).ToList();
        }

        public Item DeleteItem(int itemId)
        {
            var delete = _context.Items.FirstOrDefault(i => i.ItemId == itemId);
            if (delete != null)
            {
                _context.Items.Remove(delete);
                _context.SaveChanges();
                return delete;
            }
            return null;
        }

        public IEnumerable<Item> DeleteItems(IEnumerable<Item> items)
        {
            var deleteItems = items.ToList();
            _context.Items.RemoveRange(deleteItems);
            _context.SaveChanges();
            return deleteItems;
        }

        public Item UpdateItem(Item updatedItem)
        {
            _context.Update(updatedItem);
            _context.SaveChanges();
            return updatedItem;
        }
    }
}
