namespace Beauty_Bar_by_ANN.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
