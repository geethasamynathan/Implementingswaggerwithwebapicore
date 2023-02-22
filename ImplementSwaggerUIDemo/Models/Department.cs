using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ImplementSwaggerUIDemo.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(30)]
        public string DepartmentName { get; set; }
        [Required]
        [StringLength(30)]
        public string Location { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
