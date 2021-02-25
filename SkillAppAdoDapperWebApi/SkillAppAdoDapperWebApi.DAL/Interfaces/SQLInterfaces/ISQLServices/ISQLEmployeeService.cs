using SkillManagement.DataAccess.Entities.SQLEntities;
using System.Collections.Generic;

namespace SkillManagement.DataAccess.Interfaces
{
    public interface ISQLEmployeeService
    {
        long AddEmployee(Product employee);

        void UpdateEmployee(Product employee);

        void DeleteEmployee(Product employee);
        Product GetEmployeeById(long Id);
        IEnumerable<Product> GetAllEmployees();
    }
}
