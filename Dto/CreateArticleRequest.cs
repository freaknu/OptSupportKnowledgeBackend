using KnowledgeBaseAPI.Models;
using optsupport.Dto;
using optsupport.Model;

namespace KnowledgeBaseAPI.DTOs
{
    public class CreateArticleRequest
    {
        public string CategoryId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleUrl { get; set; }
        public string InventoryTitle { get; set; }
        public string Content { get; set; }
        public ArticleLink ArticleLink { get; set; }
        public List<ImageDTO> Images { get; set; } = new List<ImageDTO>();
        public Author Author { get; set; }
        public AppLinks AppLinks { get; set; }
    }
}
