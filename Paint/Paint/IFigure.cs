using System.Drawing;

namespace Paint
{
    public interface IFigure
    {
        Point Start_Point { get; set; }
        Point End_Point { get; set; }
        Size Size { get; set; }
        Color Color { get; set; }
        bool IsFill { get; set; }
    }
}
