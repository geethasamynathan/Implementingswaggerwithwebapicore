using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImplementSwaggerUIDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage =" Name should not blank")]
        [StringLength(15,ErrorMessage ="{0} length must be between{2} and {1}",MinimumLength =3)]
        public string Name { get; set; }    
        public string Gender { get; set; }
        [Required (ErrorMessage ="Enter the Email id")]
        [DataType(DataType.EmailAddress)]
        public string Email  { get; set; }
        [Required]
        [Display(Name="Mobile No")]
        public long Phone { get; set; }
        [Range(10000,200000)]
        public long Salary { get; set; }
        [Range(1,50)]
        public int Experience { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passord and confirmpassowrd should be same")]
        public string ConfirmPassword { get; set; }
        public Department Department { get; set; }
    }
}
