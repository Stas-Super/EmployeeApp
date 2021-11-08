using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers.RequestHandlers.CreateEmployee
{
    public class CreateEmployee : IRequest<IActionResult>
    {
        public CreateEmployee(CreateEmployeeModel model) =>
            Model = model;

        public CreateEmployeeModel Model { get; set; }
    }
}
