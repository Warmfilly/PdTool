using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Cnv : Node
    {
        public int Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public PdFont Font { get; set; }
        public int FontSize { get; set; }
        public string Send { get; set; }
        public string Receive { get; set; }
        public string Label { get; set; }

        public Cnv(int X, int Y) : base(X, Y)
        {
            Size = 15;
            Width = 100;
            Height = 60;
            XOffset = 20;
            YOffset = 12;
            Send = "empty";
            Receive = "empty";
            Label = "empty";
        }

        //#X obj 254 202 cnv 15 100 60 empty empty empty 20 12 0 14 -233017 -66577 0;
        public override string ToString()
        {
            return $"#X obj {X} {Y} cnv {Size} {Width} {Height} {Send} {Receive} {Label} {XOffset} {YOffset} {(int)Font} {FontSize} -233017 -66577 0;";
        }
    }
}
