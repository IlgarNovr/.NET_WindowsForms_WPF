namespace Paint
{
    class TriangleF : IFactory
    {
        public IFigure GetFigure()
        {
            return new Triangle();
        }
    }
}
