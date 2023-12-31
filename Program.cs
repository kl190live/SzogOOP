﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzogOOP;

namespace SokszogOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Haromszog haromszog = new Haromszog();
			Haromszog haromszog2 = new Haromszog(3, 4, 5);
			Teglalap teglalap = new Teglalap(4, 5);
			Teglalap teglalap2 = new Teglalap(2, 4);
			Paralelogramma paralelogramma = new Paralelogramma();
			Console.WriteLine(haromszog);
			Console.WriteLine(haromszog2);
			Console.WriteLine(teglalap);
			Console.WriteLine(teglalap2);
			Console.WriteLine(paralelogramma);
			Console.WriteLine(haromszog2.A);

			try
			{
				haromszog2.A = 10;
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine(haromszog2.A);


		}
	}
}
