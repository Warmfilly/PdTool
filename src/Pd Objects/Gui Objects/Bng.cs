using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PdTool
{
    public class Bng : SRL
    {
        public int Size         { get; set; }
        public int Hold         { get; set; }
        public int Interrupt    { get; set; }
        public bool Init        { get; set; }
        public int XOffset      { get; set; }
        public int YOffset      { get; set; }
        public PdFont Font         { get; set; }
        public int FontSize     { get; set; }

        public Bng(int X, int Y) : base(X, Y)
        {
            Size = 15;
            Interrupt = 50;
            Hold = 250;
            XOffset = 17;
            YOffset = 7;
            Font = 0;
            FontSize = 10;

        }

        public override string ToString()
        {
            return $"#X obj {X} {Y} bng {Size} {Hold} {Interrupt} {(Init ? 1 : 0)} {Send} {Receive} {Label} {XOffset} {YOffset} {(int)Font} {FontSize} -262144 -1 -1;";
        }

        public static Bng FromLine(string line)
        {
            var a = line.Split(' ');
            if (a[0] != "#X" || a[1] != "obj" || a[4] != "bng")
                throw new ArgumentException($"The line '{line}' does not result in a valid bng");

            var b = new Bng(int.Parse(a[2]), int.Parse(a[3]))
            {
                Size        = int.Parse(a[5]),
                Hold        = int.Parse(a[6]),
                Interrupt   = int.Parse(a[7]),
                Init        = int.Parse(a[8]) == 1 ? true : false,
                Send        = a[9],
                Receive     = a[10],
                Label       = a[11],
                XOffset     = int.Parse(a[12]),
                YOffset     = int.Parse(a[13]),
                Font        = (PdFont)(int.Parse(a[14])),
                FontSize    = int.Parse(a[15]),
            };

            return b;
        }
    }
}
