using LinqToDB.Mapping;

namespace apicsharp.Models
{
    [Table(Name = "Teste")]
    public class Teste
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "Nome"), NotNull]
        public string Nome { get; set; } = String.Empty;
    }
}
