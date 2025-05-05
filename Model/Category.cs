namespace KnowledgeBaseAPI.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}