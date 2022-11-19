# Objects in c#

Since c# is an object oriented programming language you can create differente classes for the same application!

Im gonna be using some of the coding homeworks i've made in java but in cs.

A basic class declaration could be like:

``` csharp
public class Person{
    private string name;
    private int age;
    
    public Person(){
        //Empty constructor for the class
    }
    
    public Person(int age, string name){ //Constructor with both parameters we declared
        this.age = age;
        this.name = name;
    }
}
```
You can use this object on a  class were you use the main method.

```csharp
public class MainApp{
    public static void Main(){
        Person person = new Person(); //Declaration of an empty object.
        Person person2 = new Person("Leo", 19); //declaration with both parameters
    }
}
```
Inside the class Person you can create different methods, for example:

```csharp
public class Person{
    ...
    public void setName(String name){
        this.name = name; //Setter for the name in case we create an empty object
    }
    public void getAge(){
        return age; //Returns the parameter we wish
    }
}
```
You can use this different methods inside the main class
```csharp
public static void Main(){
    Person person = new Person("Leo", 19);
    Console.WriteLine(person.getAge()); //Should return the age of the object (19)
    person.setName("Leonardo"); //Should modify the name of the object from "Leo" to "Leonardo"
}
```