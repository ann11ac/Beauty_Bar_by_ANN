using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Beauty_Bar_by_ANN.Models;

namespace Beauty_Bar_by_ANN.Data
{
    public class Beauty_Bar_by_ANNContext : DbContext
    {
        public Beauty_Bar_by_ANNContext (DbContextOptions<Beauty_Bar_by_ANNContext> options)
            : base(options)
        {
        }

        public DbSet<Beauty_Bar_by_ANN.Models.Service> Service { get; set; } = default!;
        public DbSet<Beauty_Bar_by_ANN.Models.Employee> Employee { get; set; } = default!;
        public DbSet<Beauty_Bar_by_ANN.Models.Appointment> Appointment { get; set; } = default!;
        public DbSet<Beauty_Bar_by_ANN.Models.Client> Client { get; set; } = default!;
    }
}
