using System;

namespace CircleOperation
{
    public class OperationsCircle
    {
        private double _radius;

        public OperationsCircle(double radius)
        {
            _radius = radius;
        }

        public double Calculate(Func<double, double> operation)
        {
            return operation(_radius);
        }
    }
}
