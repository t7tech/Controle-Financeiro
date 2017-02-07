namespace T7.ControleFinanceiro.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableClaim : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetClaims",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Name = c.String(nullable: false, maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AspNetClaims");
        }
    }
}
