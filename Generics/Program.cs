using System.Security.Cryptography.X509Certificates;

class MyClass
{
  static void Main()
  {
    // instantiating a generic class with an int type
    GenericClass<int> myNumericInstance = new();
    // instantiating a generic class with a string type
    GenericClass<string> myStringInstance = new();

    ClassWithGenericMethod instanceOfClassWithGenericMethod = new();
    instanceOfClassWithGenericMethod.GenericMethod("This is a string");
    instanceOfClassWithGenericMethod.GenericMethod(42);
    instanceOfClassWithGenericMethod.GenericMethod(3.14);

    // here the vars are of the type of the return of the method
    int genericFunctionResult = instanceOfClassWithGenericMethod.GenericFunction(42);
    string genericFunctionResult2 = instanceOfClassWithGenericMethod.GenericFunction("This is a string");
    double genericFunctionResult3 = instanceOfClassWithGenericMethod.GenericFunction(3.14);


    double CalculateWeight<T>(IEnumerable<T> animals)
      where T : IAnimal // this is a constraint, it means that the type T must implement the IAnimal interface!
    {
      var total = animals.Sum(a => a.Weight);
      return total;
    }

    Dog dog = new(10, 0.5);
    Cat cat = new(5, 0.3, true);
    Fish fish = new(0.1, 0.01);
    Dog dog2 = new(15, 0.6);
    Cat cat2 = new(7, 0.4, false);

    var animals = new IAnimal[] { dog, cat, fish, dog2, cat2 };
    var totalWeight = CalculateWeight(animals);
    // var totalWeight = CalculateWeight(new int[]{1,2,3}) // does not compile, because int does not implement IAnimal

    var cats = new Cat[] { cat, cat2 };
    var dogs = new Dog[] { dog, dog2 };
    var fishs = new Fish[] { fish };

    var totalWeightCats = CalculateWeight(cats);
    var totalWeightDogs = CalculateWeight(dogs);
    var totalWeightFishs = CalculateWeight(fishs);
    /*
      Why those three lines above work?
      The CalculateWeight function is generic, so it can accept any type that implements the IAnimal interface
      That's why we that "where T : IAnimal" constraint, so we can be sure that the type T implements the IAnimal interface
    */
  }
}

public class ImplementationWithIntegerType : IGeneircInterface<int> // the T is int
{
  // no methods here!
}


// This is a generic interface, the T is a placeholder for the type that will be used
public interface IGeneircInterface<T>
{
  // no methods here!
}

// This is a generic class, the T is a placeholder for the type that will be used
public class GenericClass<T> : IGeneircInterface<T>
{
  // no methods here!
}

// We can also have a generic om methods
public class ClassWithGenericMethod
{
  public void GenericMethod<T>(T value)
  {
    Console.WriteLine(
      $"The type of the value is {value.GetType().Name} and the value is {value}"
    );
  }

  // Here the return type is also a generic type!
  public T GenericFunction<T>(T value)
  {
    Console.WriteLine(
      $"The type of the value is {value.GetType().Name} and the value is {value}"
    );
    return value;
  }
}

// But what if we did care about the type, but maybe not the exact type?
// We can use constraints to restrict the types that can be used

public interface IAnimal
{
  double Weight { get; }
  double Height { get; }
  bool HasFur { get; }
}

public record Cat(
  double Weight,
  double Height,
  bool HasFur
) : IAnimal;

public record Dog(
  double Weight,
  double Height
) : IAnimal
{
  public bool HasFur => true;
}

public record Fish(
  double Weight,
  double Height
) : IAnimal
{
  public bool HasFur => false;
}