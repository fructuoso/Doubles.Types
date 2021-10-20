using System;
using System.Collections.Generic;
using System.Text;

namespace Doubles.Types
{
    public class ProdutoFixture
    {
        public Produto CriarValido() { return new Produto() { Nome = "TECLADO" }; }
    }
}
