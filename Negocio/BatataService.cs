using System;
using AcessoDados;

namespace Negocio
{
    public class BatataService : IBatataService
    {
        private readonly IBatataRepository _batataRepository;

        public BatataService(
            IBatataRepository batataRepository)
        {
            _batataRepository = batataRepository;
        }

        public string OlaComQuantidade(int quantidade)
        {
            var quantidadeEstoque = _batataRepository.ObterQuantidade();

            var quantidadeVendida = quantidadeEstoque >= quantidade 
                ? quantidade 
                : quantidadeEstoque;

            _batataRepository.ReduzirQuantidade(quantidadeVendida);

            return "Olá da Batata assada x" + quantidadeVendida;
        }
    }
}
