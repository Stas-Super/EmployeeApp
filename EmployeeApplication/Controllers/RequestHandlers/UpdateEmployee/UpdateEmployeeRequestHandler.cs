using AutoMapper;
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

namespace EmployeeApplication.Controllers.RequestHandlers.UpdateEmployee
{
    public class UpdateEmployeeRequestHandler : IRequestHandler<UpdateEmployee, IActionResult>
    {
        private readonly ApiDbContext ctx;
        private readonly IMapper mapper;

        public UpdateEmployeeRequestHandler(ApiDbContext _ctx, IMapper _mapper)
        {
            ctx = _ctx;
            mapper = _mapper;
        }

        public async Task<IActionResult> Handle(UpdateEmployee request, CancellationToken cancellationToken)
        {
            var model = mapper.Map<Employee>(request.Model);
            var employee = await ctx.Employees
                .Where(e => e.PhoneNumber == request.Model.PhoneNumber)
                .FirstOrDefaultAsync();
            employee = model;
            employee.Position = model.Position;
            ctx.Employees.Update(employee);
            await ctx.SaveChangesAsync();
            return new OkObjectResult(employee);
        }
    }
}
