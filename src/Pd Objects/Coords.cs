using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdTool
{
    public struct Coords
    {
        public int XUnit { get; set; }
        public int YUnit { get; set; }
        public int XFloor { get; set; }
        public int XCeil { get; set; }
        public int YFloor { get; set; }
        public int YCeil { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool GraphOnParent { get; set; }
        public int XMargin { get; set; }
        public int YMargin { get; set; }

        /// <summary>
        /// Create a coords object with the default values
        /// </summary>
        public Coords()
        {
            XUnit = 1;
            YUnit = -1;
            this.XFloor = 0;
            this.XCeil = 1;
            this.YFloor = -1;
            this.YCeil = 1;
            this.Width = 85;
            this.Height = 60;
            this.GraphOnParent = true;
            this.XMargin = 100;
            this.YMargin = 100;
        }

        //graph on parent on:  #X coords 0 -1  1  1  85 60 1 100 100;
        //graph on parent off: #X coords 0 997 1 996 85 60 0;  
        //#X coords 0 -1 1 1 85 60 1 100 100;
        public override string ToString()
        {
            //string code = String.Empty;
            //if (GraphOnParent)
            //    code = $"#X coords {XFloor} {YFloor} {XCeil} {YCeil} {Width} {Height} {(GraphOnParent ? 1 : 0)} {XMargin} {YMargin};";
            //else
            //    code = $"#X coords {XFloor} {YFloor}";

            return $"#X coords {XFloor} {YFloor} {XCeil} {YCeil} {Width} {Height} {(GraphOnParent ? 1 : 0)} {XMargin} {YMargin};";
        }
    }
}
