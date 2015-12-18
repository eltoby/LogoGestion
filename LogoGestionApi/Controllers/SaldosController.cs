namespace LogoGestionApi.Controllers
{
    using Models;
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Web.Http.Cors;

    public class SaldosController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<SaldosModel> Get()
        {
            var saldo = new SaldosModel(0, "Pablo", 1, 2, 3, 4);
            return new[] { saldo };            
        }
    }
}
