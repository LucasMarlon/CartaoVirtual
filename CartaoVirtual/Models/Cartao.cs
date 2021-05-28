using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartaoVirtual.Models
{
    public class Cartao
    {
        public Cartao()
        {
            this.Numero = gerarNumeroCartao();
            this.DataCriacao = DateTime.Now;
        }

        public Cartao(string email)
        {
            this.EmailTitular = email;
            this.Numero = gerarNumeroCartao();
            this.DataCriacao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Numero { get; set; }
        public string EmailTitular { get; set; }
        public DateTime DataCriacao { get; }

        private string gerarNumeroCartao()
        {
            Random random = new Random();

            int parte1 = random.Next(1111, 9999);
            int parte2 = random.Next(1111, 9999);
            int parte3 = random.Next(1111, 9999);
            int parte4 = random.Next(1111, 9999);

            return parte1 + " " + parte2 + " " + parte3 + " " + parte4;
        }
    }
}
