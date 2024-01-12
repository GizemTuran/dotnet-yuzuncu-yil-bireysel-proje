using AutoMapper;
using DotnetYuzuncuYilBireyselProje.Core.DTOs;
using DotnetYuzuncuYilBireyselProje.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile() {
            CreateMap<Client,ClientDto>().ReverseMap();
            CreateMap<Store,StoreDto>().ReverseMap();
            CreateMap<ClientProfile, ClientProfileDto>().ReverseMap();

            CreateMap<StoreDto, Store>();
        }

    }
}
