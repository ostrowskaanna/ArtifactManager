namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedAllModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Size = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Cave_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caves", t => t.Cave_Id, cascadeDelete: true)
                .Index(t => t.Cave_Id);
            
            CreateTable(
                "dbo.Caves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Area = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dragons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Power = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                        Cave_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caves", t => t.Cave_Id, cascadeDelete: true)
                .Index(t => t.Cave_Id);
            
            CreateTable(
                "dbo.Ents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Power = c.Int(nullable: false),
                        Courage = c.Int(nullable: false),
                        Forest_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forests", t => t.Forest_Id, cascadeDelete: true)
                .Index(t => t.Forest_Id);
            
            CreateTable(
                "dbo.Forests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Area = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Giants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Height = c.Int(nullable: false),
                        Sight = c.Int(nullable: false),
                        Forest_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forests", t => t.Forest_Id, cascadeDelete: true)
                .Index(t => t.Forest_Id);
            
            CreateTable(
                "dbo.Knights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Power = c.Int(nullable: false),
                        Courage = c.Int(nullable: false),
                        Tower_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Towers", t => t.Tower_Id, cascadeDelete: true)
                .Index(t => t.Tower_Id);
            
            CreateTable(
                "dbo.Towers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Height = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Magus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Power = c.Int(nullable: false),
                        Smart = c.Int(nullable: false),
                        Tower_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Towers", t => t.Tower_Id, cascadeDelete: true)
                .Index(t => t.Tower_Id);
            
            CreateTable(
                "dbo.Spiders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Speed = c.Int(nullable: false),
                        Sight = c.Int(nullable: false),
                        Cave_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caves", t => t.Cave_Id, cascadeDelete: true)
                .Index(t => t.Cave_Id);
            
            CreateTable(
                "dbo.Witches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Power = c.Int(nullable: false),
                        Smart = c.Int(nullable: false),
                        Tower_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Towers", t => t.Tower_Id, cascadeDelete: true)
                .Index(t => t.Tower_Id);
            
            CreateTable(
                "dbo.Wolves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Power = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Forest_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forests", t => t.Forest_Id, cascadeDelete: true)
                .Index(t => t.Forest_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wolves", "Forest_Id", "dbo.Forests");
            DropForeignKey("dbo.Witches", "Tower_Id", "dbo.Towers");
            DropForeignKey("dbo.Spiders", "Cave_Id", "dbo.Caves");
            DropForeignKey("dbo.Magus", "Tower_Id", "dbo.Towers");
            DropForeignKey("dbo.Knights", "Tower_Id", "dbo.Towers");
            DropForeignKey("dbo.Towers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Towers", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Giants", "Forest_Id", "dbo.Forests");
            DropForeignKey("dbo.Ents", "Forest_Id", "dbo.Forests");
            DropForeignKey("dbo.Forests", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Forests", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Dragons", "Cave_Id", "dbo.Caves");
            DropForeignKey("dbo.Bats", "Cave_Id", "dbo.Caves");
            DropForeignKey("dbo.Caves", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Caves", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Wolves", new[] { "Forest_Id" });
            DropIndex("dbo.Witches", new[] { "Tower_Id" });
            DropIndex("dbo.Spiders", new[] { "Cave_Id" });
            DropIndex("dbo.Magus", new[] { "Tower_Id" });
            DropIndex("dbo.Towers", new[] { "User_Id" });
            DropIndex("dbo.Towers", new[] { "Category_Id" });
            DropIndex("dbo.Knights", new[] { "Tower_Id" });
            DropIndex("dbo.Giants", new[] { "Forest_Id" });
            DropIndex("dbo.Forests", new[] { "User_Id" });
            DropIndex("dbo.Forests", new[] { "Category_Id" });
            DropIndex("dbo.Ents", new[] { "Forest_Id" });
            DropIndex("dbo.Dragons", new[] { "Cave_Id" });
            DropIndex("dbo.Caves", new[] { "User_Id" });
            DropIndex("dbo.Caves", new[] { "Category_Id" });
            DropIndex("dbo.Bats", new[] { "Cave_Id" });
            DropTable("dbo.Wolves");
            DropTable("dbo.Witches");
            DropTable("dbo.Spiders");
            DropTable("dbo.Magus");
            DropTable("dbo.Towers");
            DropTable("dbo.Knights");
            DropTable("dbo.Giants");
            DropTable("dbo.Forests");
            DropTable("dbo.Ents");
            DropTable("dbo.Dragons");
            DropTable("dbo.Categories");
            DropTable("dbo.Caves");
            DropTable("dbo.Bats");
        }
    }
}
