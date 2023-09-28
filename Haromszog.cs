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
			while (!Szerkesztheto()) 
			{ 
				this.A = VeletlenoldalHossz();
				this.b = VeletlenoldalHossz();
				this.c = VeletlenoldalHossz();
			}
		}

		private static int VeletlenoldalHossz()
		{
			return rnd.Next(5, 15);
		}

		public double B { get => b; set => b = value; }
		public double C { get => c; set => c = value; }

		private bool Szerkesztheto()
		{ 
			return this.A + this.B > this.C 
				&& this.A + this.C > this.b 
				&& this.c + this.B > this.A;
		}

		public override double GetKerulet()
		{ 
			return this.A + this.B + this.c;
		}

		public override double GetTerulet()
		{
			double s= this.GetKerulet() / 2;
			return Math.Sqrt(s*(s-this.A)* (s - this.b) * (s - this.c));
		}

		public override string ToString()
		{
			return $"a: {this.A} - b: {this.b} -  c: {this.c} - {base.ToString()}";
		}

	}
}
