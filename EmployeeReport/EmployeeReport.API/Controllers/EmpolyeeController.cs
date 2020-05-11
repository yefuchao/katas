using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeReport.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeReport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpolyeeController : ControllerBase
    {
        //https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/testing-sample
        private readonly IEmployeeRepository _repository;

        public EmpolyeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> GetEmpolyeeAgeOve18Async()
        {
            return Ok(await _repository.AgeOver18Async());
        }
    }
}