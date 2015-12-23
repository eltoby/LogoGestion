namespace LogoGestionApi.Controllers
{
    using Models;
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Web.Http.Cors;

    public class SaldosController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<SaldosModel> GetSaldos()
        {
            var saldo = new SaldosModel(1, "Pablo", 1, 2, 3, 4);
            var saldo2 = new SaldosModel(2, "Pablo2", 1, 2, 3, 4);
            return new[] { saldo, saldo2 };            
        }
    }
}
