using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
         Task<IEnumerable<Produto>> GetProdutosByFornecedor(Guid fornecedorId);
         Task<IEnumerable<Produto>> GetProdutosFornecedores();
         Task<Produto> GetProdutoFornecedor(Guid id);
    }
}