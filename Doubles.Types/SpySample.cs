using Moq;
using System;
using Xunit;

namespace Doubles.Types
{
    public class SpySample
    {
        [Fact]
        public void Test_Spy()
        {
            //var produtoRepository = new Mock<ProdutoRepositoryFake>() { CallBase = true };
            var produtoRepository = new Mock<ProdutoRepositoryFake>() { CallBase = true }.As<IProdutoRepository>();

            var produtoService = new ProdutoService(produtoRepository.Object);

            var produto = new Produto() { Nome = "TECLADO" };


            produtoService.Adicionar(produto);

            Assert.NotEqual(0, produto.Id);
            produtoRepository.Verify(o => o.Adicionar(It.IsAny<Produto>()), Times.Once());
        }
    }
}
