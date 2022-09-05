using System.Drawing;

namespace Paint
{
    class Rectanglee : IFigure
    {
        public Point Start_Point { get; set; }
        public Point End_Point { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public bool IsFill { get; set; }
    }
}
