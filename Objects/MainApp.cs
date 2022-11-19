using System;

namespace Objects {
	public class MainApp {
		public static void Main(string[] args){
			Person person = new Person(); //Empty object declaration
			Console.WriteLine(person.getName()); //Should print nothing since there is no name
			person.setName("Leo");
			person.setAge(19);
			Console.WriteLine(person.getName() + " is: " + person.getAge() +" years old"); //Should print Leo is 19 years old
			Person person2 = new Person("Leonardo", 19);
			Console.WriteLine(person2.getName() + " is: " + person2.getAge() +" years old"); //Should print Leonardo is 19 years old

		}
	}
}