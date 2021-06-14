using ComissaoVenda.Models;
using System.Collections.Generic;

namespace ComissaoVenda.Repositories
{
    public interface IVendaRepository
    {
        IEnumerable<RELATORIO> GetTotalComissoesVendasEmpregados();
    }
}
