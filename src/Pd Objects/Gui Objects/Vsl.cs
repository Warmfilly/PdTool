using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{

    public class Vsl : Slider
    {


        public Vsl(int X, int Y) : base(X, Y)
        {
            Width = 15;
            Height = 128;

            XOffset = 0;
            YOffset = -9;
        }

        //#X obj 113 101 vsl 15 128 0 127 0 0 empty empty empty 0 -9 0 10 -262144 -1 -1 0 1;
        public override string ToString()
        {
            return $"#X obj {X} {Y} vsl {Width} {Height} {Lower} {Upper} {Log} {(Init ? 1 : 0)} " +
                $"{Send} {Receive} {Label} {XOffset} {YOffset} {(int)Font} {FontSize} -262144 -1 -1 {DefaultValue} {(SteadyOnClick ? 1 : 0)};";
        }
    }
}
