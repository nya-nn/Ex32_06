using System;
using AbstractSample;
using ConsoleApp1;

namespace Ex32

{
    class Program
    {
        static void Main(string[] args)
        {
            float w;
            float h;
            //Surface testSurface = new Surface();  エラーになる
            Rectangle rectAngle1 = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 7);
            Circle circle = new Circle(3);
            Triangle triangle = new Triangle(3, 4, 5);
            Surface[] surfaces = {rectAngle1,rightTriangle,circle,triangle };
            for(var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"surfacesの面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"surfacesの周囲長は{surfaces[i].GetCircumference()}");
                surfaces[i].GetBounds(out w,out h);
                Console.WriteLine($"surfacesは幅{w}、高さ{h}の箱に入る");
            }
        }
    
    }
}
