namespace AngularJSForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
        }
    }
}
