using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool

{
    public class Vu : Node
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Receive { get; set; }
        public string Label { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public PdFont Font { get; set; }
        public int Fontsize { get; set; }
        public bool Scale { get; set; }
        public Vu(int X, int Y) : base(X, Y)
        {
            Width = 15;
            Height = 120;
            Receive = "empty";
            Label = "empty";
            XOffset = -1;
            YOffset = -8;
            Font = PdFont.DejaVu;
            Fontsize = 10;
            Scale = true;
            Receive = "empty";
            Label = "empty";
        }

        //#X obj 182 281 vu 15 120 empty empty -1 -8 0 10 -66577 -1 1 0;
        public override string ToString()
        {
            return $"#X obj {X} {Y} vu {Width} {Height} {Receive} {Label} {XOffset} {YOffset} {(int)Font} {Fontsize} -66577 -1 {(Scale ? 1 : 0)} 0;";
        }
    }
}
