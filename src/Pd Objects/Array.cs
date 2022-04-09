using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Array : Node
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public float[] Data { get; set; }
        public Coords Coords { get; set; }

        public Array(int X, int Y, string Name) : base(X, Y)
        {
            this.Name = Name;
            Data = System.Array.Empty<float>();
            Coords = new();
        }

        public void SetData(float[] data)
        {
            this.Data = data;
            Size = Data.Length;

            var temp = Coords;
            temp.XCeil = Size;
            Coords = temp;
        }

        public override string ToString()
        {
            StringBuilder code = new StringBuilder();
            code.AppendLine($"#N canvas {X} {Y} {Width} {Height} (subpatch) 0;");
            code.AppendLine($"#X array {Name} {Size} float 3;");
            code.AppendLine($"#A 0 {ArrayString()};");
            code.AppendLine(Coords.ToString());
            code.Append($"#X restore {X} {Y} graph;");

            return code.ToString();
        }

        private string ArrayString()
        {
            var sb = new StringBuilder();
            foreach(float i in Data)
            {
                sb.Append($"{i} ");
            }
            string s = sb.ToString().Trim();

            return s;
        }
    }
}
