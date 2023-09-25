using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SecondTaskMvc_ITI.Models
{
    public class Office
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }

        public List<Empolyee>? listOfEmpolyee { get; set; }
    }
}
