using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Symbol : Atom
    {
        public Symbol(int X, int Y) : base(X, Y)
        {
            Width = 10;
        }

        //#X symbolatom 105 112 10 0 0 0 - - -;
        public override string ToString()
        {
            return $"#X symbolatom {X} {Y} {Width} {LowerLimit} {UpperLimit} {LabelPos} {Label} {Receive} {Send};";
        }
    }
}
