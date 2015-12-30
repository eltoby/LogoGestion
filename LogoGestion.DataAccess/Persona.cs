using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogoGestion.DataAccess
{
    [Table("Personas")]
    public class Persona
    {
        public int PersonaId { get; set; }

        public string Nombre { get; set; }

        public ICollection<Movimiento> Movimientos { get; set; }
    }
}