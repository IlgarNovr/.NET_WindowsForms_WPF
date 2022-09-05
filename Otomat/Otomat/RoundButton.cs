using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Otomat
{
    class RoundButton: Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(5, 5, ClientSize.Width-10, ClientSize.Height-10);
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pevent);
        }
    }
}
