using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public abstract class Atom : Node
    {
        public int Width { get; set; }
        public int LowerLimit { get; set; }
        public int UpperLimit { get; set; }
        public int LabelPos { get; set; } //0-4
        public string Label { get; set; }
        public string Receive { get; set; }
        public string Send { get; set; }

        public Atom(int X, int Y) : base(X, Y)
        {
            LowerLimit = 0;
            UpperLimit = 0;
            LabelPos = 0;
            Label = "-";
            Receive = "-";
            Send = "-";
        }
    }
}
