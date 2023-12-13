using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beauty_Bar_by_ANN.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        

        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Display(Name = "Appointment Time")]
        [DataType(DataType.Time)]
        public DateTime AppointmentTime { get; set; }
        public int? ServiceID { get; set; }
        [ForeignKey("ServiceID")]
        public Service? Service { get; set; }

       
        public int? EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee? Employee { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }
        public int? ClientID { get; set; }
        public Client? Client { get; set; }
    }
}
