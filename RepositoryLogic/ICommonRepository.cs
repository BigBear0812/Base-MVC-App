using System.Collections.Generic;
using DatabaseModels;

namespace RepositoryLogic
{
    public interface ICommonRepository
    {
        List<ToDoList> GetAllListsAndItems();
    }
}
