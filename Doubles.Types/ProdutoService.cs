namespace Doubles.Types
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Adicionar(Produto produto)
        {
            if (produto.EstaValido())
                _produtoRepository.Adicionar(produto);
        }

        public Produto Obter(int id)
        {
            return _produtoRepository.Obter(id);
        }
    }
}
