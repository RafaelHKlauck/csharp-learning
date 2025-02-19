class MyClass
{
  static void Main()
  {
    MyDerivedClass myDerivedClass = new();
    myDerivedClass.Print();
    myDerivedClass.PrintAbstract();
  }
}

class MyDerivedClass : MyBaseClass
{
  // we MUST implement this here, because is abstract method from abstract class
  public override void PrintAbstract()
  {
    Console.WriteLine("PrintAbstract() in MyDerivatedClass");
  }
}

abstract class MyBaseClass
{
  public void Print()
  {
    Console.WriteLine("Print() in MyBaseClass");
  }

  public abstract void PrintAbstract(); // Classes that inherit from this class must implement this
}

// Examples of abstract classes from interfaces and other abstract classes
class UsingDerivedAbstractClass : MyDerivedAbstractClass
{
  // Here I need to implement PrintAbstract and PrintInterface
  public override void PrintAbstract()
  {
    Console.WriteLine("PrintAbstract() in UsingDerivedAbstractClass");
  }

  public override void PrintInterface()
  {
    Console.WriteLine("PrintInterface() in UsingDerivedAbstractClass");
  }
}

abstract class MyDerivedAbstractClass : MyBaseClass, IMyInterface
{
  /* 
    This class don't need to implement the PrintAbstract, because
    since that this is also an abstract class, the responsibility of
    implementing goes to the class that inherit this one! 

    For the IMyInterface we have two options:
    1 - implement on the class:
    
    public void PrintInterface()
    {
     Console.WriteLine("PrintInterface() in MyDerivedAbstractClass");
    }

    2 - forward the responsibility to the class that will inherit:
  */
  public abstract void PrintInterface();
}

interface IMyInterface
{
  void PrintInterface();
}