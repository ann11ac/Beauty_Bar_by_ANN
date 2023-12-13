namespace Beauty_Bar_by_ANN.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }

        public ICollection<Service>? Services { get; set;}
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
