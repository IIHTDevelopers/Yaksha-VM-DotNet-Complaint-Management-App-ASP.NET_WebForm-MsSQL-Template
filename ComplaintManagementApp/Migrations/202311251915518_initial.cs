namespace ComplaintManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComplaintModels",
                c => new
                    {
                        ComplaintId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        IsResolved = c.Boolean(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ComplaintId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ComplaintModels");
        }
    }
}
