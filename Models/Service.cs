using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beauty_Bar_by_ANN.Models
{
    public class Service
    {
        public int ID { get; set; }
        [Display(Name = "Service Type")]
        public string Type { get; set; }
        public string Duration { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

      
        public int? EmployeeID {  get; set; }
        public Employee? Employee {  get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
