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

		public Paralelogramma(double a,double b,double alpha):base(a,b)
		{
			if (alpha >= 180)
			{
				throw new ArgumentException("Az oldalak közbezárt szőg nem lehet 180-nál nagyobb", nameof(alpha));
			}
			this.Alpha = alpha;
		}

		public Paralelogramma() : base(VeletlenoldalHossz(),VeletlenoldalHossz())
		{
			this.alpha = VeletelenSzog();
        }

		public double Alpha
		{
			get => alpha;
			set {
				throw new ArgumentException("Az oldalak közbezárt szőg nem lehet 180-nál nagyobb", nameof(value));
			}
		}

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
