namespace Objects {
	public class Person {
		private string name;
		private int age;

		public Person(){
			
		}

		public Person(string name, int age){
			this.name = name;
			this.age = age;
		}

		public void setName(string name){
			this.name = name;
		}

		public void setAge(int age){
			this.age = age;
		}

		public int getAge(){
			return age;
		}

		public string getName(){
			return name;
		}
	}
}