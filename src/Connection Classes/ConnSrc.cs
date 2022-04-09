using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public  class ConnSrc
    {
        public Node Node { get; set; }
        public int OutletNum { get; set; }

        public ConnSrc(Node Node, int OutletNum)
        {
            this.Node = Node;
            this.OutletNum = OutletNum;
        }

        public ConnSrc(Node Node)
        {
            this.Node = Node;
            this.OutletNum = 0;
        }
    }
}
