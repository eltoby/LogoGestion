namespace LogoGestionApi.Models
{
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
        public int Id { get; set; }
        
        public string Nombre { get; set; }

        public decimal GastosBar { get; set; }

        public decimal GastosKiosco { get; set; }

        public decimal Pago { get; set; }

        public decimal SaldoAnt { get; set; }
    }
}