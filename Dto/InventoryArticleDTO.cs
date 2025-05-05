using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeBaseAPI.DTOs;
using optsupport.Model;

namespace optsupport.Dto
{
    public class InventoryArticleDTO
    {
        public string CategoryId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleUrl { get; set; }
        public string InventoryTitle { get; set; }
        public string Overview { get; set; }
        public List<string> ProcessSteps { get; set; }
        public string FormName { get; set; }
        public List<string> Prerequisites { get; set; }
        public ArticleLinkDTO ArticleLink { get; set; }
        public List<ImageDTO> Images { get; set; }
        public Author Author { get; set; }
        public AppLinksDTO AppLinks { get; set; }
    }
}