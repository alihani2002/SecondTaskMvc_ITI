using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SecondTaskMvc_ITI.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public List<Emp_Project>? empProject { get; set; }

    }
}
