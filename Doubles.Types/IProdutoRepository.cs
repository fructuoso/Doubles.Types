namespace Doubles.Types
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        Produto Obter(int id);
    }
}
