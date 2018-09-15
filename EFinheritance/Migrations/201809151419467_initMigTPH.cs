namespace EFinheritance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initMigTPH : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SmartPhones",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        OS = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phones", t => t.Id)
                .Index(t => t.Id);
            
            DropColumn("dbo.Phones", "OS");
            DropColumn("dbo.Phones", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Phones", "OS", c => c.String());
            DropForeignKey("dbo.SmartPhones", "Id", "dbo.Phones");
            DropIndex("dbo.SmartPhones", new[] { "Id" });
            DropTable("dbo.SmartPhones");
        }
    }
}
