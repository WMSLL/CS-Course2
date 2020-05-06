using System;

namespace CalculatorOperation
{
    public class ClassOperation
    {
        private double _radius;

        public ClassOperation(double radius)
        {
            _radius = radius;
        }

        public double Calculate(Func<double, double> operation)
        {
            return operation(_radius);
        }
    }
}
