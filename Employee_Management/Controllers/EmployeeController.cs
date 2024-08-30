using System.Web.Mvc;
using System.Data.Entity;
using System.Threading.Tasks;
using Employee_Management.Models;
using Employee_Management.Context;

namespace Employee_Management.Controllers
{
    public class EmployeeController : Controller
    {
        // Dependency Injection of the database context.
        private readonly EmployeeDbContext _context = new EmployeeDbContext();

        /// <summary>
        /// Displays the main view of the Employee Management.
        /// Route: /Employee/Index
        /// </summary>
        /// <returns>Returns the view for the Employee Management page.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Fetches the list of all employees asynchronously.
        /// Route: /Employee/GetEmployees
        /// </summary>
        /// <returns>Returns a JSON object containing the list of employees.</returns>
        public async Task<JsonResult> GetEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Fetches a specific employee by their ID asynchronously.
        /// Route: /Employee/GetEmployeeById/{id}
        /// </summary>
        /// <param name="id">The ID of the employee to fetch.</param>
        /// <returns>Returns a JSON object containing the employee's details.</returns>
        public async Task<JsonResult> GetEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Adds a new employee to the database asynchronously.
        /// Route: /Employee/AddEmployee
        /// </summary>
        /// <param name="employee">The employee object containing the new employee's details.</param>
        /// <returns>Returns a JSON object containing the added employee's details.</returns>
        [HttpPost]
        public async Task<JsonResult> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Json(employee);
        }

        /// <summary>
        /// Updates the details of an existing employee asynchronously.
        /// Route: /Employee/UpdateEmployee
        /// </summary>
        /// <param name="employee">The employee object containing the updated employee's details.</param>
        /// <returns>Redirects to the Index view if successful, otherwise returns the view with the employee details.</returns>
        [HttpPost]
        public async Task<ActionResult> UpdateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(employee).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        /// <summary>
        /// Deletes an employee by their ID asynchronously.
        /// Route: /Employee/DeleteEmployee
        /// </summary>
        /// <param name="id">The ID of the employee to delete.</param>
        /// <returns>Returns a JSON object containing the deleted employee's details.</returns>
        [HttpPost]
        public async Task<JsonResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
            return Json(employee);
        }
    }
}
