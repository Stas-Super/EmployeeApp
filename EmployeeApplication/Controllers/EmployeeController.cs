using EmployeeApplication.Controllers.RequestHandlers.CreateEmployee;
using EmployeeApplication.Controllers.RequestHandlers.DeleteEmployee;
using EmployeeApplication.Controllers.RequestHandlers.GetAllEmployees;
using EmployeeApplication.Controllers.RequestHandlers.UpdateEmployee;
using EmployeeApplication.DAL.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers
{
    [Route("api/employees")]
    public class EmployeeController : Controller
    {
        private IMediator mediator;
       
        public EmployeeController(IMediator _meidator) =>
            mediator = _meidator;

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeModel model) =>
            await mediator.Send(new CreateEmployee(model));

        [HttpDelete("{id:int}")]
        public async Task Delete([FromRoute] int id) =>
            await mediator.Send(new DeleteEmployee(id));

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            await mediator.Send(new GetAllEmployees());

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateEmployeeModel model) =>
            await mediator.Send(new UpdateEmployee(model));
    }
}
