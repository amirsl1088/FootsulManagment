using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Migrations
{
    [Migration(202402171704)]
    public class _202402171704_AddTableTeam : Migration
    {
        public override void Up()
        {
            Create.Table("Teams")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(50).NotNullable()
                .WithColumn("FirstKit").AsInt16().NotNullable()
                .WithColumn("SecondKit").AsInt16().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Teams");
        }

    }
}
