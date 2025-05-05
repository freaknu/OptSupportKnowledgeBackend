using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace optsupport.Model
{
    public class CategorySummaryViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int ArticleCount { get; set; }
    }
}