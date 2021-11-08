using AutoMapper;
using EmployeeApplication.Controllers.RequestHandlers.CreateEmployee;
using EmployeeApplication.Controllers.RequestHandlers.UpdateEmployee;
using EmployeeApplication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers.RequestHandlers.Shared.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreateEmployeeModel, Employee>();
            CreateMap<UpdateEmployeeModel, Employee>();
        }
    }
}
