namespace Paint
{
    class RectangleF : IFactory
    {
        public IFigure GetFigure()
        {
            return new Rectanglee();
        }
    }
}
