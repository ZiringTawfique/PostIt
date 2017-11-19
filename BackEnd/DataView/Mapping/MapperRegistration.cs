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
                config.CreateMap<Domain.Model.Post, Post>();
            });

            return mapperConfig.CreateMapper();
        }
    }
}
