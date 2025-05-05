using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace optsupport.Model
{
   
    public class InventoryImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Caption { get; set; }
        public int InventoryDataId { get; set; }
    }
}