﻿using AutoMapper;
using Domain.DTOs.Request.Post;
using Domain.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapper
{
    public class DeviceMapping : Profile
    {
        public DeviceMapping()
        {
            CreateMap<DeviceRequest, Device>()
             .ForMember(des => des.DeviceName, act => act.MapFrom(src => src.DeviceName))
             .ForMember(des => des.Description, act => act.MapFrom(src => src.Description))
             .ForMember(des => des.Price, act => act.MapFrom(src => src.Price))
             .ForMember(des => des.DeviceType, act => act.MapFrom(src => src.DeviceType));

            CreateMap<DeviceResponse, Device>()
                .ForMember(des => des.DeviceName, act => act.MapFrom(src => src.DeviceName))
                .ForMember(des => des.Price, act => act.MapFrom(src => src.Price))
                .ForMember(des => des.DeviceType, act => act.MapFrom(src => src.DeviceType))
                .ForMember(des => des.Manufacturer.Name, act => act.MapFrom(src => src.ManufactureName))
                .ForMember(des => des.Images.First().Data, act => act.Condition(src => src.ImageData != null));

            CreateMap<Guid, string>().ConstructUsing(x => x.ToString());
            CreateMap<string, Guid>().ConstructUsing(x => new Guid(x));

        }
           
    }
}



