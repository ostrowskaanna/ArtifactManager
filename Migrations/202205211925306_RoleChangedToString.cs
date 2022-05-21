namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleChangedToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Role", c => c.String(nullable: false));
            DropColumn("dbo.Users", "UserRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserRole", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Role");
        }
    }
}
