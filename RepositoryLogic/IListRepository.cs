using System.Collections.Generic;
using DatabaseModels;

namespace RepositoryLogic
{
    public interface IListRepository
    {
        List GetList(int id);
        List CreateList(string name);
        List DeleteList(int listId);
        List UpdateList(List updatedList);
    }
}
