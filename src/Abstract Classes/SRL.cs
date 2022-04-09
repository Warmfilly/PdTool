using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public abstract class SRL : Node
    {
        private string _send;
        private string _receive;
        private string _label;

        public SRL(int X, int Y) : base(X, Y)
        {
            _send       = "empty";
            _receive    = "empty";
            _label      = "empty";
        }

        public string Send
        {
            get =>  _send;
            set {   _send = SanitizeSRL(value); }
        }

        public string Receive
        {
            get =>  _receive;
            set {   _receive = SanitizeSRL(value); }
        }

        public string Label
        {
            get =>  _label;
            set {   _label = SanitizeSRL(value); }
        }

        //Used to ensure the Send, Receive, and Label properties of some PD objects have values that are considered valid by PD
        //spaces replaced by underscores, etc.
        private static string SanitizeSRL(string s)
        {
            s = s.Trim();
            return String.IsNullOrWhiteSpace(s) ? "empty" : s.Replace(' ', '_');
        }

    }
}
