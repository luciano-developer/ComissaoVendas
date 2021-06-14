using ComissaoVenda.Models;
using System.Collections.Generic;

namespace ComissaoVenda.Services
{
    public interface IVendaService
    {
        IEnumerable<RELATORIO> GetTotalComissoesVendasEmpregados();
    }
}
