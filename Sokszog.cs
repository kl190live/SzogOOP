using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzogOOP
{
	internal abstract class Sokszog
	{
		private double a;

		public Sokszog(double a)
		{
			this.A = a;
		}

		public virtual double A { get => a; set => a = value; }

		public abstract double GetKerulet();

		public abstract double GetTerulet();

		protected static int VeletlenoldalHossz()
		{
			Random rnd = new Random();
			return rnd.Next(5, 15);
		}

		public static double Radian(double fok)
		{
			return fok * Math.PI / 180;	
		}

		public override string ToString()
		{
			return $"K: {this.GetKerulet()} - T: {this.GetTerulet()}";
		}
	}
}
