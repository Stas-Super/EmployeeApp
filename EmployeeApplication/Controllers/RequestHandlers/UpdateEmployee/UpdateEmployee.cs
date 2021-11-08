using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers.RequestHandlers.UpdateEmployee
{
    public class UpdateEmployee : IRequest<IActionResult>
    {
        public UpdateEmployee(UpdateEmployeeModel model) =>
            Model = model;

        public UpdateEmployeeModel Model { get; }
    }
}
