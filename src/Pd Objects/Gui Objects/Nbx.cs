using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Nbx : SRL
    {
        public int Size { get; set; }
        public int Height { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }
        public int Log { get; set; } //0 for linear, 1 for logarithmic
        public bool Init { get; set; } //
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public PdFont Font { get; set; }
        public int FontSize { get; set; }
        public int LogHeight { get; set; } //1 to 1000, default is 256
        public Nbx(int X, int Y) : base(X, Y)
        {
            Size = 5;
            Height = 14;
            Min = -1e37F;
            Max = 1e37F;
            Log = 0;
            Init = false;
            XOffset = 0;
            YOffset = -8;
            LogHeight = 256;
        }

        //#X obj 117 141 nbx 5 14 -1e+037 1e+037 0 0 empty empty empty 0 -8 0 10 -262144 -1 -1 0 256;
        public override string ToString()
        {
            return $"#X obj {X} {Y} nbx {Size} {Height} {Min} {Max} {Log} {(Init ? 1 : 0)} {Send} {Receive} {Label} {XOffset} {YOffset} {(int)Font} {FontSize} -262144 -1 -1 0 {LogHeight};";
        }
    }
}
