using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Migrations
{
    [Migration(202402180042)]
    public class _202402180042_AddTeamId : Migration
    {
        public override void Up()
        {
            Alter.Table("Players")
                .AddColumn("TeamId").AsInt32().Nullable();
        }
        public override void Down()
        {
            Delete.Column("TeamId").FromTable("Players");
        }

    }
}
