using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Models;

namespace DTO.DTO
{
    public class DriverMapper : Profile
    {

        public DriverMapper() {


            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<DriverDTO, Driver>().ReverseMap();




        }
    }
}
