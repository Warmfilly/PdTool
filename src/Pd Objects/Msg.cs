using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public class Msg : Node
    {
        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value < 1 ? 1 : value; }
        }
        public string Message { get; set; }

        public Msg(int X, int Y, string Message) : base(X, Y)
        {
            this.Length = 3;
            this.Message = Message;
        }

        //#X msg 110 77 2, f 1;
        public override string ToString()
        {
            string l = Length != 3 ? $", f {Length}" : string.Empty;

            return $"#X msg {X} {Y} {Message}{l};";
        }
    }
}
