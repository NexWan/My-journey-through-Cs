using System;

namespace Ejercicios {
	public class Ejercicio6 {
		public static void Main(){
			Console.WriteLine("Escribe el numero para sacar multiplos");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Escribe los multiplos a buscar");
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= n; i++){
				Console.Write(i*x + ", ");
			}
		}
	}
}