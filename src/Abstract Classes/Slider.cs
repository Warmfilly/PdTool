using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public abstract class Slider : Node
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public float Lower { get; set; }
        public float Upper { get; set; }
        public int Log { get; set; } //0 if linear, 1 if logarithmic
        public bool Init { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public PdFont Font { get; set; } //0, 1, or 2
        public int FontSize { get; set; }
        public int DefaultValue { get; set; } //what is this?. The range is dependant on the Height
        public bool SteadyOnClick { get; set; }
        public string Send { get; set; }
        public string Receive { get; set; }
        public string Label { get; set; }

        public Slider(int X, int Y) : base(X, Y)
        {
            Lower = 0;
            Upper = 127;
            Log = 0;
            Init = false;
            Font = PdFont.DejaVu;
            FontSize = 10;
            DefaultValue = 0;
            SteadyOnClick = true;
            Send = "empty";
            Receive = "empty";
            Label = "empty";
        }
    }
}
