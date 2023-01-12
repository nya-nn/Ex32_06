using AbstractSample;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Triangle:Surface
    {
        readonly public float side1;
        readonly public float side2;
        readonly public float side3;
        float surface;

        public Triangle(float side1, float side2, float side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override float GetSurface()
        {
            float s = (side1+side2+side3)/2;
            surface=(float)Math.Sqrt(s*(s-side1)*(s-side2)*(s-side3));
            return surface;
        }
        public override float GetCircumference()
        {
            return (side1+side2+side3);
        }
        public override void GetBounds(out float w, out float h)
        {
            w = side1;
            h = (2 / side1) * surface;
        }
    }
}
