using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public abstract class Radio : SRL
    {
        public int Size { get; set; }
        public int NewOld { get; set; } //unknown effect
        public bool Init { get; set; }
        public int Count { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public PdFont Font { get; set; }
        public int FontSize { get; set; }
        public int DefaultValue { get; set; } //If Init is true, bang this Default Value upon initializing

        public Radio(int X, int Y) : base(X, Y)
        {
            Size = 15;
            NewOld = 1;
            Init = false;
            Count = 8;
            XOffset = 0;
            YOffset = -8;
            DefaultValue = 0;
            Font = PdFont.DejaVu;
            FontSize = 10;
        }

        
    }
}
