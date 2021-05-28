using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoVirtual.Models;

namespace CartaoVirtual.Repositories
{
    public interface ICartaoRepository
    {
        Task<IEnumerable<Cartao>> Get();
        Task<IEnumerable<Cartao>> Get(string email);
        Task<Cartao> Create(Cartao cartao);
        Task<Cartao> Get(int id);
        Task Delete(int id);
    }
}
