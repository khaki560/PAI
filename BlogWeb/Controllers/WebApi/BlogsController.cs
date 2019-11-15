using BlogData;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogWeb.Controllers.WebApi
{
    public class BlogsController : ApiController
    {
        [Route("api/Blogs/GetAllBlogs")]
        public IEnumerable<Blog> GetAllBlogs()
        {
            using (var repository = new BlogRepository())
            {
                var a = repository.GetAll().ToList();
                return a;
            }
        }

        [Route("api/Blogs/GetBlog")]
        public IEnumerable<Blog> GetBlog(int i )
        {
            using (var repository = new BlogRepository())
            {
                var b = repository.GetAll().ToList();
                var a = new List<BlogModel.Blog> { b[i] };
                return a;
            }
        }

        [HttpPost]
        [Route("api/Blogs/AddBlog")]
        public IEnumerable<Blog> AddBlog(string name)
        {
            using (var repository = new BlogRepository())
            {
                var blog = new Blog();
                blog.Name = name;
                repository.Add(blog);
                return repository.GetAll().ToList();
            }
        }

        //public IEnumerable<Blog> DeleteBlog(int id)
        //{
        //    using (var repository = new BlogRepository())
        //    {
        //        return repository.GetAll().ToList();
        //    }
        //}
    }
}
