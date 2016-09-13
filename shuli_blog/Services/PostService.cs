using shuli_blog.DAL;
using shuli_blog.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace shuli_blog.Services
{
    public class PostService : IService<Post>
    {

        private ICrud<Post> postCrud = new PostCrud();

        public Post index(int id)
        {
            return postCrud.index(id);
        }

        public List<Post> list()
        {
            return postCrud.list();

        }

        public Post create(string title , string author , string url , DateTime publishDate , string body , string video,
            string image , List<Comment> comments)
        {
            Post post = createPost(title, author, url, publishDate, body, video, image, comments);
            return postCrud.create(post);
        }
        public void details(Post Post)
        {
            postCrud.details(Post);
        }

        public bool delete(Post Post)
        {
            return postCrud.delete(Post);
        }

        private Post createPost(string title, string author, string url, DateTime publishDate, string body, string video,
            string image, List<Comment> comments)
        {
            Post post = new Post();
            post.Title = title;
            post.Author = author;
            post.URL = url;
            post.PublishDate = publishDate;
            post.Body = body;
            post.Video = video;
            post.Image = image;
            post.CommentsList = comments;
            return post;
        }

    }
}