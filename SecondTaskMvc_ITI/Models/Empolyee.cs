using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondTaskMvc_ITI.Models
{
    public class Empolyee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int? Salary { get; set; }
        public string? email { get; set; }
        [ForeignKey("Office")]
        public int? Office_Id { get; set;}
        public string? Password { get; set;}

        public Office? Office { get; set; }

        public List<Emp_Project>? EmpolyeeProject { get; set; }

    }
}
