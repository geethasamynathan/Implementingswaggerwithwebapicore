using ImplementSwaggerUIDemo.Models;
using ImplementSwaggerUIDemo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ImplementSwaggerUIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepo Repositories=null;
            public DepartmentController(IDepartmentRepo repo)
        {
            Repositories = repo;
        }
        [HttpGet]
        public ActionResult<List<Department>> Get()
        {
           List<Department> departments= Repositories.GetAllDepartments();
            if (departments.Count > 0)
            {
                return departments;
            }
            else
                return NotFound();
        }
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult<Department> Get(int id)
        {
            Department department = Repositories.GetDepartmentById(id);
            if (department != null)
            {
                return department;
            }
            else
                return NotFound();
        }

        [Route("{location:alpha}")]
        [HttpGet]
        public ActionResult<List<Department>> Get(string location)
        {
            List<Department> departments = Repositories.GetDepartmentsByLocation(location);
            if (departments.Count>0)
            {
                return departments;
            }
            else
                return NotFound();
        }

        [HttpPost]
        public string Post(Department department)
        {
            string Response=Repositories.AddnewDepartment(department);
            return Response;
        }

        [HttpPut]
        public string Put(Department department)
        {
            string Response = Repositories.UpdateDepartment(department);
            return Response;
        }
        [Route("{id:int}")]
        [HttpDelete]
        public string Delete(int id)
        {
            string Response = Repositories.DeleteDepartment(id);
            return Response;
        }
    }
}
