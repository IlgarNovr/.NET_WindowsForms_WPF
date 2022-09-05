namespace Paint
{
    class CircleF : IFactory
    {
        public IFigure GetFigure()
        {
            return new Circle();
        }
    }
}
