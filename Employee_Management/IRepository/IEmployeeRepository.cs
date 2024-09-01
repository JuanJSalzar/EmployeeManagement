using System.Web.Mvc;
using System.Threading.Tasks;
using Employee_Management.Models;

namespace Employee_Management.IRepository
{
    public interface IEmployeeRepository
    {
        Task<ActionResult> GetEmployees();
        Task<ActionResult> GetEmployeeById(int id);
        Task<ActionResult> AddEmployee(Employee employee);
        Task<ActionResult> UpdateEmployee(Employee employee);
        Task<ActionResult> DeleteEmployee(int id);
    }
}
