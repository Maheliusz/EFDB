using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace Application1
{
    class Program
    {
        private BloggingContext db;

        private static void printWithMethodSyntax(BloggingContext db)
        {
            Console.WriteLine("Blog names and post titles, query syntax:");
            var query = db.Blogs.Join(
                db.Posts,
                blog => blog.BlogID,
                post => post.BlogID,
                (blog, post) => new
                {
                    BlogName = blog.Name,
                    Title = post.Title
                }
                );
            foreach (var result in query)
            {
                Console.WriteLine(result.BlogName + "; " + result.Title);
            }
        }

        private static void printWithQuerySyntax(BloggingContext db)
        {
            Console.WriteLine("Blog names and post titles, query syntax:");
            var query = from post in db.Posts
                        join blog in db.Blogs
                        on post.BlogID equals blog.BlogID
                        select new
                        {
                            BlogName = blog.Name,
                            Title = post.Title
                        };
            foreach (var result in query)
            {
                Console.WriteLine(result.BlogName + "; " + result.Title);
            }
        }

        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog 
                //Console.Write("Enter a name for a new Blog: ");
                //var name = Console.ReadLine();

                //var blog = new Blog { Name = name };
                //db.Blogs.Add(blog);
                //db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.BlogID);
                }
                BlogForm bForm = new BlogForm();
                printWithQuerySyntax(db);
                printWithMethodSyntax(db);
                bForm.ShowDialog();
                Console.WriteLine("Press any key to exit...");

                Console.ReadKey();
            }
        }


    }
}