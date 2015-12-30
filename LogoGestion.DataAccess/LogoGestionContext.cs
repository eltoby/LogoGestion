namespace LogoGestion.DataAccess
{
    using System.Data.Entity;

    public class LogoGestionContext : DbContext
    {
        public LogoGestionContext() : base("LogoGestionContext")
        {
            Database.SetInitializer(new MovimientosInitializer());
        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Movimiento> Movimientos { get; set; }
    }
}
