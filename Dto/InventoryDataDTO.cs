using System.Collections.Generic;
using KnowledgeBaseAPI.Models;
using optsupport.Model;

namespace KnowledgeBaseAPI.DTOs
{
    public class InventoryDataDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public List<string> ProcessSteps { get; set; }
        public string FormName { get; set; }
        public List<string> Prerequisites { get; set; }
        public ArticleLink ArticleLink { get; set; }
        public List<ImageDTO> Images { get; set; }
        public Author Author { get; set; }
        public AppLinks AppLinks { get; set; }
    }
}