namespace Lb6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.author_Id)
                .Index(t => t.author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "author_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "author_Id" });
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
