using System.Collections.Generic;

namespace Core.Domain.Services
{
    public interface IEmployeeService
    {
        IEnumerable<ApplicationUser> GetEmployees();
    }
}