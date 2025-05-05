using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeBaseAPI.Models;

namespace optsupport.Model
{
    public class CategoryViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<ArticleViewModel> Articles { get; set; }
    }
}