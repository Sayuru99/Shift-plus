using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.AutoMapperProfiles;

public class Country : Profile
{
    public Country()
    {
        CreateMap<Entities.Country, CountryDTO>().ReverseMap();
    }
}

