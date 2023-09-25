using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondTaskMvc_ITI.Models
{ 
    [PrimaryKey("Emp_Id" , "Project_Id")]
    public class Emp_Project
    {
        [ForeignKey("empolyee")]
        public int? Emp_Id { get; set; }
        [ForeignKey("project")]
        public int? Project_Id { get;  set; }
        public int? WorkHours { get; set; }

        public Empolyee? empolyee { get; set; }

        public Project? project { get; set; }
    }
}
