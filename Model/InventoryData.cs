// InventoryData.cs
using optsupport.Model;

namespace KnowledgeBaseAPI.Models
{
    public class InventoryData
    {
        public int Id { get; set; }
        public string ArticleId { get; set; }
        public Article Article { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ArticleLink ArticleLink { get; set; }
        public List<InventoryImage> Images { get; set; }
        public Author Author { get; set; }
        public AppLinks AppLinks { get; set; }
    }
}