namespace shuli_blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        gender = c.Int(nullable: false),
                        Bday = c.DateTime(nullable: false),
                        Seniority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);

            
            CreateTable(
            "dbo.Post",
            c => new
            {
                ID = c.Int(nullable: false, identity: true),
                Title = c.String(nullable: false),
                Author = c.String(nullable: false),
                URL = c.String(),
                PublishDate = c.DateTime(),
                Body = c.String(nullable: false),
                CommentsList = c.String(),
                Image = c.String(),
                Video = c.String(),
            }).PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Comment",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    PostID = c.Int(nullable: false),
                    CommentTitle = c.String(nullable: false),
                    CommentAuthor = c.String(nullable: false),
                    AuthorURL = c.String(nullable: false),
                    Body = c.String(nullable: false),
                }).PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Post", t => t.PostID, cascadeDelete: true);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fan");
            DropTable("dbo.Post");
            DropTable("dbo.Comment");
        }
    }
}
