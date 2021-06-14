using ComissaoVenda.Models;
using ComissaoVenda.Repositories;
using System.Collections.Generic;

namespace ComissaoVenda.Services
{
    public class VendaService: IVendaService
    {
       
        private readonly IVendaRepository _vendaRepository;
        public VendaService(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository; 
        }

        public IEnumerable<RELATORIO> GetTotalComissoesVendasEmpregados() =>
            _vendaRepository.GetTotalComissoesVendasEmpregados();
        
    }
}