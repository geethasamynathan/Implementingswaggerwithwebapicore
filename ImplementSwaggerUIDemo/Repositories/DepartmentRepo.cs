using ImplementSwaggerUIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplementSwaggerUIDemo.Repositories
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private MyDbContext context;
        public DepartmentRepo(MyDbContext _context)
        {
            context= _context;
        }
        public string AddnewDepartment(Department department)
        {
            int count = context.Departments.Count();
            context.Departments.Add(department);
            context.SaveChanges();
            int newCount= context.Departments.Count();
            if (newCount > count)
            {
                return "Record inserted successfully";
            }
            else
                return "oops something went wrong while inserting the record";
        }

        public string DeleteDepartment(int deptid)
        {
            Department dept= context.Departments.Find(deptid);
            if (dept != null)
            {
                context.Departments.Remove(dept);
                context.SaveChanges();

                return "Department removed from Database";
            }
            else
            {
                return " Given Department  is not available";
            }
        }

        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            Department department = context.Departments.Find(id);
            return department;
        }

        public List<Department> GetDepartmentsByLocation(string location)
        {

            List<Department> deparments = context.Departments.Where(d => d.Location == location).ToList();
            return deparments;
        }

        public string UpdateDepartment(Department department)
        {
            Department updatedepartment = context.Departments.Find(department.DepartmentId);
            if(updatedepartment != null)
            {
                updatedepartment.DepartmentName = department.DepartmentName;
                updatedepartment.Location = department.Location;
                context.Departments.Update(updatedepartment);
                context.SaveChanges();
                return "Department details  updated successfully";
            }
            else
            {
                return "Given Department is not available to update";
            }
        }
    }
}
