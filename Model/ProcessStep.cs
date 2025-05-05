using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace optsupport.Model
{
    public class ProcessStep
    {
        public int Id { get; set; }
        public string Step { get; set; }
        public int InventoryDataId { get; set; }
    }
}