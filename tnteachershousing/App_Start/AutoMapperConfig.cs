using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using tnteachershousing.Models;
using tnteachershousing.ViewModel;

namespace tnteachershousing
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.CreateMap<Project, ProjectViewModel>();
            AutoMapper.Mapper.CreateMap<Project, ProjectViewModel>().ReverseMap();

            AutoMapper.Mapper.CreateMap<CustomerApplicationForm, CustomerApplicationFormViewModel>();
            AutoMapper.Mapper.CreateMap<CustomerApplicationForm, CustomerApplicationFormViewModel>().ReverseMap();

            AutoMapper.Mapper.CreateMap<Receipts, ReceiptsViewModel>();
            AutoMapper.Mapper.CreateMap<ReceiptsViewModel, Receipts>();
                                                
        }
    }
}