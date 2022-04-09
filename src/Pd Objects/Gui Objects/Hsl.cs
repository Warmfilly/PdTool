using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{

    public class Hsl : Slider
    {
        public Hsl(int X, int Y) : base(X, Y)
        {
            this.Width = 128;
            this.Height = 15;

            this.XOffset = -2;
            this.YOffset = -8;
        }

        //#X obj 199 182 hsl 128 15 0 127 0 0 empty empty empty -2 -8 0 10 -262144 -1 -1 0 1;
        public override string ToString()
        {
            return $"#X obj {X} {Y} hsl {Width} {Height} {Lower} {Upper} {Log} {(Init ? 1 : 0)} " +
                $"{Send} {Receive} {Label} {XOffset} {YOffset} {(int)Font} {FontSize} -262144 -1 -1 {DefaultValue} {(SteadyOnClick ? 1 : 0)};";
        }
    }
}
