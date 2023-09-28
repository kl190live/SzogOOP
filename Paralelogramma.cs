using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzogOOP
{
	internal class Paralelogramma : Teglalap
	{
		private double alpha;
		private static Random random=new Random();

		public Paralelogramma(double a,double b,double alpha):base(a,b)
		{
			this.Alpha = alpha;
		}

		public Paralelogramma() : base(VeletlenoldalHossz(),VeletlenoldalHossz())
		{
			
		}

		public double Alpha { get => alpha; set => alpha = value; }

		public override double GetKerulet()
		{
			return 2*this.A +2*this.B;
		}

		public override double GetTerulet()
		{
			
			return base.GetTerulet()* Math.Sin(Radian(this.alpha));
		}

		public override string ToString()
		{
			return base.ToString();
		}

	}
}
