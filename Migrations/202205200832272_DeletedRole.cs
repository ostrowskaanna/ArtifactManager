namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedRole : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Role", c => c.String(nullable: false));
        }
    }
}
