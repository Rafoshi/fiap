namespace apicsharp.Models
{
    public class Teste
    {
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;

        internal void Validate()
        {
            Nome = Nome.Trim();
        }
    }
}
