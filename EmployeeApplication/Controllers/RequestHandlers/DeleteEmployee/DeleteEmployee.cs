using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers.RequestHandlers.DeleteEmployee
{
    public class DeleteEmployee : IRequest<IActionResult>
    {
        public DeleteEmployee(int id) =>
            Id = id;

        public int Id { get; }
    }
}
