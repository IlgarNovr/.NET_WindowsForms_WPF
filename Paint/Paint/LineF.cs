namespace Paint
{
    class LineF : IFactory
    {
        public IFigure GetFigure()
        {
            return new Line();
        }
    }
}
