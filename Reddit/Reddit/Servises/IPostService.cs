using Reddit.Entities;
using System.Collections.Generic;

namespace Reddit.Servises
{
    public interface IPostService
    {
        IEnumerable<Post> GellAllPost();
        IEnumerable<Post> GetPostByUsername(string username);
        void CreatePost(Post post);
        Post GetPost(int id);
        void DeletePost(int id);
        void UpdatePost(Post post);

        public void Voting(int number, int id);
    }
}
