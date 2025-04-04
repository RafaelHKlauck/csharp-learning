# C# Learn

## Introduction

This repo is to store my notes about C# programming language that I'm learning from Dometrain [Getting Started: C#](https://dometrain.com/course/getting-started-csharp/?srsltid=AfmBOoquvoqYy6ukirlL8Ki1gplUC9O0s8-9AL42qtKzAz9KhYJCYQGW) and [Deep Dive:C#](https://dometrain.com/course/deep-dive-csharp/?srsltid=AfmBOoqX0cYSNzWXUD9zBhTx0WWnivhO3Mque5qgEyr6d95O4-pwynKp) courses.

## Table of Contents

- [Variables](#variables)
  - [String](#string)(text)
  - [Int](#int) (whole numbers)
  - [Float, Double and Decimal](#float-double-and-decimal) (decimals)
  - [Boolean](#boolean) (true or false)
    - [Operators](#operators)
  - [DateTime](#datetime)
  - [Casting and Parse](#casting-and-parse)
- [Control Flows](#control-flows)
  - [If statement](#if-statement)
  - [Ternary Operators](#ternary-operators)
  - [Switch Stataments and Expressions](#switch-stataments-and-expressions)
- [Collections](#collections)
  - [Arrays](#arrays)
  - [Lists](#lists)
  - [Dictionaries](#dictionaries)
- [Loops](#loops)
  - [While](#while)
  - [For](#for)
  - [Foreach](#foreach)
- [Methods](#methods)
  - [Simple Method](#simple-method)
  - [Arguments](#arguments)
  - [Return Types](#return-types)
- [Expections](#expections)
- [Object Oriented Programming](#object-oriented-programming)
  - [Reference Types](#reference-types)
  - [Fields & Properties](#fields--properties)
  - [Static vs Instances](#static-vs-instances)
  - [Constructors](#constructors)
  - [Enums](#enums)
  - [Structs](#structs)
  - [Problem with Equality](#problem-with-equality)
  - [Records](#records)
  - [Inheritance](#inheritance)
  - [Interfaces](#interfaces)
  - [Abstract Classes](#abstract-classes)
  - [Protected and Virtual](#protected-and-virtual)
  - [Composition](#composition)
  - [Generics](#generics)
  - [Tuples](#tuples)
- [Binary and String data](#binary-and-string-data)
  - [Enconding strings and bytes](#enconding-strings-and-bytes)
  - [Streams](#streams)
  - [Reading and Writing Files](#reading-and-writing-files)
  - [Using & Disposing Streams](#using--disposing-streams)
- [Methods and Functions](#methods-and-functions)
  - [Callbacks and Delegates](#callbacks-and-delegates)
  - [Extension Methods](#extension-methods)
  - [LINQ](#linq)
  - [Lazy](#lazy)
  - [Events](#events)
- [Asynchronous, Parallel and Multi-Threading](#asynchronous-parallel-and-multi-threading)
  - [Parallel](#parallel)
  - [Background Workers](#background-workers)
  - [Task Objects](#task-objects)
  - [Async/Await](#asyncawait)
  - [Cancellation](#cancellation)

## Variables

### String

Declaration

```csharp
string myString;
string my_string;
string MyString;

myString = "Hello World!"; // Assigning value to a var

string testString = "Assigning a valie to a string";
testString = "Re-assign a value";

string firstName = "Rafael";
string lastName = "Klauck";
string fullName = firstName + " " + lastName;

// To read string from terminal can use:
myString = Console.ReadLine();
```

**Strings can as well:**

- Get length: `myString.Length`
- Get single char: `myString[0]`

### Int

Only whole numbers (32 bits)

```csharp
  int myInt;
  int sum = 5 + 10;
  int difference = 5 - 10;
  int product = 5 * 10;
  int quotient 5 / 10; // This is going to result 0, because floating not allowed
  string interpolation = $"5 + 10 = {sum}";
```

### Float, Double and Decimal

- Float is half size of a double
- int: 32 bits
- float: 32 bits (careful: same as int but since it has floating, it will store a smaller range than int)
- double: 64 bits
- decimal: 128 bits (used for financial calculations)

```csharp
  float myFloat;
  double myDouble;
  double myDouble2;
  decimal myDecimal;

  myFloat = 5.5f;
  myDouble = 5.5d;
  myDouble2 = 5.5; // if we put 5.5 only compiler will assume as a double
  myDecimal = 5.5m;
```

### Boolean

- True or false
- C# uses 8 bits to reproduce

```csharp
  bool myBool;

  myBool = true;
  myBool = false;
```

#### Operators

```csharp
  // AND operator (&&):
  bool trueAndFalse = true && false; // false
  bool trueAndTrue = true && true; // true
  bool falseAndFalse = false && false; // false

  // OR operator (||):
  bool trueOrFalse = true || false; // true
  bool trueOrTrue = true || true; // true
  bool falseOrFalse = false || false; // false

  // NOT operator (!)
  bool notTrue = !true; // false
  bool notFalse = !false; // true
```

- `<` - less than
- `>` - greater than
- `<=` - less than or equal
- `>=` - greater than or equal
- `==` - equal to
- `!=` - not equal

### DateTime

```csharp
  DateTime myDateTime;
  DateOnly myDate; // Only date!
  TimeOnly myTime; // Only times!

  myDateTime = DateTime.Now; // Get the local current date time
  myDate = new DateOnly(2025, 2, 13); // 2025-02-13
  myTime = new TimeOnly(1, 23, 45) // 1h 23min 45seg

  // Creating a DateTime combining DateOnly and DateTime!
  DateTime dateTimeFromCombination = new DateTime(myDate, myTime);
```

### Casting and Parse

- Convert one var type to another

```csharp
  // implicitly cast
  int myInt = 5;
  double myDouble = myInt;

  // explicitly cast
  myDouble = 5.5;
  myInt = (int)myDouble; // myInt is going to be 5

  string myString = "5";
  myInt = (int)myString; // this will not compile!
  myInt = int.Parse(myString); // this will work!

  string myString = "5.5";
  double myDouble = double.Parse(myString);
```

## Control Flows

- Used to make decision

### If statement

```csharp
  bool condition = true;
  if (condition)
  {
    Console.Writeline("This is going to print if the conditions is true!");
  }

  // if - else
  if (condition)
  {
    Console.Writeline("This is going to print if the conditions is true!");
  }
  else
  {
    Console.Writeline("This is going to print if the conditions is false!");
  }

  // if - else if - else
    if (condition)
  {
    Console.Writeline("This is going to print if the conditions is true!");
  }
  else if (!condition)
  {
    Console.Writeline("This is going to print if the conditions is false!");
  } else
  {
    Console.Writeline("Never prints!");
  }
```

### Ternary Operators

- used to assign a value to a var based on a condition

```csharp
  int x = 10;
  string result = x > 5
    ? "x is greater than 5"
    : "x is less than 5";
```

### Switch Stataments and Expressions

```csharp
  int dayOfWeek = 4;
  switch(dayOfWeek)
  {
    case 1:
      Console.WriteLine("Monday");
      break;
    case 2:
      Console.WriteLine("Tuesday");
      break;
    case 3:
    case 4:
    case 5:
      Console.WriteLine("Wednesday, Thursday or Friday");
      break;
    .
    .
    default:
      Console.WriteLine("Invalid day");
      break;
  }
```

- It is also possible to add `return` instead of `break`. Doing that it will return from the function that the switch is located.

```csharp
  // Switch expressions
  string dayOfWeekName = "Thursday";
  string result = dayOfWeekName switch
  {
    "Monday" => "First day of the week",
    "Tuesday" => "Second day of the week",
    "Wednesday" => "Third day of the week",
    "Thursday" => "Fourth day of the week",
    "Friday" => "Fifth day of the week",
    "Saturday" => "Sixth day of the week",
    "Sunday" => "Seventh day of the week",
    _=> "Invalid day" // Discard pattern (default)
  };
  Console.WriteLine(result); // Fourth day of the week

```

## Collections

### Arrays

- Collections of variables

```csharp
  int[] numbers = new int[3];
  // set values in an array:
  numbers[0] = 1;
  numbers[1] = 2;
  numbers[2] = 3;

  // We can declare and initialize an array:
  int[] numbers2 = new int[]
  {
    5,
    6,
    7,
    8,
  };

  int[] numbers3 =
  {
    10,
    11,
    12,
  };
  int[] numbers4 = [3,4,5]
```

- Access the length: `numbers.Length;`

### Lists

- Lists are dynamic in size, not necessary to know the length before

```csharp
  List<string> words = new List<string>();

  words.Add("one");
  words.Add("two");
  words.Add("three");

  List<int> numbers = new List<int>
  {
    1,
    2,
    3,
    4,
  };

  // [1,2,3,4]
  // Remove
  numbers.Remove(1); // this is going to remove the VALUE not the index
  // [2,3,4]
  numbers.Remove(2); // this is going to remove the VALUE not the index
  // [3,4]
  numbers.Remove(3); // this is going to remove the VALUE not the index
  // [4]

  // Insert
  numbers.Insert(0, 1); // (position, value)
  // [1,4]
  numbers.Insert(0, 2) // (position, value)
  // [2,1,4]
  numbers.Insert(1, 3) // (position, value)
  // [2,3,1,4]

  // Clear
  numbers.Clear();

  // Sort
  words.Sort();
```

### Dictionaries

- Store key and values
- Keys are unique
- Not ordered

```csharp
  Dictionary<string,int> wordsToNumber = new Dictionary<string,int>();
  wordsToNumbers.Add("one", 1);
  wordsToNumbers.Add("two", 2);
  wordsToNumbers.Add("three", 3);

  // Get info
  int one = wordsToNumbers["one"]; // Might get error if is not there! Prefere use    ContainsKey
  // Set info
  wordsToNumbers["one"] = 111;

  // Declare and initialize
  Dictionary<int, string> wordsToNumber2 = new Dictionary<string,int>
  {
    { 1, "one" },
    { 2, "two" },
    { 3, "three" },
    { 4, "four" },
    // [1] = "one",
    // [2] = "two",
    // [3] = "three",
    // [4] = "four",
  };
```

- `wordsToNumber2.Count`: Gets count of pairs
- `wordsToNumber2.Remove(1)`: Remove key 1
- `wordsToNumber2.Clear()`: Clears the dictionary
- `bool contains = wordsToNumber2.CountsKey(3)`: checks if a key exists(without error)
- `bool contains2 = wordsToNumber2.TryGetValue(3, out string? value)`: Checks and get the value from a dictionary. It declars 2 vars at the same time, `contains2` and `value`(that can be string or null).
- If a key already exists and I try to add it with `wordsToNumber2.Add...` it will return an error. To overwrite the value, it should use `wordsToNumber2[...] = ...`

## Loops

### While

```csharp
  // while:
  int count = 0;
  while (count < 5)
  {
    Console.WriteLine(count);
    count++;
  }

  // do while
  do
  {
    Console.WriteLine(count);
    count++;
  } while(count < 5);

```

### For

```csharp
  for (int i = 0; i < 10; i++)
  {
    Console.WriteLine(i);
  }
```

### Foreach

- Used to iterate over a collection of values

```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  foreach(int number in numbers)
  {
    Console.WriteLine(number);
  }

  // We can iterate dictionaries
  Dictionary<string, int> ages = new()
  {
    { "Alice", 25 },
    { "Bob", 24 },
    { "Charlie", 26 },
  }
  // foreach(var person in ages)
  foreach(KeyValuePair<string, int> person in ages)
  {
    Console.WriteLine($"{person.Key} is {person.Value} years old");
  }
```

## Methods

- Block of code that performs specific task
- Use to break our code into smaller
- Able to reuse it

### Simple Method

```csharp
  void ThisIsAMethod()
  {
    // body!
  }
```

### Arguments

- Parameter is a var in a method definition
- When a method is called the argumetns are the data you pass into methods

```csharp
  void MyMethod(string name, int age)
  {
    // the method body
  }
```

### Return Types

- method doesn't have a return type
- function has a return type

```csharp
  int Add(int a, int b)
  {
    return a + b;
  }
  int sum = Add(a, b);
  int sum2 = Add(Add(1,2), Add(3,4));
```

## Expections

- expection are thrown when the program encounters an error

```csharp
  int IntegerDivision(int x, int y)
  {
    return x / y;
  }

  int result = IntegerDivision(10, 0);
```

- To fix this, need to use try catch

```csharp
  try
  {
    int result = IntegerDivision(10, 0);
  }
  catch (DivideByZeroExpection e)
  {
    Console.WriteLine("You can't divide by zero!");
  }
  // OR:
  // catch (Exception e) when (e.Message.contains("divide by zero"))
  // {
  //   Console.WriteLine("You can't divide by zero!");
  // }
  catch (Exception e)
  {
    Console.WriteLine("An expection was thrown!");
    Console.WriteLine(e.Message);
  }
  finally
  {
    Console.WriteLine("This code always runs!");
  }
```

## Object Oriented Programming

```csharp
  class OurClass
  {

  }

  OurClass ourObject = new OurClass();
  OurClass ourObject = new();

  class OurSecondClass
  {
    public void ExampleMethod()
    {
      Console.WriteLine("Hello from our method!");
    }

    public int ExampleFunction()
    {
      return 42;
    }
  }

  OurSecondClass ourObject2 = new();
  ourObject2.ExampleMethod();
  ourObject2.ExampleFunction();
```

### Reference Types

- classes are reference types in C#
- the primitive types(int, doubles, booleans, ...) are value types

```csharp
  class OurClass
  {

  }

  OurClass object1 = new OurClass(); // new reference
  OurClass object2 = new OurClass(); // new reference
  OurClass object3 = object1; // same reference as object!
```

- Function parameters are copy! It won't change outside, unless it is a reference type, like a class(for example `List`, `Dictionary`, `OurClass`)
- Reference type we use the same reference
- Value types we use a copy
- If we want to change the value of a parameter, we should use `ref` keyword

```csharp
  void ChangeValue(ref int x)
  {
    x = 10;
  }

  int value = 5;
  ChangeValue(ref value);
  Console.WriteLine(value); // 10
```

### Fields & Properties

- field is a var that is declared directly in a class
- private is an access modifier. It specifies that something is accessible within the class

```csharp
  class Person
  {
    private string _name;

    public string Name
    {
      get
      {
        return _name;
      }
    }

    public string Name2 => _name; // Short version of before

    public string Name3 { get; } = "John";

    public string MutableName
    {
      get { return _name; }
      set { _name = value; }
    }

    public void SomeMe()
    {
      _name = "John";
    }
  }
```

### Static vs Instances

- static is a modifier that makes a member belong to a type, rathen than an instace of a type.

```csharp
  static class MyStaticClass
  {
    public static void MyStaticMethod()
    {
      Console.WriteLine("I am a static Method!");
    }
  }

  MyStaticClass myStaticClass = new MyStaticClass(); // error!!
  MyStaticClass.MyStaticMethod // correct!
```

- if a class is static, everything must be static!
- if a class is not static, we can have static inside!

```csharp
  class MyNonStaticClass
  {
    public string MyInstanceProperty { get; set; }
    public static string MyStaticProperty { get; set; }

    public static void MyStaticMethod()
    {
      Console.WriteLine($"The static property value is: ${MyStaticProperty}");
      Console.WriteLine($"The instance property value is: ${MyInstanceProperty}"); //ERROR!
    }

    public void MyInstaceMethod()
    {
      Console.WriteLine($"The static property value is: ${MyStaticProperty}");
      Console.WriteLine($"The instance property value is: ${MyInstanceProperty}");
    }
  }

  MyStaticClass myStaticClass = new MyStaticClass(); // error!!
  MyStaticClass.MyStaticMethod // correct!
```

### Constructors

- This is going to run when we are going to create/constructor the instance of an object
- If the constructor is static, it will only run once(when the class is instance for the first time)

```csharp
  class ExplicitConstructor
  {
    public ExplicitConstructor()
    {
      Console.WriteLine("Called!");
    }
  }
```

### Enums

- they are **value** types

```csharp
  enum DaysOfWeek
  {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
  };

  int monday = (int)DaysOfWeek.Monday;
  string monday = (string)DaysOfWeek.Monday; // this will not compile!

  Console.WriteLine($"Enum Value Directly: {DaysOfWeek.Monday}"); // Monday
  Console.WriteLine($"Enum Value Casted: {(int)DaysOfWeek.Monday}"); // 0

  string mondayString = DaysOfWeek.Monday.ToString(); // "Monday"

  // if we want to convert a string to an enum
  DaysOfWeek mondayEnum = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), "Monday");
  DaysOfWeek mondayEnum2 = Enum.Parse<DaysOfWeek>("Monday"); // This is the same as the line above
  DaysOfWeek mondayEnum3;
  bool parseSucceeded = Enum.TryParse("Monday", out mondayEnum3); // This is the same as the line above

  // We can use the Enum.GetValues to get all values of an enum
  foreach(DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
  {
    Console.WriteLine(day);
  }
  // Or get the names
  foreach(string day in Enum.GetNames(typeof(DaysOfWeek)))
  {
    Console.WriteLine(day);
  }

  // Enums can be used as flags
  [Flags]
  enum Permissions
  {
    None    = 0,
    Read    = 1,
    Write   = 2,
    Execute = 4
  }

  Permissions readWrite = Permissions.Read | Permissions.Write; // Bitwise OR(|)
  Console.WriteLine($"RW: ${readWrite}"); // Read, Write -> the comma shows up because it is a flag, that we are setting before the enum declaration

  bool canRead = (readWrite & Permissions.Read) == Permissions.Read; // Bitwise AND(&)
  bool canWrite = (readWrite & Permissions.Write) == Permissions.Write; // Bitwise AND(&)
  bool canExecute = (readWrite & Permissions.Execute) == Permissions.Execute; // Bitwise AND(&)
  Console.WriteLine($"Can Read: ${canRead}"); // True
  Console.WriteLine($"Can Write: ${canWrite}"); // True
  Console.WriteLine($"Can Execute: ${canExecute}"); // False
```

### Structs

- Value type!
- Similar to classes, but they are value types
- A struct is stored on the stack and a class is stored on the heap
- Struct don't "stress" garbage collector(memory management)
- A struct is copied when it is passed as a parameter, a class is passed by reference
- Some use cases:
  - addreses, small, simple object that you want to pass by value;
  - avoid overhead of heap allocation;

```csharp
  public struct Point
  {
    public int X;
    public int Y;
  }

  public struct PointWithProperties
  {
    public int X { get; set; }
    public int Y { get; set; }
  }

  void DoSomethingWithPoint(Point p)
  {
    p.X = 111;
    p.Y = 222;
  }
  var ourPoint = new Point()
  {
    X = 123,
    Y = 456
  }

  Console.WriteLine($"X: {ourPoint.X}, Y: {ourPoint.Y}"); // X: 123, Y: 456
  DoSomethingWithPoint(ourPoint);
  Console.WriteLine($"X: {ourPoint.X}, Y: {ourPoint.Y}"); // X: 123, Y: 456
  // It was not modived because we are passing a copy, not the reference
```

### Problem with Equality

```csharp
  class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
  }

  Person person1 = new Person { Name = "Alice", Age = 25 };
  Person person2 = new Person { Name = "Alice", Age = 25 };

  Console.WriteLine(person1 == person2); // False
  Console.WriteLine(person1.Equals(person2)); // False
  Console.WriteLine(object.Equals(person1, person2)); // False
```

```csharp
  struct MyStruct
  {
    public string Name { get; set; }
    public int Age { get; set; }
  }

  MyStruct struct1 = new MyStruct { Name = "Alice", Age = 25 };
  MyStruct struct2 = new MyStruct { Name = "Alice", Age = 25 };

  Console.WriteLine(struct1 == struct2); // does not compile
  Console.WriteLine(struct1.Equals(struct2)); // True
  Console.WriteLine(object.Equals(struct1, struct2)); // True
```

- If we want to compare classes, we need to override the `Equals` method

```csharp
  class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      Person other = (Person)obj;
      return Name == other.Name && Age == other.Age;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(Name, Age);
    }
  }

  Person person1 = new Person { Name = "Alice", Age = 25 };
  Person person2 = new Person { Name = "Alice", Age = 25 };

  Console.WriteLine(person1 == person2); // False
  Console.WriteLine(person1.Equals(person2)); // True
  Console.WriteLine(object.Equals(person1, person2)); // True
```

- `==` is an operator, `Equals` is a method
- We can overide the `==` operator

```csharp
  class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      Person other = (Person)obj;
      return Name == other.Name && Age == other.Age;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(Name, Age);
    }

    // Overriding the == operator
    public static bool operator ==(Person left, Person right)
    {
      return left.Equals(right);
    }

    // Overriding the != operator
    public static bool operator !=(Person left, Person right)
    {
      return !left.Equals(right);
    }
  }

  Person person1 = new Person { Name = "Alice", Age = 25 };
  Person person2 = new Person { Name = "Alice", Age = 25 };

  Console.WriteLine(person1 == person2); // True
  Console.WriteLine(person1.Equals(person2)); // True
  Console.WriteLine(object.Equals(person1, person2)); // True
```

### Records

- It is a reference type
- DTO(Data Transfer Object): a class that only contains data and no behavior, no logic

```cs
  public record MyRecord(int numericValue, string StringValue);
  public record MyRecord2
  {
    public int NumericValue { get; init; }
    public string StringValue { get; init; }
  }

  MyRecord record1 = new(123, "ABC");
  MyRecord record2 = new()
  {
    NumericValue = 123,
    StringValue = "ABC"
  };

  // myRecord1.NumericValue = 456; Error! Because it is a record, it is immutable

  MyRecord recordA = new(123, "ABC");
  MyRecord recordB = new(123, "ABC");
  Console.WriteLine(recordA == recordB); // True
  Console.WriteLine(recordA.Equals(recordB)); // True
  Console.WriteLine(object.Equals(recordA, recordB)); // True
  // It is going to be true because it is a record, it is going to compare the values, not the reference, even if it is a reference type

  // We can use the with keyword to create a new record with the same values, but with some values changed
  MyRecord recordC = recordA with { NumericValue = 456 }; // This is going to create a new record with the same values, but with the NumericValue changed

  // We can deconstruct a record
  var (numericValue, stringValue) = recordA;

  // We can have a record struct
  public record struct MyRecordStruct(int NumericValue, string StringValue);
```

### Inheritance

- Inheritance is a mechanism in which one class inherits the properties and behavior of another class
- Examples of this are on [Inheritance](/Inheritance/Program.cs)

### Interfaces

- An interface is a contract that a class can implement
- It defines a set of methods and properties that a class must implement
- They cannot have fields, properties, or constructors
- Examples of this are on [Interfaces](/Interfaces/Program.cs)
- When creating the name, it is common to start with `I` (like `IComparable`, `IDisposable`, `IEnumerable`)

### Abstract Classes

- They are classes but they can't be instantiated directly
- They are used to define a common behavior for all the classes that inherit from it. So the child classes would have to implement the methods
- Abstract classes can also inherit from interfaces AND other abstract classes
- The difference between abstract classes and interfaces is that interfaces are used to define contracts for unrelated classes, while abstract classes are used to define a common behavior for related classes.
- Examples of this are on [Abstract Classes](/AbstractClasses/Program.cs)

### Protected and Virtual

- `protected` is an access modifier that makes a member accessible within the class and its subclasses. So the idea here is that classes that are "from outside" can't access it, but the subclasses(children) can!
- `virtual` is a keyword that allows a method to be overridden in a subclass
- Examples of this are on [Protected and Virtual](/ProtectedAndVirtual/Program.cs)

### Composition

- Composition is a way to combine objects or data types into more complex ones
- It is a way to create a "has a" relationship between classes
- is made up of relationships between objects
- Examples of this are on [Composition](/Composition/Program.cs)

### Generics

- Generics allow you to define classes, interfaces, methods, and delegates without specifying the type they work with
- They are used to create classes, interfaces, methods, and delegates that work with any data type
- Examples of this are on [Generics](/Generics/Program.cs)

### Tuples

- Data structure that can hold multiple values
- Two types of tuples in C#: `System.Tuple` and `System.ValueTuple`
  - `System.Tuple` is a reference type, is immutable and values are properties
  - `System.ValueTuple` is a value type, is mutable and values are fields

```csharp
Tuple<int, string> tuple = new(1, "Hello");

ValueTuple<int, string> valueTuple = new(1, "Hello");
ValueTuple<int, string> valueTuple2 = (1, "Hello"); // This is the same as the line above
var valueTuple3 = (1,2,3,4,5,6,7,8,9,10); // ... and so on
```

#### Why use them?

- When you want to return multiple values from a method
- When you want to pass multiple values to a method

```csharp
(int, int) GetMinAndMaxWithTuple(int[] numbers)
{
  if (numbers.Length == 0)
  {
    throw new ArgumentException("The array is empty");
  }

  int min = numbers[0];
  int max = numbers[0];

  foreach(int number in numbers)
  {
    if (number < min)
    {
      min = number;
    }
    if (number > max)
    {
      max = number;
    }
  }

  return (min, max); // This is a value tuple
}

var minAndMax = GetMinAndMaxWithTuple(new int[] { 1, 2, 3, 4, 5 });
Console.WriteLine($"Min: {minAndMax.Item1}, Max: {minAndMax.Item2}"); // Min: 1, Max: 5
```

Why can also have named tuples:

```csharp
(int Min, int Max) GetMinAndMaxWithTuple(int[] numbers)
{
  if (numbers.Length == 0)
  {
    throw new ArgumentException("The array is empty");
  }

  int min = numbers[0];
  int max = numbers[0];

  foreach(int number in numbers)
  {
    if (number < min)
    {
      min = number;
    }
    if (number > max)
    {
      max = number;
    }
  }

  return (Min: min, Max: max); // This is a value tuple
}
var minAndMax = GetMinAndMaxWithTuple(new int[] { 1, 2, 3, 4, 5 });
// What is nice about this is that we can access the values by name
Console.WriteLine($"Min: {minAndMax.Min}, Max: {minAndMax.Max}"); // Min: 1, Max: 5
```

We can also deconstruct a tuple

```csharp
(int fistThing, string secondThing) = (1, "This is the second thing!");
(int min, int max) = GetMinAndMaxWithTuple(new int[] { 1, 2, 3, 4, 5 });
// just get the min
(int min, _) = GetMinAndMaxWithTuple(new int[] { 1, 2, 3, 4, 5 });
// Or
var (min, _) = GetMinAndMaxWithTuple(new int[] { 1, 2, 3, 4, 5 });
```

- Equality is based on the values, not the reference, so even the types are different, if the values are the same, it is going to be equal

## Binary and String data

### Enconding strings and bytes

- Encoding is the process of converting a sequence of characters into a sequence of bytes
- Decoding is the process of converting a sequence of bytes into a sequence of characters

```csharp
  string helloWorld = "Hello World!";
  byte[] asciiBytesForHelloWorld = Encoding.ASCII.GetBytes(helloWorld); // Encode
  string helloWorldAgain = Encoding.ASCII.GetString(asciiBytesForHelloWorld); // Decode

  // OR we can use the UTF8, which range is bigger, so it can encode more characters
  byte[] utf8BytesForHelloWorld = Encoding.UTF8.GetBytes(helloWorld); // Encode
  string helloWorldAgain = Encoding.UTF8.GetString(utf8BytesForHelloWorld); // Decode
```

### Streams

- Streams are a sequence of bytes
- They are used to read and write data
- They provide a common API for working with binary data
- On C# there's a `Stream` class that is the base class for all streams

```csharp
MemoryStream memoryStream = new(); // This is a stream that stores data in memory

Console.WriteLine(memoryStream.Position); // 0
Console.WriteLine(memoryStream.Length); // 0
Console.WriteLine(memoryStream.Capacity); // 0 -> This is the capacity of the memory stream, this is different than an array length

byte[] data = Encoding.UTF8.GetBytes("Hello World! From Nick Cosentino");
memoryStream.Write(data, offset: 0, count: data.Length); // Write the data to the memory stream

Console.WriteLine(memoryStream.Position); // 33
Console.WriteLine(memoryStream.Length);  // 33
Console.WriteLine(memoryStream.Capacity); // 256

// To read the data we need to point the position to the beginning
memoryStream.Seek(0, SeekOrigin.Begin);
// or
memoryStream.Position = 0;

byte[] readBuffer = new byte[memoryStream.Length];
int numberOfBytesRead = memoryStream.Read(readBuffer, offset: 0, count: readBuffer.Length);
Console.WriteLine($"Number of bytes read: ${numberOfBytesRead}"); // 33

string readString = Encoding.UTF8.GetString(readBuffer);
Console.WriteLine(readString); // Hello World! From Nick Cosentino

// Other thing we can do:
byte[] memoryStreamBytes = memoryStream.ToArray(); // This is going to return the bytes that are in the memory stream -> same as readBuffer
```

### Reading and Writing Files

- There's a static class called `File` that has methods to read and write files

```csharp
// To write a file. First argument is the path, second is the content
File.WriteAllText("file.txt", "Hello World!");
File.WriteAllBytes(
  "file.txt",
  Encoding.UTF8.GetBytes("Hello World! From Nick Cosentino"));

// We can specify the encoding
File.WriteAllText("file.txt", "Hello World!", Encoding.UTF8);

// To read a file
byte[] fileBytes = File.ReadAllBytes("file.txt");
string fileContent = File.ReadAllText("file.txt");


// We can use a similar methods to gain access to a stream

FileStream fileStream = File.Open(
  "file.txt",
  FileMode.OpenOrCreate,
  FileAccess.Write,
  FileShare.Read);

byte[] buffer = Encoding.UTF8.GetBytes("Hello World!");
fileStream.Write(buffer, offset: 0, count: buffer.Length);

Stream fileStreamAsStream = fileStream;
fileStreamAsStream.Seek(0, SeekOrigin.Begin);
fileStreamAsStream.Write(buffer, offset: 0, count: buffer.Length);
fileStream.Close();

// To read a file
FileStream fileStream = File.Open(
  "file.txt",
  FileMode.Open,
  FileAccess.Read,
  FileShare.None);
// Remember that this permissions are the file system permissions, where the first one is the file mode, the second is the access, and the third is the share
byte[] bufferForReading = new byte[readingFileStream.Length];

// But what is the file is huge or we don't know the size?
readingStream.Seek(0, SeekOrigin.Begin); // Pointing to the beggining

StreamReader streamReader = new(readingStream, Encoding.UTF8);
while (!streamReader.EndOfStream)
{
  string line = streamReader.ReadLine();
  Console.WriteLine(line);
}
```

### Using & Disposing Streams

- Streams are resources that need to be disposed of when we are done with them
- `IDisposable` is an interface that has a method called `Dispose` that is used to clean up resources

```csharp
public class MyDisposable : IDisposable
{
  public void Dispose()
  {
    Console.WriteLine("Cleaning up resources!");
  }
}

Stream readmeStream = File.Open("readme.txt", FileMode.Open, FileAccess.Read);

readmeStream.Dispose(); // This is going to clean up the resources

// When opening a stream, we can have an error and the dispose is not going to be called, so we can use a try catch to make sure that the dispose is going to be called

readmeStream = File.Open("readme.txt", FileMode.Open, FileAccess.Read);
try
{
  // Do something with the stream
}
catch
{
  // Handle the error
}
finally
{
  readmeStream.Dispose();
}

// We can also use the using statement as well, that is going to call the dispose method for us
using (Stream readmeStream = File.Open("readme.txt", FileMode.Open, FileAccess.Read))
// This readmeStream var only exists inside the using block
{
  // Do something with the stream
}
```

## Methods and Functions

### Callbacks and Delegates

- A delegate is a type that represents references to methods with a particular parameter list and return type

```csharp
  Action action = RafsAction; // Here I have a method declared on a variable
  action();
  action.Invoke();

  void RafsAction()
  {
    Console.WriteLine("Hello from RafsAction!");
  }
```

- On the `Action` we can have parameters, because the Action accepts Generics
- Is important that the return type **must be** `void`

```csharp
  Action<int> action = RafsAction;
  action(42);

  void RafsAction(int number)
  {
    Console.WriteLine($"Hello from RafsAction! The number is: {number}");
  }
```

- If I want to return a value, I should use `Func`
- The **LAST** generic is the return type

```csharp
  Func<int, int> func = RafsFunc;
  int result = func(42);

  int RafsFunc(int number)
  {
    return number * 2;
  }
```

- We can use this concepts to pass a method as a parameter of another method!

```csharp
  void DoSomething(Action action)
  {
    action();
  }
  DoSomething(RafsAction);

  void DoSomethingWithNumber(Func<int, int> func)
  {
    int result = func(42);
    Console.WriteLine($"The result is: {result}");
  }
  DoSomethingWithNumber(RafsFunc);
```

- We can help readability by using `delegate` keyword

```csharp
  delegate int CalculateDelegate(
    int firstNumber,
    int secondNumber
  );

  int Add(int a, int b)
  {
    return a + b;
  }

  int Subtract(int a, int b)
  {
    return a - b;
  }

  CalculateDelegate addDelegate = Add;
  CalculateDelegate subDelegate = Subtract;

  void Calculate(CalculateDelegate calculateCallback)
  {
    int result = calculateCallback(10, 5);
    Console.WriteLine($"The result is: {result}");
  }
```

### Extension Methods

- It looks like we are extending the class, but we are not
- Necessary to
  - be in a static class
  - be a static method
  - need the this keyword on the parameter that we are extending
  - the parameter marked with this must be first parameter

```csharp
public static class Extensions
{
  public static string CustomReverse(this string str)
  {
    var reserverChars = str.Reverse<char>().ToArray();
    var reserved = new string(reserverChars);
    return reserved;
  }
}

var reserved = "Hello World!".CustomReverse();
Console.WriteLine(reserved); // !dlroW olleH
```

- As we can see on the example, we are extending the `string` class with a method called `CustomReverse`. So every time we have a string, we can call this method

### LINQ

- Language Integrated Query
- LINQ can help us
  - map: transform data
  - filter: remove data
  - reduce: aggregate data

```csharp
List<string> rawNumbers = ["1", "2", "3", "4", "5"];
var numbers = rawNumbers.Select(number => int.Parse(number)).ToList();
// The Select is going to transform the data(like a map)

var evenNumbers = numbers.Where(number => number % 2 == 0).ToList();
// The Where is going to filter the data

var average = numbers.Average();

// example of a more complex query
List<string> rawNumberList = ["0", "9", "1", "8", "2", "7", "3", "6", "4", "5"];
var magicNumber = rawNumberList
  .Select(int.Parse) // converts the strings to integers
  .OrderByDescending(number => number) // sorts the numbers in descending order
  .TakeLast(5) // takes the last 5 numbers -> 4, 3, 2, 1, 0
  .Where(number => number % 2 == 0) // filters out the odd numbers -> 4, 2, 0
  .Average(); // calculates the average -> 2
```

- Need to be careful because LINQ is only going to iterate over the data when we call a method that is going to return the data, like `ToList`, `ToArray`...

### Lazy

- Lazy is a class, that accepts generics, that is going to delay the creation of the object until it is needed
- Lazy computes the value only once and then it caches it, so the next time we call the value, it is going to return the cached value

```csharp
Lazy<int> lazyValue = new(() =>
{
  Console.WriteLine("Calculating the value...");
  int[] numbers = [35,20,30,40,50];

  int max = int.MinValue;
  foreach(int number in numbers)
  {
    if (number > max)
    {
      max = number;
    }
    // Simulating a long calculation
    Thread.Sleep(1000);
  }

  return max;
});

Console.WriteLine("The value is: " + lazyValue.Value); // Here is going to calculate the value with delay
Console.WriteLine("The value is: " + lazyValue.Value); // Here is going to return the value without delay
```

### Events

- A way that we can have delegates to be called by subscribing them to events. That way we can create a mechanism to notify other parts of the code that something happened

```csharp
public class MessageEventArgs : EventArgs
{
  public MessageEventArgs(string message)
  {
    Message = message;
  }

  public string Message { get; }
}

public class EventSource
{
  public event EventHandler<MessageEventArgs> SourceChanged;

  public void RaiseEvent(string message)
  {
    // Check if there are any subscribers. If there's no subscribers the event is going to be null. That is why we have a ? before the Invoke
    SourceChanged?.Invoke(this, new MessageEventArgs(message));
  }
}
```

- To subscribe to an event, we can use the `+=` operator
- To unsubscribe to an event, we can use the `-=` operator

```csharp
EventSource eventSource = new();
eventSource.SourceChanged += HandleEvent; // subscribing
eventSource.RaiseEvent("Hello World!"); // This is going to call the HandleEvent method
eventSource.SourceChanged -= HandleEvent; // unsubscribing

public void HandleEvent(object sender, MessageEventArgs e)
{
  Console.WriteLine($"Message: {e.Message}");
}
```

## Asynchronous, Parallel and Multi-Threading

- Asynchronous programming is a way to run tasks in parallel
  - It is used to run tasks that are going to take a long time to complete
  - It is used to run tasks that are going to wait for something to happen
- Parallel programming is a way to run tasks in parallel
  - It is used to run tasks that can be run at the same time
- Multi-threading is a way to run tasks in parallel
  - It is used to run tasks that can be run at the same time

### Threads

- `Thread` object is used to create and manage a thread

```csharp
Thread thread = new Thread(() =>
{
  Console.WriteLine("Hello from the thread!");
});
thread.Start();

// We can also pass parameters to the thread
record ThreadContext(string Message, string Message);
ThreadContext threadContext1 = new("Thread1", "Hello Thread1");

Thread thread1 = new Thread(new ParameterizedThreadStart(o =>
{
  ThreadContext context = (ThreadContext)o;
  Thread.CurrentThread.Name = context.Name;
  Console.WriteLine(context.Message);
}
));
Thread1.Start(threadContext1);
```

- On Threads there's a attribute called `IsBackground` that is going to make the thread a background thread. This means that the thread is going to be terminated when the main thread is terminated

### Background Workers

- To be able to access BackgroundWorker, we need to add the `System.ComponentModel` namespace
- BackgroundWorker is a class that allows you to run tasks in the background. It is build on top of `threads`

```csharp
BackgroundWorker worker1 = new();

worker1.DoWork += (sender, e) =>
{
  // all of this code is what is going to run in the background
  while(true)
  {
    Console.WriteLine("Hello from the background worker!");
    Thread.Sleep(1000);
  }
};
worker1.RunWorkerAsync();
```

- To pass parameters to the background worker, we can use the `Argument` property

```csharp
BackgroundWorker worker2 = new();
worker2.DoWork += (sender, e) =>
{
  int iterations = (int)e.Argument;
  for(int i = 0; i < iterations; i++)
  {
    Console.WriteLine($"Hello from the background worker! Iteration: {i}");
    Thread.Sleep(1000);
  }
};
worker2.RunWorkerAsync(5);
```

- There's a `RunWorkerCompleted` event that is going to be called when the background worker finishes

```csharp
worker2.RunWorkerCompleted += (sender, e) =>
{
  Console.WriteLine("The background worker 2 has finished!");
};
```

- We can also cancel the background worker

```csharp
BackgroundWorker worker3 = new();
worker3.DoWork += (sender, e) =>
{
  while(!worker3.CancellationPending)
  {
    Console.WriteLine("Hello from the background worker 3!");
    Thread.Sleep(1000);
  }
};

worker3.RunWorkerAsync();

BackgroundWorker worker4 = new();
worker4.DoWork += (sender, e) =>
{
  worker3.CancelAsync(); // This is going to cancel the worker3
};
worker4.RunWorkerAsync();
```

### Task Objects

- `Task` is a class that represents an asynchronous operation
- With it we can have a more control over the asynchronous operation

```csharp
Task task1 = Task.Run(() =>
{
  Console.WriteLine("Hello from the task!");
});

Task task2 = Task.Run(() =>
{
  for(int i = 0; i < 5; i++)
  {
    Console.WriteLine($"Hello from the task! Iteration: {i}");
    Thread.Sleep(1000);
  }
});

Task.WaitAll(task1, task2); // This is going to wait for all the tasks to finish
```

- There's `WaitAll` to wait for all the tasks to finish
- There's `WaitAny` to wait for any of the tasks to finish
- There's `Wait` to wait for a single task to finish

```csharp
Task task3 = Task.Run(() =>
{
  Console.WriteLine("Hello from the task 3!");
}).ContinueWith((t) =>
{
  Console.WriteLine("Hello from the continuation task!");
});
// The continuation task is going to run after the task3 finishes
```

- We can have multiple continuations
- We can have a continuation that is going to run only if the task is successful or if the task fails(`TaskContinuationOptions.OnlyOnFaulted`)

## Async/Await

- `async` is a modifier that is used to define an asynchronous method
- `await` is an operator that is used to wait for an asynchronous operation to complete

```csharp
async Task FirstAsyncMethod()
{
  await Task.Delay(TimeSpan.FromSeconds(1));
  Console.WriteLine("Hello from the async method!");
}

async Task<int> SecondAsyncMethod()
{
  await Task.Delay(TimeSpan.FromSeconds(1));
  return 42;
}

await FirstAsyncMethod();
// OR
Task firstAsyncMethodTask = FirstAsyncMethod();
await firstAsyncMethodTask;
```

-`Task.Yield` an asynchronous method to force the method to complete asynchronously. If there is a current synchronization context, this will post the remainder of the method's execution back to that context.

```csharp
async Task ThirdAsyncMethod()
{
  await Task.Yield();
  var doSomething = ExecuteSomething();
}

await ThirdAsyncMethod();
```

- On example above, the `ExecuteSomething` is going to run asynchronously. But if we don't have the `Task.Yield`, the `ExecuteSomething` is going to run synchronously

### Cancellation

- We can cancel an asynchronous operation by using a `CancellationToken`

```csharp
CancellationTokenSource cts = new();
var cancellationToken = cts.Token;

async Task LoopUntilCancelledAsync(
  CancellationToken cancellationToken)
{
  while(!cancellationToken.IsCancellationRequested)
  {
    Console.WriteLine("Hello from the loop!");
    // We need to use a try catch because the task is going to throw an exception when it is cancelled
    try
    {
      await Task.Delay(3000, cancellationToken);
    }
    catch(OperationCanceledException)
    {
      Console.WriteLine("The task was cancelled!");
    }
  }
}

Task loopTask = LoopUntilCancelledAsync(cancellationToken);
Console.ReadLine();
cts.Cancel(); // This is going to cancel the loopTask
await loopTask; // Just to make sure that the loopTask is finished
```
