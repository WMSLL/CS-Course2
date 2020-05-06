using System;

namespace OperationFigure
{
    public class FigureOperation
    {
        private double _side;

        public FigureOperation(double side)
        {
            _side = side;
        }

        public double Calculate(Func<double, double> operation)
        {
            return operation(_side);
        }
    }
}
