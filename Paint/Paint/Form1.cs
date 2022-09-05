using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        List<IFigure> Figures = new List<IFigure>();
        List<IFigure> CompleteFigures = new List<IFigure>();
        IFigure Figure;
        IFactory FigureFactory;
        Color FigureColor = Color.Black;
        bool IsFill = false;
        bool IsMouseDown = false;

        public Form1()
        {
            InitializeComponent();
            CB_Figures.Items.AddRange(new string[]{"Line","Rectangle","Circle","Triangle"});
            CB_Figures.SelectedIndex = 0;
            pictureBox_ChosenColor.BackColor = FigureColor;
        }

        private void Btn_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FigureColor = colorDialog1.Color;
                pictureBox_ChosenColor.BackColor = FigureColor;
            }
        }

        private void CB_Figures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cb)
            {
                switch (cb.SelectedItem.ToString())
                {
                    case "Line":
                        RB_Line.Checked = true;
                        FigureFactory = new LineF();
                        break;
                    case "Rectangle":
                        RB_Rectangle.Checked = true;
                        FigureFactory = new RectangleF();
                        break;
                    case "Circle":
                        RB_Circle.Checked = true;
                        FigureFactory = new CircleF();
                        break;
                    case "Triangle":
                        FigureFactory = new TriangleF();
                        break;
                }
            }
        }

        private void RB_Figure_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked==true)
            {
                CB_Figures.SelectedItem = radioButton.Text;
            }
        }

        private void checkBox_Fill_CheckedChanged(object sender, EventArgs e)
        {
            IsFill = (sender as CheckBox).Checked;
        }

        private Rectangle GetRectangle(IFigure figure)
        {
            Rectangle r = new Rectangle();
            r.X = Math.Min(figure.Start_Point.X, figure.End_Point.X);
            r.Y = Math.Min(figure.Start_Point.Y, figure.End_Point.Y);
            if (figure.Start_Point.X > figure.End_Point.X)
                r.Width = figure.Start_Point.X - figure.End_Point.X;
            else
                r.Width = figure.End_Point.X - figure.Start_Point.X;
            if (figure.Start_Point.Y > figure.End_Point.Y)
                r.Height = figure.Start_Point.Y - figure.End_Point.Y;
            else
                r.Height = figure.End_Point.Y - figure.Start_Point.Y;
            return r;
        }

        private void Pnl_Paint_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(FigureColor, 3);
            SolidBrush brush = new SolidBrush(FigureColor);
            using (var g = e.Graphics)
            {
                foreach (var item in Figures)
                {
                    pen.Color = item.Color;
                    brush.Color = item.Color;
                    if (item is Line line)
                    {
                        g.DrawLine(pen, line.Start_Point, line.End_Point);
                    }
                    else if (item is Rectanglee rectangle)
                    {
                        if (!rectangle.IsFill)
                        {
                            g.DrawRectangle(pen, GetRectangle(rectangle));
                        }
                        else
                        {
                            g.FillRectangle(brush, GetRectangle(rectangle));
                        }
                    }
                    else if (item is Circle circle)
                    {
                        if (!circle.IsFill)
                        {
                            g.DrawEllipse(pen, GetRectangle(circle));
                        }
                        else
                        {
                            g.FillEllipse(brush, GetRectangle(circle));
                        }
                    }
                    else if (item is Triangle triangle)
                    {
                        Point point;
                        Rectangle r = GetRectangle(triangle);
                        if (triangle.Start_Point.X > triangle.End_Point.X && triangle.Start_Point.Y > triangle.End_Point.Y)
                        {
                            point = new Point(triangle.Start_Point.X + r.Width, triangle.End_Point.Y);
                        }
                        else if (triangle.Start_Point.X < triangle.End_Point.X && triangle.Start_Point.Y < triangle.End_Point.Y)
                        {
                            point = new Point(triangle.Start_Point.X - r.Width, triangle.End_Point.Y);
                        }
                        else if (triangle.Start_Point.X > triangle.End_Point.X && triangle.Start_Point.Y < triangle.End_Point.Y)
                        {
                            point = new Point(triangle.End_Point.X, triangle.Start_Point.Y - r.Height);
                        }
                        else
                        {
                            point = new Point(triangle.End_Point.X, triangle.Start_Point.Y + r.Height); ;
                        }
                        Point[] points = new Point[]
                            {
                                new Point(triangle.Start_Point.X, triangle.Start_Point.Y),
                                new Point(triangle.End_Point.X, triangle.End_Point.Y),
                                point
                            };
                        if (!triangle.IsFill)
                            g.DrawPolygon(pen, points);
                        else
                            g.FillPolygon(brush, points);
                    }
                }
            }
        }

        private void Pnl_Paint_MouseDown(object sender, MouseEventArgs e)
        {
            IFigure figure = FigureFactory.GetFigure();
            figure.Color = FigureColor;
            figure.IsFill = IsFill;
            figure.Start_Point = e.Location;
            Figure = figure;
            IsMouseDown = true;
        }

        private void Pnl_Paint_MouseUp(object sender, MouseEventArgs e)
        {
            Figure.Size = new Size(Figure.Start_Point.X - e.X, Figure.Start_Point.Y - e.Y);
            Figure.End_Point = e.Location;
            CompleteFigures.Add(Figure);
            Figures.Clear();
            Figures.AddRange(CompleteFigures);
            IsMouseDown = false;
            Pnl_Paint.Refresh();
        }

        private void Pnl_Paint_MouseMove(object sender, MouseEventArgs e)
        {
            Lbl_Coordinate.Text = $"X: {e.X} | Y: {e.Y}";
            if (IsMouseDown)
            {
                Figure.Size = new Size(Figure.Start_Point.X - e.X, Figure.Start_Point.Y - e.Y);
                Figure.End_Point = e.Location;
                Figures.Add(Figure);
                Pnl_Paint.Refresh();
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Figures.Clear();
            CompleteFigures.Clear();
            Pnl_Paint.Refresh();
        }

        private void Btn_MainColor_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
               FigureColor = button.BackColor;
            }
        }
    }
}