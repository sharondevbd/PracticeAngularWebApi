using AngularWebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebApi.Controllers
{
    public class EmployeeController : Controller
    {
        readonly EmployeRepository _employeRepository;
        public EmployeeController(EmployeRepository employeRepository)
        {
            _employeRepository = employeRepository;
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee([FromBody] Employee model)
        {
            await _employeRepository.AddEmployee(model);
            return Ok();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
