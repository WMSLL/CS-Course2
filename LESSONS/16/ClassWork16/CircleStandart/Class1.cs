using System;

namespace CircleStandart
{
    public class CircleClass
    {
        private double _radius;

        public CircleClass(double radius)
        {
            _radius = radius;
        }

        public double Calculate(Func<double, double> operation)
        {
            return operation(_radius);
        }
    }
}
