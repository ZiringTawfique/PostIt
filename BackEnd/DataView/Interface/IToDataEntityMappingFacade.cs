using System;
using DataView.DataEntities;

namespace DataView.Interface
{
    public interface IToDataEntityMappingFacade
    {
        Post Map(Domain.Model.Post post);
    }
}
