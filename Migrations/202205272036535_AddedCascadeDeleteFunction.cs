namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCascadeDeleteFunction : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Bats", new[] { "Cave_Id" });
            DropIndex("dbo.Dragons", new[] { "Cave_Id" });
            DropIndex("dbo.Ents", new[] { "Forest_Id" });
            DropIndex("dbo.Giants", new[] { "Forest_Id" });
            DropIndex("dbo.Knights", new[] { "Tower_Id" });
            DropIndex("dbo.Magus", new[] { "Tower_Id" });
            DropIndex("dbo.Spiders", new[] { "Cave_Id" });
            DropIndex("dbo.Witches", new[] { "Tower_Id" });
            DropIndex("dbo.Wolves", new[] { "Forest_Id" });
            AlterColumn("dbo.Bats", "Cave_Id", c => c.Int());
            AlterColumn("dbo.Dragons", "Cave_Id", c => c.Int());
            AlterColumn("dbo.Ents", "Forest_Id", c => c.Int());
            AlterColumn("dbo.Giants", "Forest_Id", c => c.Int());
            AlterColumn("dbo.Knights", "Tower_Id", c => c.Int());
            AlterColumn("dbo.Magus", "Tower_Id", c => c.Int());
            AlterColumn("dbo.Spiders", "Cave_Id", c => c.Int());
            AlterColumn("dbo.Witches", "Tower_Id", c => c.Int());
            AlterColumn("dbo.Wolves", "Forest_Id", c => c.Int());
            CreateIndex("dbo.Bats", "Cave_Id");
            CreateIndex("dbo.Dragons", "Cave_Id");
            CreateIndex("dbo.Ents", "Forest_Id");
            CreateIndex("dbo.Giants", "Forest_Id");
            CreateIndex("dbo.Knights", "Tower_Id");
            CreateIndex("dbo.Magus", "Tower_Id");
            CreateIndex("dbo.Spiders", "Cave_Id");
            CreateIndex("dbo.Witches", "Tower_Id");
            CreateIndex("dbo.Wolves", "Forest_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Wolves", new[] { "Forest_Id" });
            DropIndex("dbo.Witches", new[] { "Tower_Id" });
            DropIndex("dbo.Spiders", new[] { "Cave_Id" });
            DropIndex("dbo.Magus", new[] { "Tower_Id" });
            DropIndex("dbo.Knights", new[] { "Tower_Id" });
            DropIndex("dbo.Giants", new[] { "Forest_Id" });
            DropIndex("dbo.Ents", new[] { "Forest_Id" });
            DropIndex("dbo.Dragons", new[] { "Cave_Id" });
            DropIndex("dbo.Bats", new[] { "Cave_Id" });
            AlterColumn("dbo.Wolves", "Forest_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Witches", "Tower_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Spiders", "Cave_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Magus", "Tower_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Knights", "Tower_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Giants", "Forest_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Ents", "Forest_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Dragons", "Cave_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Bats", "Cave_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Wolves", "Forest_Id");
            CreateIndex("dbo.Witches", "Tower_Id");
            CreateIndex("dbo.Spiders", "Cave_Id");
            CreateIndex("dbo.Magus", "Tower_Id");
            CreateIndex("dbo.Knights", "Tower_Id");
            CreateIndex("dbo.Giants", "Forest_Id");
            CreateIndex("dbo.Ents", "Forest_Id");
            CreateIndex("dbo.Dragons", "Cave_Id");
            CreateIndex("dbo.Bats", "Cave_Id");
        }
    }
}
