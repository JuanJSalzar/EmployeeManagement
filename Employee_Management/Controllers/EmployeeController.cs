using System.Web.Mvc;
using System.Data.Entity;
using System.Threading.Tasks;
using Antlr.Runtime.Misc;
using Employee_Management.Models;
using Employee_Management.Context;
using Employee_Management.IRepository;

namespace Employee_Management.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetEmployees()
        {
            return await _employeeRepository.GetEmployees();
        }

        public async Task<ActionResult> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetEmployeeById(id);
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(Employee employee)
        {
            return await _employeeRepository.AddEmployee(employee);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateEmployee(Employee employee)
        {
            return await _employeeRepository.UpdateEmployee(employee);
        }

        [HttpPost]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            return await _employeeRepository.DeleteEmployee(id);
        }
    }
}
