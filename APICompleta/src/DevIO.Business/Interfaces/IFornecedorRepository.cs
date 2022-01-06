using System;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
         
         Task<Fornecedor> GetFornecedorEndereco(Guid id);
         Task<Fornecedor> GetFornecedorProdutosEndereco(Guid id);
    }
}