using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdsetIntegrato.MVC.Controllers;
using AutoMapper;

namespace AdsetIntegrato.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}