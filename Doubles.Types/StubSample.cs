using Moq;
using System;
using Xunit;

namespace Doubles.Types
{
    public class StubSample
    {
        [Fact]
        public void Test_Stub()
        {
            var produtoRepository = new Mock<IProdutoRepository>();

            produtoRepository.Setup(o => o.Obter(1)).Returns(new Produto() { Id = 1, Nome = "TECLADO" });

            var produtoService = new ProdutoService(produtoRepository.Object);

            var produto = produtoService.Obter(1);

            Assert.Equal(1, produto.Id);
        }
    }
}
