using BAF.Data.EFCore.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace BAF.Konsole
{

    public class Profiler : Service.Core.Mapper.MapperProfile
    {
        public Profiler()
        {
            CreateMap<ObjectModel, DomainModel>().ReverseMap();
        }
    }
}