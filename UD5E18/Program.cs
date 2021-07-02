using System;

namespace UD5E18
{
    class Program
    {
        static void Main(string[] args)
        {
			
			string texto = "Introduce un tamaño";
			int[] num = new int[Convert.ToInt32(texto)];

			
			rellenarNumAleatorioArray(num, 0, 9);

			mostrarArray(num);
		}

		public static void rellenarNumAleatorioArray(int[] array, int a, int b)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Random aleatorio = new Random();
				array[i] = (aleatorio.Next() * (a - b) + b);
			}
		}

		public static void mostrarArray(int[] array)
		{
			int suma = 0;
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("En el indice " + i + " esta el valor " + array[i]);
			}
			foreach (int i in array)
			{
				
				suma = +i;

				Console.WriteLine("La suma es" + suma);
			}

		}
	}
}
