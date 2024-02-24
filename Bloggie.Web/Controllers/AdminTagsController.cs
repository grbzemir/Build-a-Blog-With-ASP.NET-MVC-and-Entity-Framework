using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Bloggie.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{
    public class AdminTagsController : Controller
    {     
        
        //Dependency Injection
        private readonly BloggieDbContext bloggieDbContext;

        public AdminTagsController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        // GET
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // Post
        [HttpPost]
        [ActionName("Add")]

        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {

            //Mapping AddTagRequest to tag domain model!

            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };

            bloggieDbContext.Tags.Add(tag);
            bloggieDbContext.SaveChanges();

            return View("Add");


        }
    }
}
