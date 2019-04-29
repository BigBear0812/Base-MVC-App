using System.Collections.Generic;
using DatabaseModels;

namespace RepositoryLogic
{
    public interface ICommonRepository
    {
        List<List> GetAllListsAndItems();
    }
}
