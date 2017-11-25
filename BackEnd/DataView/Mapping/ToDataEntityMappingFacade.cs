using System;
using AutoMapper;
using DataView.DataEntities;
using DataView.Interface;

namespace DataView.Mapping
{
    public class ToDataEntityMappingFacade : IToDataEntityMappingFacade
    {
        private readonly IMapper _mapper;
       
        public ToDataEntityMappingFacade(IMapper mapper )
        {
            _mapper = mapper;
        }


        public Post Map(Domain.Model.Post post)
        {
            var mappedToDomain = _mapper.Map<Post>(post);
            return mappedToDomain;
        }
    }
}
