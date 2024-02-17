using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Migrations
{
    [Migration(202402172007)]
    public class _202402172007_AddTablePlayer : Migration
    {
        public override void Up()
        {
            Create.Table("Players")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("FirstName").AsString().NotNullable()
                .WithColumn("LastName").AsString().NotNullable()
                .WithColumn("BirthDay").AsDateTime().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Players");
        }

    }
}
