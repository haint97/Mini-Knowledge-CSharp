using System;

namespace Event
{
    public class Circle
    {
        public event EventHandler ChangePerimeterEvent;

        public string P { get; set; } = "first value";

        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                if (ChangePerimeterEvent != null)
                {
                    ChangePerimeterEvent.Invoke(this, null);
                }
            }
        }
    }
}