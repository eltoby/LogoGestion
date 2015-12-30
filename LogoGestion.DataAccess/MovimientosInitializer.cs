using System;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace LogoGestion.DataAccess
{
    public class MovimientosInitializer : DropCreateDatabaseAlways<LogoGestionContext>
    {
        protected override void Seed(LogoGestionContext context)
        {
            var persona1 = new Persona
            {
                Nombre = "Pablo"
            };

            var mov1 = new Movimiento 
            {
                Fecha = DateTime.Today,
                TipoMovimiento = "Bar",
                Concepto = "Bar",
                Importe = 1000M
            };

            persona1.Movimientos = new Collection<Movimiento> { mov1 };
            context.Personas.Add(persona1);

            base.Seed(context);
        }
    }
}
