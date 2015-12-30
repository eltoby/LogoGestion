using System.Runtime.Serialization;

namespace LogoGestionApi.Models
{
    [DataContract]
    public class SaldosModel
    {
        public SaldosModel(int id, string nombre, decimal gastosBar, decimal gastosKiosco, decimal pago, decimal saldoAnt)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.GastosBar = gastosBar;
            this.GastosKiosco = gastosKiosco;
            this.Pago = pago;
            this.SaldoAnt = saldoAnt;
        }

        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public decimal GastosBar { get; set; }

        [DataMember]
        public decimal GastosKiosco { get; set; }

        [DataMember]
        public decimal Pago { get; set; }

        [DataMember]
        public decimal SaldoAnt { get; set; }
    }
}