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

            /*var posts = new List<Post>
                         {
                             new Post{Title = "first", Author = "timi" , Body = "Bla bla", PublishDate = DateTime.Parse("1990-01-01") , URL = "www.walla.co.il"},
                             new Post{Title = "second", Author = "alex" , Body = "Bla bla", PublishDate = DateTime.Parse("1990-01-03") , URL = "www.walla.co.il"},
                             new Post{Title = "third", Author = "yossi" ,  Body = "Bla bla", PublishDate = DateTime.Parse("1990-01-02") , URL = "www.walla.co.il"},
                         };*/
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
        }
    }
}
