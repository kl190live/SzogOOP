using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzogOOP
{
	internal class Teglalap : Sokszog
	{
		private double b;

		public Teglalap(double a, double b) : base(a)
		{
			this.B = b;
		}

		public double B { get => b; set => b = value; }

		public double getKerulet()
		{
			return 2 * (this.A + this.b);
		}
		public double getTerulet()
		{
			return this.A * this.b;
		}



	}
}
