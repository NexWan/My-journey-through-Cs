using System;
using ClassLibrary1.Properties;

namespace ClassLibrary1{
	
	public class ConvertirInfijo{
		
		public static void Main() {
			String res = ""; ;
			String op = Console.ReadLine();
			PilaChar pila = new PilaChar(op.Length);
			for (int i = 0; i < op.Length; i++) {
				char c = op[i];
				switch (prioridad(c)) {
					case 0:
						res += c;
						break;
					case 1:
					case 2:
					case 3:
						if (!pila.estaVacia()) {
							while (prioridad(c) <= prioridad(pila.datoEnTope()) && pila.datoEnTope() != '(') {
								res += pila.eliminar();
							}
							pila.insertar(c);
						}else 
							pila.insertar(c);
						break;
					case 4:
						if (!pila.estaVacia()) 
							if (c == '(') 
								pila.insertar(c);
							else {
								while (pila.datoEnTope() != '(') 
									res += pila.eliminar();
								pila.eliminar();
							}
						else if(c == '(') 
							pila.insertar(c);
						break;
				}
			}

			while (!pila.estaVacia())
				res += pila.eliminar();
			Console.WriteLine(res);
		}

		public static int prioridad(char c) {
			String[] ops = new String[]{ "+-", "*/", "^ ","()"};
			for (int i = 0; i < ops.Length; i++) 
				if (c == ops[i][0] || c == ops[i][1]) {
					return i + 1;
				}
			return 0;
		}
	}
}