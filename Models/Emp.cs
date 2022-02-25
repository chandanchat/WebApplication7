using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Emp
    { 
        [Key]
        public int Id { get; set; } 
        public string ?Name { get; set; }
        public int age { get; set; }    
    }
    
}
