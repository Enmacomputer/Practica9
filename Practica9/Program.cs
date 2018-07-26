using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("9: Pide un numero y dice si es par, hasta que el numero introducido sea cero.");
			Console.WriteLine();
			Console.WriteLine();

			Console.Write("Ingrese valor: ");
			int valor = int.Parse(Console.ReadLine());

			if (valor == 0)
			{
				Console.WriteLine("El valor introducido es cero (0), el programa finalizará.");
				Console.ReadKey();

			}
			else if (valor % 2 == 0)
			{
				Console.WriteLine("El numero {0} es Par.", valor);
				Console.ReadKey();

			}
			else
			{
				Console.WriteLine("El numero {0} es Impar.", valor);
				Console.ReadKey();
			}
				
			}
	}
}
