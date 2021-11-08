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

namespace EmployeeApplication.Controllers.RequestHandlers.CreateEmployee
{
    public class CreateEmployeeRequestHandler : IRequestHandler<CreateEmployee, IActionResult>
    {
        private readonly ApiDbContext ctx;
        private readonly IMapper mapper;

        public CreateEmployeeRequestHandler(ApiDbContext _ctx, IMapper _mapper)
        {
            ctx = _ctx;
            mapper = _mapper;
        }

        public async Task<IActionResult> Handle(CreateEmployee request, CancellationToken cancellationToken)
        {
            var employee = await ctx.Employees
                .Where(e => e.PhoneNumber == request.Model.PhoneNumber)
                .FirstOrDefaultAsync();
            if (employee != null)
                return new BadRequestResult();
            var model = mapper.Map<Employee>(request.Model);
            await ctx.Employees.AddAsync(model);

            await ctx.SaveChangesAsync(cancellationToken);
            return new OkObjectResult(model);
        }
    }
}
