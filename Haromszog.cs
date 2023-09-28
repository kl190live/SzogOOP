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
		

		public Haromszog(double a,double b, double c) :base(a)
		{
			this.B = b;
			this.C = c;
			if (!Szerkesztheto())
			{
				throw new ArgumentException("A háromszög nem szerkeszthető");
			}
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

		public override double A
		{ 
			set 
			{
				if (!Szerkesztheto())
				{
					base.A = value;
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}
		
		
		public double B
		{
			get => b;
			set
			{
				throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
			}
		
		}

		public double C
		{
			get => c;
			set
			{
				throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
			}

		}

		

		private bool Szerkesztheto()
		{ 
			return this.A + this.b > this.c 
				&& this.A + this.c > this.b 
				&& this.c + this.b > this.A;
		}

		public override double GetKerulet()
		{ 
			return this.A + this.b + this.c;
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
