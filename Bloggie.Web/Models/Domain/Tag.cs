namespace Bloggie.Web.Models.Domain
{
    public class Tag
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }
    
        public ICollection<BlogPost> BlogPosts { get; set; }

        //ICollection bir interface'dir. Bu interface birçok koleksiyon türünü destekler.
    }
}
