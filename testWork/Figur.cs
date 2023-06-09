using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWork

{


   public abstract class Figur
    {
       public string nameFigur{ get; set; }

        public Figur(string nameFigur)
        {
            this.nameFigur = nameFigur;
        }

        public abstract double sqareFigure();
    }


    public class Circle : Figur
    {
        public double radius { get;  set; }

        public Circle(string nameFigur, double radius) : base(nameFigur)
        {
            this.radius = radius;
        }

        public override double sqareFigure()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 1);
        }
    }

    public class Triangle :Figur
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
       public Triangle( string nameFigur,double A,double B,double C):base(nameFigur)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public override double sqareFigure()
        {
            double p = (A + B + C) / 2;
            return p;

        }
    
        }


    }




