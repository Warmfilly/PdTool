using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class ConnSink
    {
        public Node Node { get; set; } //should this be an s_node instead???
        public int InletNum { get; set; }

        public ConnSink(Node Node, int InletNum)
        {
            this.Node = Node;
            this.InletNum = InletNum;
        }

        public ConnSink(Node Node)
        {
            this.Node = Node;
            this.InletNum = 0;
        }
    }
}
