using AbstractSample;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    class Circle:Surface
    {
        readonly public float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float GetSurface()
        {
            return radius * radius * (float)Math.PI;
        }
        public override float GetCircumference()
        {
            return radius*2*(float)Math.PI;
        }
        public override void GetBounds(out float w, out float h)
        {
            w = radius * 2;
            h = radius * 2;
        }
    }
}
