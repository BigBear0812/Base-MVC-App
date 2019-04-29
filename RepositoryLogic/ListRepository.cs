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

        public List GetList(int id)
        {
            return _context.Lists.FirstOrDefault(l => l.ListId == id);
        }

        public List CreateList(string name)
        {
            var list = new List
            {
                ListName = name
            };
            _context.Lists.Add(list);
            _context.SaveChanges();
            return list;
        }

        public List DeleteList(int listId)
        {
            var delete = _context.Lists.FirstOrDefault(l => l.ListId == listId);
            if (delete != null)
            {
                _context.Lists.Remove(delete);
                _context.SaveChanges();
                return delete;
            }
            return null;
        }

        public List UpdateList(List updatedList)
        {
            _context.Update(updatedList);
            _context.SaveChanges();
            return updatedList;
        }
    }
}
