using EmployeeApplication.DAL.EF;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers.RequestHandlers.DeleteEmployee
{
    public class DeleteEmployeeRequestHandler : IRequestHandler<DeleteEmployee, IActionResult>
    {
        private readonly ApiDbContext ctx;

        public DeleteEmployeeRequestHandler(ApiDbContext _ctx) =>
            ctx = _ctx;

        public async Task<IActionResult> Handle(DeleteEmployee request, CancellationToken cancellationToken)
        {
            var employee = await ctx.Employees
                .Where(e => e.Id == request.Id)
                .FirstOrDefaultAsync();
            ctx.Remove(employee);
            return new OkObjectResult("Employee was removed");
        }
    }
}
