using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Tgl : SRL
    {
        public int      Size            { get; set; }
        public int      InitValue       { get; set; } // What is this?
        public int      DefaultValue    { get; set; } // The value that the toggle sends out when it is toggled on
        public bool     Init            { get; set; } // If true, the toggle will bang upon initializing
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public PdFont Font { get; set; }
        public int FontSize { get; set; }

        public Tgl(int X, int Y) : base(X, Y)
        {
            Size            = 15;
            XOffset         = 17;
            YOffset         = 7;
            Font = PdFont.DejaVu;
            FontSize = 10;
            InitValue       = 0;
            DefaultValue    = 1;
            Init            = false;
        }

        public override string ToString()
        {
            //                                                                                                                  bg-color fg-color label-color
            // #X obj 154 103 tgl   15          1          empty  empty      empty     17        7       0        10     -262144 -1 -1 0 6;
            return $"#X obj {X} {Y} tgl {Size} {(Init ? 1 : 0)} {Send} {Receive} {Label} {XOffset} {YOffset} {(int)Font} {FontSize} -262144 -1 -1 {InitValue} {DefaultValue};";
        }
    }
}
