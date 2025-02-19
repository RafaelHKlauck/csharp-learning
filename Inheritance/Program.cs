namespace ObjectOrientedProgramming;

class MyClass
{
  static void Main()
  {
    Car sedan = new() { DoorCount = 4 };
    Car coupe = new() { DoorCount = 2 };
    Truck pickupTruck = new() { DoorCount = 2 };
    Bike bike = new();

    sedan.OpenDoor();
    coupe.OpenDoor();
    pickupTruck.OpenDoor();
    bike.OpenDoor();
  }
}


public class Vehicle
{
  public int DoorCount { get; init; }

  // Virtual is going to let me override on a child class
  public virtual void OpenDoor()
  {
    Console.WriteLine(
      $"{GetType().Name} opening {DoorCount} doors!"
    );
  }
}

public class Automobile : Vehicle
{
}

public class Car : Automobile
{
}

public class Truck : Automobile
{
}

public class Van : Automobile
{
}

public class Bike : Vehicle
{
  public Bike()
  {
    DoorCount = 0;
  }

  // Override is going to override the method that was inherited
  public override void OpenDoor()
  {
    Console.WriteLine($"{GetType().Name} there's no doors!");
  }
}

public class Plane : Vehicle
{
}