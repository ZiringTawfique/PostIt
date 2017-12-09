using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataView.DataEntities;
using DataView.Interface;
using Domain.Model;

namespace DataView.Mapping
{
    public class ToDomainModelMappingFacade:IToDomainModelMappingFacade
    {
        private readonly IMapper _mapper;

        public ToDomainModelMappingFacade(IMapper mapper)
        {
            _mapper = mapper;
        }

 

        public ICollection<Domain.Model.Post> Map(ICollection<DataEntities.Post> posts)
        {
            var mappedToDomain = _mapper.Map<ICollection<Domain.Model.Post>>(posts);
            return mappedToDomain;
        }


        public Domain.Model.Post Map(DataEntities.Post post)
        {
            var mappedToDomain = _mapper.Map<Domain.Model.Post>(post);
            return mappedToDomain;
        }
    }

}
