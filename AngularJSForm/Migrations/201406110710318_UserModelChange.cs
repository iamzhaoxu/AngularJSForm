namespace AngularJSForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "Type", c => c.String(nullable: false));
            DropColumn("dbo.UserModels", "UserType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserModels", "UserType", c => c.String(nullable: false));
            DropColumn("dbo.UserModels", "Type");
        }
    }
}
