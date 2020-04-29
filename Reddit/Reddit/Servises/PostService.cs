using Microsoft.EntityFrameworkCore;
using Reddit.DBServis;
using Reddit.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Reddit.Servises
{
    public class PostService : IPostService
    {
        private readonly RedditDbContext db;

        public PostService(RedditDbContext db)
        {
            this.db = db;
        }
        public void CreatePost(Post post)
        {
            db.Add(post);
            db.SaveChanges();
        }

        public void DeletePost(int id)
        {
            var post = GetPost(id);
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public IEnumerable<Post> GellAllPost()
        {
            return db.Posts.Include(p => p.Opinions);
        }

        public Post GetPost(int id)
        {
            return db.Posts.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Post> GetPostByUsername(string username)
        {
            return db.Posts.Where(u => u.UserReddit.UserName == username);

        }

        public void UpdatePost(Post post)
        {
            db.Entry(post).State = EntityState.Added;
            db.SaveChanges();
        }
    }
}
