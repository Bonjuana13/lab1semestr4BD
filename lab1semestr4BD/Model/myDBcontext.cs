using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1semestr4BD.Model
{
    public class myDBcontext : DbContext
    {
        public myDBcontext() : base("DefaultConnection")
        { }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Exhibit> Exhibits { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
