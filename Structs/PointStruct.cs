using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct PointStruct
    {
        public int x { get; set; }
        public int y { get; set; }
        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }
    }
}