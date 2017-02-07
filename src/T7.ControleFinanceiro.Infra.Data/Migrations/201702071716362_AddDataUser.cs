namespace T7.ControleFinanceiro.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataUser : DbMigration
    {
        public override void Up()
        {         
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.AspNetUsers", "DateBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DateBirth");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}