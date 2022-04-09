using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Connection
    {
        public ConnSrc Source { get; set; }
        public ConnSink Sink { get; set; }

        //An object that represents a connection between two Pure Data nodes
        public Connection(ConnSrc Source, ConnSink Sink)
        {
            this.Source = Source;
            this.Sink = Sink;
        }

        public override string ToString()
        {
            string line = $"#X connect {Source.Node.ID} {Source.OutletNum} {Sink.Node.ID} {Sink.InletNum};";
            return line;
        }
    }
}
