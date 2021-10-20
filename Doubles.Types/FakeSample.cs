using Moq;
using System;
using Xunit;

namespace Doubles.Types
{
    public class FakeSample : IClassFixture<ProdutoFixture>
    {
        private readonly ProdutoFixture _produtoFixture;

        public FakeSample(ProdutoFixture produtoFixture)
        {
            _produtoFixture = produtoFixture;
        }

        [Fact]
        public void Test_Fake()
        {
            var produtoRepository = new ProdutoRepositoryFake();

            var produtoService = new ProdutoService(produtoRepository);

            var produto = new Produto() { Nome = "TECLADO" };
            
            produtoService.Adicionar(produto);
            
            Assert.NotEqual(0, produto.Id);
        }
    }
}
