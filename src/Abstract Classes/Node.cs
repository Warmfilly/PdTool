using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public abstract class Node : ICloneable
    {
        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        //public string Send { get; set; }
        //public string Receive { get; set; }


        public List<ConnSrc> Inlets { get; set; }
        public List<ConnSink> Outlets { get; set; }

        //public List<Connection> Connections { get; set; }

        public Node(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

            //Send = String.Empty;
            //Receive = String.Empty;

            Inlets = new();
            Outlets = new();
            //Connections = new();
        }

        //example new p_NodeInletPair(thisNode, 0); //represents the 0th (leftmost) inlet of a node called 'thisNode'
        public void ConnectTo(ConnSink nodeSink)
        {
            int outlet = Outlets.Count;
            Outlets.Add(nodeSink);
        }

        public void ConnectFrom(ConnSrc nodeSource)
        {
            Inlets.Add(nodeSource);
        }

        public abstract override string ToString();

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
