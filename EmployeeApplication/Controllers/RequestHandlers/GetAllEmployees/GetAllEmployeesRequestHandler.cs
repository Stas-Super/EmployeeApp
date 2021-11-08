using EmployeeApplication.DAL.EF;
using EmployeeApplication.DAL.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers.RequestHandlers.GetAllEmployees
{
    public class GetAllEmployeesRequestHandler : IRequestHandler<GetAllEmployees, IActionResult>
    {
        private readonly ApiDbContext ctx;

        public GetAllEmployeesRequestHandler(ApiDbContext _ctx) =>
            ctx = _ctx;

        public async Task<IActionResult> Handle(GetAllEmployees request, CancellationToken cancellationToken)
        {
            var employees = await ctx.Employees.ToListAsync();
            return new OkObjectResult(employees);
        }
    }
}
