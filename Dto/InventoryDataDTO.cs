// InventoryDataDTO.cs
using System.Collections.Generic;
using KnowledgeBaseAPI.Models;
using optsupport.Dto;

namespace KnowledgeBaseAPI.DTOs
{
    public class InventoryDataDTO
    {
        public int Id { get; set; }
        public string ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ArticleLinkDTO ArticleLink { get; set; }
        public List<ImageDTO> Images { get; set; }
        public AuthorDTO Author { get; set; }
        public AppLinksDTO AppLinks { get; set; }
    }
}