using System.Collections.Generic;
using optsupport.Dto;

namespace KnowledgeBaseAPI.DTOs
{
    public class CategoryDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<ArticleDTO> Articles { get; set; }
    }
}