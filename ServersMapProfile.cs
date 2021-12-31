using AutoMapper;
using ServerBrowser.Entities;
using ServerBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerBrowser
{
    public class ServersMapProfile : Profile
    {
        public ServersMapProfile()
        {
            CreateMap<CreateServersMap, Servers>().ForMember(r => r.Ip,
                c => c.MapFrom(s => s.Ip));
        }
    }
}
