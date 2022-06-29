using System;

namespace T01ClassBoxData
{
    class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return this.length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                   throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double LateralSurfaceArea()
        {
            return 2 * Length * Height + 2 * Width * Height;
        }
        public double SurfaceArea()
        {
            return 2 * Length * Height + 2 * Width * Height + 2 * length * Width;
        }
        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
