using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PdTool
{
    public class Patch : Node
    {
        public int Width            { get; set; }
        public int Height           { get; set; }
        public int XFloor           { get; set; }
        public int XCeil            { get; set; }
        public int YFloor           { get; set; }
        public int YCeil            { get; set; }
        public int XSize            { get; set; }
        public int YSize            { get; set; }
        public int XMargin          { get; set; }
        public int YMargin          { get; set; }
        public bool Hide            { get; set; }
        public bool GraphOnParent   { get; set; }
        public string Name          { get; set; }
        public Coords Coords        { get; set; }
         
        private List<Node>          _nodes;
        private List<Connection>    _connections;

        public List<Node> Nodes
        {
            get => _nodes;
        }
        public List<Connection> Connections
        {
            get => _connections;
        }


        /// <summary>
        /// Create the main patch
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        public Patch(int X, int Y, int Width, int Height) : base(X, Y)
        {
            Init(Width, Height, "_mainpatch_");
        }

        /// <summary>
        /// Create a subpatch
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="isMain"></param>
        public Patch(string Name, int X, int Y, int Width, int Height) : base(X, Y)
        {
            Init(Width, Height, Name);
        }

        private void Init(int Width, int Height, string Name)
        {
            this.Width  = Width;
            this.Height = Height;
            this.Name   = Name;

            _nodes          = new();
            _connections    = new();
        }

        public void Add(Node node)
        {
            if (node is Patch && ((Patch)node).Name == "_mainpatch_")
            {
                throw new ArgumentException("Cannot add a main patch to another main patch");
            }
                
            node.ID = _nodes.Count;
            _nodes.Add(node);
        }

        public void Save(string path)
        {
            //create folder if it doesn't exist
            var i = new FileInfo(path);

            var dir = i.Directory;
            if(dir != null)
            {
                dir.Create();
            }
            //Directory.CreateDirectory(dir);
            File.WriteAllText(path, this.ToString());
        }


        /// <summary>
        /// Make the connection provided
        /// </summary>
        /// <param name="c"></param>
        public void Connect(Connection c)
        {
            _connections.Add(c);
        }

        /// <summary>
        /// Connect the leftmost outlet of the source node to the leftmost inlet of the sink node
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Sink"></param>
        public void Connect(Node Source, Node Sink)
        {
            var c = new Connection(new ConnSrc(Source), new ConnSink(Sink));
            _connections.Add(c);
        }

        /// <summary>
        /// Connect the provided source to the provided sink
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Sink"></param>
        public void Connect(ConnSrc Source, ConnSink Sink)
        {
            var c = new Connection(Source, Sink);
            _connections.Add(c);
        }

        //graph on parent on:  #X coords 0 -1  1  1  85 60 1 100 100;
        //graph on parent off: #X coords 0 997 1 996 85 60 0;  
        public override string ToString()
        {
            var code = new StringBuilder();

            if (Name == "_mainpatch_")
            {
                code.AppendLine($"#N canvas {X} {Y} {Width} {Height} 12;");
            }
            else
            {
                code.AppendLine($"#N canvas 0 0 {Width} {Height} {Name} 0;");
            }

            foreach (var node in _nodes)
            {
                code.AppendLine(node.ToString());
            }

            foreach(var conn in _connections)
            {
                code.AppendLine(conn.ToString());
            }

            if (GraphOnParent)
            {
                code.AppendLine(Coords.ToString());
            }

            if (Name != "_mainpatch_") //if this patch is a subpatch
            {
                code.Append($"#X restore {X} {Y} pd {Name};");
            } 

            return code.ToString();
        }

        
    }
}
