namespace shuli_blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fan",
                c=> new{
                    ID = c.Int(nullable : false,identity : true),
                    FirstName = c.String(nullable : false),
                    LastName = c.String(nullable : false),
                    Bday = c.DateTime(),
                    Seniority = c.Int(),
                }).PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fan");
        }
    }
}
