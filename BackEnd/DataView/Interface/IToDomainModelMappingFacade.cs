using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace DataView.Interface
{
    public interface IToDomainModelMappingFacade
    {
        ICollection<Post> Map(ICollection<DataEntities.Post> posts);
        Post Map(DataEntities.Post post);
    }
}
