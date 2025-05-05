using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace optsupport.Model
{
     public class Prerequisite
    {
        public int Id { get; set; }
        public string Requirement { get; set; }
        public int InventoryDataId { get; set; }
    }
}