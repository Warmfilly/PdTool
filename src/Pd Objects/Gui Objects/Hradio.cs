using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Hradio : Radio
    {
        public Hradio(int X, int Y) : base(X, Y) { }

        //#X obj 140 131 hradio 15 1 0 8 empty empty empty 0 -8 0 10 -262144 -1 -1 0;
        public override string ToString()
        {
            return $"#X obj {X} {Y} hradio {Size} {NewOld} {(Init ? 1 : 0)} {Count} {Send} {Receive} {Label} {XOffset} {YOffset} {(int)Font} {FontSize} -262144 -1 -1 {DefaultValue};";
        }
    }
}
