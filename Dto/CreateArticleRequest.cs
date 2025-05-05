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
        public string Overview { get; set; }
        public List<string> ProcessSteps { get; set; } = new List<string>();
        public string FormName { get; set; }
        public List<string> Prerequisites { get; set; } = new List<string>();
        public ArticleLink ArticleLink { get; set; }
        public List<ImageDTO> Images { get; set; } = new List<ImageDTO>();
        public Author Author { get; set; }
        public AppLinks AppLinks { get; set; }
    }
}
