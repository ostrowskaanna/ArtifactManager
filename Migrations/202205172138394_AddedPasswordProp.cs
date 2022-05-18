namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPasswordProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "password");
        }
    }
}
