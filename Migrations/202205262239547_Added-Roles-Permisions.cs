namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRolesPermisions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "AddCategory", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "EditCategory", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DeleteCategory", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "AddObject", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "EditObject", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DeleteObject", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "AddUser", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "EditUser", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DeleteUser", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Roles", "DeleteUser");
            DropColumn("dbo.Roles", "EditUser");
            DropColumn("dbo.Roles", "AddUser");
            DropColumn("dbo.Roles", "DeleteObject");
            DropColumn("dbo.Roles", "EditObject");
            DropColumn("dbo.Roles", "AddObject");
            DropColumn("dbo.Roles", "DeleteCategory");
            DropColumn("dbo.Roles", "EditCategory");
            DropColumn("dbo.Roles", "AddCategory");
        }
    }
}
