using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Number : Atom
    {

        public Number(int X, int Y) : base(X, Y)
        {
            Width = 5;
        }

        //#X floatatom 83 84 5 0 0 0 - - -;
        public override string ToString()
        {
            return $"#X floatatom {X} {Y} {Width} {LowerLimit} {UpperLimit} {LabelPos} {Label} {Receive} {Send};";
        }
    }
}
