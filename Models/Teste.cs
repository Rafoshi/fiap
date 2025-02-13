using LinqToDB.Mapping;

namespace apicsharp.Models
{
    [Table("Teste")]
    public class Teste
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column, NotNull]
        public string Nome { get; set; } = String.Empty;
    }
}
