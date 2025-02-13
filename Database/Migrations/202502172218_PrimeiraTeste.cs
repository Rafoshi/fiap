using FluentMigrator;

namespace apicsharp.Database.Migrations
{

    [Migration(202502172218)]
    public class _202502172218_PrimeiraTeste : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
               .WithColumn("Id").AsInt32().PrimaryKey().Identity()
               .WithColumn("Nome").AsString().NotNullable().WithDefaultValue("");
        }

        public override void Down() { }
    }
}
