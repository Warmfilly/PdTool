using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Comment : Node
    {
        public string Text { get; set; }
        public Comment(int X, int Y, string Text) : base(X, Y)
        {
            this.Text = Text;
        }

        public override string ToString()
        {
            return $"#X text {X} {Y} {Text};";
        }
    }
}
