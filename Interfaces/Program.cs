namespace ObjectOrientedProgramming;

class MyClass
{
  static void Main()
  {
    Motorcycle motorcycle = new();
    Car sedan = new(4);
    TestIgnition(motorcycle); // Not necessary to cast motorcycle into IMotorized becasue the class already implements that interface
    TestIgnition(sedan); // Not necessary to cast coupe into IMotorized becasue the class already implements that interface
  }

  static void TestIgnition(IMotorized motorized)
  {
    motorized.StartEngine();
    Console.WriteLine($"Engine is running: {motorized.IsEngineRunning}");

    motorized.StopEngine();
    Console.WriteLine($"Engine is running: {motorized.IsEngineRunning}");
  }
}

public class Bicycle
{
}

// This is how you implement one interface
public class Motorcycle : IMotorized
{
  public bool IsEngineRunning { get; private set; }

  public void StartEngine()
  {
    if (IsEngineRunning) return;
    IsEngineRunning = true;
    Console.WriteLine("Engine Started!");
  }

  public void StopEngine()
  {
    if (!IsEngineRunning) return;
    IsEngineRunning = false;
    Console.WriteLine("Engine Stoped!");
  }
}

// This is how you implement two interfaces
public class Car(int numberOfDoors) : IHasDoors, IMotorized
{
  private readonly bool[] _doors = new bool[numberOfDoors];
  public bool IsEngineRunning { get; private set; }
  public int NumberOfDoors => _doors.Length;

  public void OpenDoor(int doorIndex)
  {
    _doors[doorIndex] = true;
    Console.WriteLine($"Opening door {doorIndex}");
  }
  public void CloseDoor(int doorIndex)
  {
    _doors[doorIndex] = false;
    Console.WriteLine($"Closing door {doorIndex}");
  }

  public bool IsDoorOpen(int doorIndex)
  {
    return _doors[doorIndex];
  }

  public void StartEngine()
  {
    if (IsEngineRunning) return;
    IsEngineRunning = true;
    Console.WriteLine("Engine Started!");
  }

  public void StopEngine()
  {
    if (!IsEngineRunning) return;
    IsEngineRunning = false;
    Console.WriteLine("Engine Stoped!");
  }
}

public interface IHasDoors
{
  int NumberOfDoors { get; }

  void OpenDoor(int doorIndex);
  void CloseDoor(int doorIndex);
  bool IsDoorOpen(int doorIndex);
}

public interface IMotorized
{
  bool IsEngineRunning { get; }

  void StartEngine();
  void StopEngine();
}
