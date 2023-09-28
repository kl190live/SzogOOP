using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzogOOP
{
	internal class Haromszog : Sokszog
	{
		private double b;
		private double c;
		private static Random rnd= new Random();

		public Haromszog(double a,double b, double c) :base(a)
		{
			this.B = b;
			this.C = c;
		}

		public Haromszog() : base(VeletlenoldalHossz())
		{
			this.b = VeletlenoldalHossz();
			this.c = VeletlenoldalHossz();
		}

		private static int VeletlenoldalHossz()
		{
			return rnd.Next(5, 15);
		}

		public double B { get => b; set => b = value; }
		public double C { get => c; set => c = value; }


		public double getHaromszogKerulet()
		{ 
			return this.A + this.B + this.c;
		}

		public double getHaromszogTerulet()
		{
			double s= this.getHaromszogKerulet() / 2;
			return Math.Sqrt(s*(s-this.A)* (s - this.b) * (s - this.c));
		}

	}
}
