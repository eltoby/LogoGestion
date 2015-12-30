using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogoGestion.DataAccess
{
    [Table("Movimientos")]
    public class Movimiento
    {
        public int MovimientoId { get; set; }

        public Persona Persona { get; set; }

        public DateTime Fecha { get; set; }

        public string TipoMovimiento { get; set; }

        public string Concepto { get; set; }

        public decimal Importe { get; set; }
    }
}