using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Aggregate;
using Domain.Model;

namespace Domain.Interfaces
{
    public interface ISearchUseCases
    {
        Task<ICollection<Post>> SearchAsync(SearchParameters searchParameter);
    }
}
