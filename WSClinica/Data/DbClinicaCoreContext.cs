using Microsoft.EntityFrameworkCore;
using WSClinica.Models;

namespace WSClinica.Data
{
    public class DbClinicaCoreContext: DbContext
    {

        public DbClinicaCoreContext(DbContextOptions<DbClinicaCoreContext> options): base(options) { }

        public DbSet<Clinica> Clinicas { get; set; }

        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
