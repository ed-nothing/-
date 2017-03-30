using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Library.Framework.Data
{
    public struct ResourceEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public ResourceType Type { get; set; }
        public string Description { get; set; }
    }
}
