// This is just a container for our
// main program logic.
class Program
{
  // This static method here is the "Entrypoint"
  // of our application. Ie. all the logic inside
  // will be executed when we run our program
  static void Main() {

    Console.WriteLine("Starting Program");

    // Classes are just blueprints for logic.
    // To access the logic we have to create 
    // an instance of that class. We do so
    // by calling the class with the "new" keyword
    // and passing in any arguments the
    // constructor method requires
    Person Wayne = new Person("Wayne");
    Person LarsG = new Person("Lars G");

    Wayne.SayName();
    LarsG.SayName();
  }
}

// Classes are just blueprints storing
// variables (members)
// and functions (methods)
// logic for doing operations on those variables

// A simple Person class with a member "name" and a method "SayName"
class Person
{
  // Private member (variable)
  // The private keyword means this is
  // only accessible within this class
  // We are only declaring it here
  // (ie. not setting it to a specific value)
  private string name;

  // Special method (constructor)
  // This is the function that will be called when we are
  // creating an instance of this class.
  // Here we are using it to set the declared members to
  // a specific value
  public Person(string personName) {
    name = personName;
  }

  // A method that uses the private member and printing the
  // name to the console
  // The public keyword means we have access to this in
  // all the instances of this class
  public void SayName() {
    Console.WriteLine($"My name is {name}");
  }
}