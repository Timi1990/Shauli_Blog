namespace shuli_blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        addressName = c.String(),
                        lat = c.Double(nullable: false),
                        len = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FanClub",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClubName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Fan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        gender = c.Int(nullable: false),
                        Bday = c.DateTime(nullable: false),
                        Seniority = c.Int(nullable: false),
                        ClubID = c.Int(nullable: false),
                        Address_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Address", t => t.Address_ID)
                .ForeignKey("dbo.FanClub", t => t.ClubID, cascadeDelete: true)
                .Index(t => t.ClubID)
                .Index(t => t.Address_ID);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        CommentTitle = c.String(),
                        CommentAuthor = c.String(),
                        AuthorURL = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Post", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        URL = c.String(),
                        PublishDate = c.DateTime(nullable: false),
                        Body = c.String(nullable: false),
                        Video = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Address_ID = c.Int(),
                        Role_ID = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Address", t => t.Address_ID)
                .ForeignKey("dbo.Role", t => t.Role_ID)
                .Index(t => t.Address_ID)
                .Index(t => t.Role_ID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfile", "Role_ID", "dbo.Role");
            DropForeignKey("dbo.UserProfile", "Address_ID", "dbo.Address");
            DropForeignKey("dbo.Comment", "PostID", "dbo.Post");
            DropForeignKey("dbo.Fan", "ClubID", "dbo.FanClub");
            DropForeignKey("dbo.Fan", "Address_ID", "dbo.Address");
            DropIndex("dbo.UserProfile", new[] { "Role_ID" });
            DropIndex("dbo.UserProfile", new[] { "Address_ID" });
            DropIndex("dbo.Comment", new[] { "PostID" });
            DropIndex("dbo.Fan", new[] { "Address_ID" });
            DropIndex("dbo.Fan", new[] { "ClubID" });
            DropTable("dbo.Role");
            DropTable("dbo.UserProfile");
            DropTable("dbo.Post");
            DropTable("dbo.Comment");
            DropTable("dbo.Fan");
            DropTable("dbo.FanClub");
            DropTable("dbo.Address");
        }
    }
}
