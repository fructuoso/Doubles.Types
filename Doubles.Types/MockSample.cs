using Moq;
using System;
using Xunit;

namespace Doubles.Types
{
    public class MockSample
    {
        [Fact]
        public void Test_Mock()
        {
            var produtoRepository = new Mock<IProdutoRepository>();

            var produtoService = new ProdutoService(produtoRepository.Object);

            //INVALIDO
            var produto = new Produto();

            produtoService.Adicionar(produto);

            produtoRepository.Verify(o => o.Adicionar(It.IsAny<Produto>()), Times.Never());
        }
    }
}
