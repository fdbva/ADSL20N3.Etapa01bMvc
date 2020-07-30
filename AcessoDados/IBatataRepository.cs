namespace AcessoDados
{
    public interface IBatataRepository
    {
        int ObterQuantidade();

        void ReduzirQuantidade(int quantidadeVendida);
    }
}
