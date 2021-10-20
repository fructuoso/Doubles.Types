namespace Doubles.Types
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Propriedade1 { get; set; }
        public string Propriedade2 { get; set; }
        public string Propriedade3 { get; set; }

        public bool EstaValido() => !string.IsNullOrEmpty(Nome);
    }
}
