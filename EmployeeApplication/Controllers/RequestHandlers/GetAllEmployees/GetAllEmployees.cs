using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers.RequestHandlers.GetAllEmployees
{
    public class GetAllEmployees : IRequest<IActionResult>
    {
    }
}
