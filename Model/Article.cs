using optsupport.Model;

namespace KnowledgeBaseAPI.Models
{
    public class Article
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public InventoryData InventoryData { get; set; }
    }
}