using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoVirtual.Models;
using CartaoVirtual.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CartaoVirtual.Repositories
{
    public class CartaoRepository : ICartaoRepository
    {
        private readonly CartaoContext _context;

        public CartaoRepository(CartaoContext context)
        {
            _context = context;
        }

        public async Task<Cartao> Create(Cartao cartao)
        {
            _context.Cartoes.Add(cartao);
            await _context.SaveChangesAsync();

            return cartao;
        }

        public async Task<IEnumerable<Cartao>> Get()
        {
            return await _context.Cartoes.ToListAsync();
        }

        public async Task<IEnumerable<Cartao>> Get(string email)
        {
            return await _context.Cartoes.ToListAsync();
        }

        public async Task<Cartao> Get(int id)
        {
            return await _context.Cartoes.FindAsync(id);
        }

        public async Task Delete(int id)
        {
            var cartaoDeletado = await _context.Cartoes.FindAsync(id);
            _context.Cartoes.Remove(cartaoDeletado);
            await _context.SaveChangesAsync();
        }
    }
}
