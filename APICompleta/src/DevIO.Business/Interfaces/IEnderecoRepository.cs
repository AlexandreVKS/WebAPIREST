using System;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
         Task<Endereco> GetEnderecoByFornecedor(Guid fornecedorId);
    }
}