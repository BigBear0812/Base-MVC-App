using System.Collections.Generic;
using System.Linq;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLogic
{
    public class CommonRepository : ICommonRepository
    {
        private readonly DataContext _context;

        public CommonRepository(DataContext context)
        {
            _context = context;
        }

        public List<ToDoList> GetAllListsAndItems()
        {
            return _context.ToDoLists.Include(l => l.Items).ToList();
        }
    }
}
