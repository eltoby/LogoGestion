namespace LogoGestionApi.Controllers
{
    using LogoGestion.DataAccess;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;

    public class SaldosController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<SaldosModel> GetSaldos()
        {
            using (var context = new LogoGestionContext())
            {
                foreach (var persona in context.Personas)
                {
                    var movimientos = persona.Movimientos;
                    var totalBar = 50M;
                    if (movimientos != null)
                    {
                        var gastosBar = movimientos.Where(x => x.TipoMovimiento == "Bar").ToArray();
                        totalBar = gastosBar.Sum(x => x.Importe);
                    }

                    yield return new SaldosModel(persona.PersonaId, persona.Nombre, totalBar, 0, 0, 100);
                }
            }
        }
    }
}
