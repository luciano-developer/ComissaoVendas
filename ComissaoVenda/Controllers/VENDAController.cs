using ComissaoVenda.Services;
using System.Web.Mvc;

namespace ComissaoVenda.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaService _vendaService;

        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }
        // GET: VENDA
        public ActionResult Index()
        {
            return View();           
        }

        // GET: Venda/RelatorioComissao
        public ActionResult RelatorioComissao()
        {
            var result = _vendaService.GetTotalComissoesVendasEmpregados();
                                      
            return View(result);
        }
    }
}
