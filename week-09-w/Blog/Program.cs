using System;
using System.Collections.Generic;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new BlogPost();
            var post2 = new BlogPost();
            var post3 = new BlogPost();

            post1.AuthorName = "John Doe";
            post1.Title = "Lorem Ipsum";
            post1.Text = "Lorem ipsum dolor sit amet.";
            post1.publicationDate = "2000.05.04";

            post2.AuthorName = "Tim Urban posted";
            post2.Title = "Wait but why";
            post2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            post2.publicationDate = "2010.10.10";

            post3.AuthorName = "William Turton";
            post3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            post3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            post3.publicationDate = "2017.03.28";

            post1.Post();

            //add BlogPosts to the list
            var listOfPosts = new Blog();
            listOfPosts.Add(post1);
            listOfPosts.Add(post2);
            listOfPosts.Add(post3);

            //Delete(int) one item at given index
            listOfPosts.RemoveAt(1);

            //Update(int, BlogPost) one item at the given index and update it with another BlogPost
            var post4 = new BlogPost();
            listOfPosts.update(post4);



            Console.ReadLine();
        }
    }
    class BlogPost
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string publicationDate { get; set; }

        public void Post()
        {
            Console.WriteLine("{0} by {1} at {2}.", Title, AuthorName, publicationDate);
            Console.WriteLine("{0}", Text);
        }
    }
    class Blog
    {
        //store a list of BlogPosts
        private List<BlogPost> listOfBlogPost;

        public Blog()
        {
            listOfBlogPost = new List<BlogPost>();
        }
        public void Add(BlogPost post)
        {
            listOfBlogPost.Add(post);
        }
        public void RemoveAt(int index)
        {
            if (index > listOfBlogPost.Count || index < 0)
            {
                Console.WriteLine("This is invalid index");
            }
            else
            {
                listOfBlogPost.RemoveAt(index);
            }

        }
        public void update(BlogPost post)
        {
            listOfBlogPost.Insert(0, post);
        }

        public void printOut()
        {
            foreach (var item in listOfBlogPost)
            {
                Console.WriteLine(item.Title);
            }
        }

    }
}
