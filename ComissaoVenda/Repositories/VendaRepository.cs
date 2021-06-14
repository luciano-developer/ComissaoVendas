using ComissaoVenda.Models;
using System.Collections.Generic;
using System.Linq;

namespace ComissaoVenda.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private ComissaoVendaContext db = new ComissaoVendaContext();
        
        
        public IEnumerable<RELATORIO> GetTotalComissoesVendasEmpregados()
        {
            return db.Database
                .SqlQuery<RELATORIO>("dbo.ListarComissoesVendedores")
                .ToList();
        }
    }
}