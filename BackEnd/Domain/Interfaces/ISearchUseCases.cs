using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Interfaces
{
    public interface ISearchUseCases
    {
        Task<ICollection<Post>> SearchAsync(string searchStr);
    }
}
