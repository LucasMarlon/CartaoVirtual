using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoVirtual.Models;
using CartaoVirtual.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartaoVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartoesController : ControllerBase
    {
        private readonly ICartaoRepository _cartaoRepository;
        public CartoesController(ICartaoRepository cartaoRepository)
        {
            _cartaoRepository = cartaoRepository;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Cartao>> GetCartoes()
        {
            return await _cartaoRepository.Get();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Cartao>> GetCartao(int id)
        {
            return await _cartaoRepository.Get(id);
        }

        [HttpGet("titular/{email}")]
        public async Task<IEnumerable<Cartao>> GetCartoesPorEmail(string email)
        {
            var cartoes = await _cartaoRepository.Get();
            var cartoesTitular = from c in cartoes
                                 where c.EmailTitular == email
                                 orderby c.DataCriacao
                                 select c;

            return cartoesTitular;
        }

        [HttpPost("{email}")]
        public async Task<ActionResult<Cartao>> PostCartao(string email)
        {
            Cartao cartao = new Cartao(email);
            var novoCartao = await _cartaoRepository.Create(cartao);
            return novoCartao;
        }
                
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCartao(int id)
        {
            var cartaoDeletado = await _cartaoRepository.Get(id);
            if(cartaoDeletado == null)
            {
                return NotFound();
            }
            await _cartaoRepository.Delete(cartaoDeletado.Id);
            return NoContent();
        }
    }
}
