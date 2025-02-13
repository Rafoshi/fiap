using FluentMigrator;

namespace apicsharp.Database.Migrations
{

    [Migration(202502172217)]
    public class CreateInitialDatabase : Migration
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
