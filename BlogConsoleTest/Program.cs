using BlogData;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var repository = new BlogRepository())
            {
                Console.Write("Enter a name for new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                repository.Add(blog);

                var list = repository.GetAll();

                Console.WriteLine("All Blogs in the database:");
                foreach (var item in list)
                {
                    Console.WriteLine($" * {item.Name}");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
