using System.Collections.Generic;
using System.Linq;

namespace Doubles.Types
{
    public class ProdutoRepositoryFake : IProdutoRepository
    {
        private readonly IList<Produto> _repositorio;
        private int _contador { get; set; }

        public ProdutoRepositoryFake()
        {
            _repositorio = new List<Produto>();
        }

        public void Adicionar(Produto produto)
        {
            produto.Id = ++_contador;

            _repositorio.Add(produto);
        }

        public Produto Obter(int id)
        {
            return _repositorio.FirstOrDefault(o => o.Id == id);
        }
    }
}
