using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
        double SideA;
        double SideB;
        double SideC;
        double s;

        public Triangle()
        {
            this.Name = "triangle";
            this.NumSides = 3;
            this.SideA = 8;
            this.SideB = 5;
            this.SideC = 3;
            this.s = (this.SideA + this.SideB + this.SideC) / 2;
            this.Area = Math.Sqrt(this.s * ( this.s - this.a) * (this.s - this.b) * (this.s - this.c));
        }
    }
}
