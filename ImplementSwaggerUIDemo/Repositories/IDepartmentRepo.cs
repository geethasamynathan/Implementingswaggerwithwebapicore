using ImplementSwaggerUIDemo.Models;
using System.Collections.Generic;

namespace ImplementSwaggerUIDemo.Repositories
{
    public interface IDepartmentRepo
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        List<Department> GetDepartmentsByLocation(string location);
        string AddnewDepartment(Department department);
        string UpdateDepartment(Department department);
        string DeleteDepartment(int deptid);
    }
}
