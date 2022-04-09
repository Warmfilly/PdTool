using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Obj : Node
    {
        public string Object { get; set; }

        public Obj(string Object, int X, int Y) : base(X, Y)
        {
            this.Object = Object;
        }

        public override string ToString()
        {
            return $"#X obj {X} {Y} {Object};";
        }
    }
}
