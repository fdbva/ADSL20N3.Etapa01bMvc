using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class BatataRepository : IBatataRepository
    {
        public int Estoque = 30;

        public BatataRepository()
        {
            Estoque++;
        }

        public int ObterQuantidade()
        {
            return Estoque;
        }

        public void ReduzirQuantidade(int quantidadeVendida)
        {
            Estoque -= quantidadeVendida;
        }
    }
}
