using System;
using AutoMapper;
using DataView.DataEntities;

namespace DataView.Mapping
{
    public class MapperRegistration : Profile 
    {
        public static IMapper Register()
        {
            var mapperConfig = new MapperConfiguration(
                config =>
            {
                //From Data Entity to Domain Model
                config.CreateMap<Domain.Model.Post, Post>();




                //From Domain Model to Data Entity 
                config.CreateMap<Post, Domain.Model.Post>();

            });

            return mapperConfig.CreateMapper();
        }
    }
}
