using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Runtime.InteropServices;

namespace testdb.Migrations
{
   
        public partial class init: Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Migrationbuilder.createTable(
                name = savestudentdata
                columns: Table => new
                {
                    name = Table.column<string>(Type: "nvarchar(450)", Nullable: false),
                    Section = Table.column<string>(Type: "nvarchar(450)", Nullable: false)
                }
                constraints: Table =>
                {
                Table.primarykey(),);

                }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            base.Down(migrationBuilder);
        }
    }
    }
    }
}
