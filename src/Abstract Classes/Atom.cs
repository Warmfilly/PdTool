using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public abstract class Atom : SRL
    {
        public int Width { get; set; }
        public int LowerLimit { get; set; }
        public int UpperLimit { get; set; }
        public int LabelPos { get; set; } //0-4

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
