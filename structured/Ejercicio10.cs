using System;

namespace Ejercicios {
	public class Ejercicio10 {
		public static void Main(){
			int numCenso = 1, edad, numHijos,contM = 0,contMD=0,contSalario = 0,contMT = 0, contMEH = 0,contH = 0;
			String sexo, estadoCivil, trabaja;
			double salario, promedioSalario=0;
			while (numCenso != 0){
				Console.WriteLine("Numero de censo: ");
				numCenso = Convert.ToInt32(Console.ReadLine());
				if (numCenso != 0){
					Console.WriteLine("Sexo del registrado");
					sexo = Console.ReadLine();
					Console.WriteLine("Edad del registrado");
					edad = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Estado civil (a.- soltero, b. Casado, c. Viudo, d. Divorciado)");
					estadoCivil = Console.ReadLine();
					Console.WriteLine("Salario");
					salario = Convert.ToDouble(Console.ReadLine());
					Console.Write("Trabaja (s-si, n-no");
					trabaja = Console.ReadLine();
					Console.WriteLine("Numero de hijos");
					numHijos = Convert.ToInt32(Console.ReadLine());
					if (sexo.ToLower().Equals("mujer")){
						contM++;
						if (edad >= 16 && edad <= 21 && estadoCivil.Equals("a")){ //Cantidad de jovenes solteras entre 16 y 21
							contMD++;
						}
						if (trabaja.Equals("s") && estadoCivil.Equals("b")){ //Numeor de mujeres casadas que trabaja
							contMT++;
						}
						if (edad < 18 && numHijos > 0){ //Cantidad de mujeres menores de edad que tienen hijos
							contMEH++;
						}
					}
					if (sexo.ToLower().Equals("hombre")){ //Promedio de sueldo de homnres
						contH++;
						contSalario++;
						promedioSalario += salario;
					}
					salario = 0;
				}
			}

			String menu = "1. Cantidad de jovenes solteras entre 16 y 21 años \n2. Numero de hombres y mujeres" +
			              "3. Promdio de sueldo de hombres \n4. Numero de mujeres casadas que trabaja \n5. Cantidad de mujeres menores de edad y que tienen hijos" +
			              "\n6. Terminar";
			int opc = 0;
			while (opc != 6){
				Console.WriteLine("\n" + menu);
				opc = Convert.ToInt32(Console.ReadLine());
				switch (opc){
					case 1:
						Console.WriteLine("La cantidad es de: {0}", contMD);
						break;
					case 2:
						Console.WriteLine("Cantidad de homnres: {0} \nCantidad de mujeres: {1}",contH,contM);
						break;
					case 3:
						Console.WriteLine("Promedio de salario: ${0}",(promedioSalario/contSalario));
						break;
					case 4:
						Console.WriteLine("Numero de mujeres casadas que trabaja: {0}",contMT);
						break;
					case 5:
						Console.WriteLine("Cantidad: {0}",contMEH);
						break;
				}
			}
		}
	}
}