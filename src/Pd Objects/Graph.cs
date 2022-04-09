using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Graph : Node
    {
        public Coords Coords { get; set; }
        public Graph(int X, int Y) : base(X, Y)
        {
            Coords = new();
        }

        public override string ToString()
        {
            var code = new StringBuilder();

            code.AppendLine($"#N canvas 0 50 450 250 (subpatch) 0;");
            code.AppendLine(Coords.ToString());
            code.AppendLine($"#X restore {X} {Y} graph;");

            return code.ToString();
        }

    }
}
