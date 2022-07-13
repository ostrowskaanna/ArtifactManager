namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleTableModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "AddRole", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "EditRole", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "DeleteRole", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Roles", "DeleteRole");
            DropColumn("dbo.Roles", "EditRole");
            DropColumn("dbo.Roles", "AddRole");
        }
    }
}
