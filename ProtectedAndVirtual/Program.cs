class MyClass
{
  static void Main()
  {
    DerivedClass derivedClass = new();
    derivedClass.PrintInDerivedClass();
    /*
      ProtectedAbstractPrint is not accessible because it is protected

      If running this, the ProtectedPrintInBaseClass is going to be printed, because the DerivedClass is a subclass of 
      AbstractBaseClass, and it has access to the protected method of it.
    */

    // Virtual
    DerivedClass2 derivedClass2 = new();
    derivedClass2.PrintInDerivedClass();
    derivedClass2.VirtualPrintInBaseClass();
    /*
      PrintInBaseClass is not accessible because it is protected

      If running this, the VirtualPrintInBaseClass is going to print the message from the derived class and the message
      from the base class!
    */
  }
}

abstract class AbstractBaseClass
{
  protected void ProtectedPrintInBaseClass()
  {
    Console.WriteLine("ProtectedPrintInBaseClass");
  }

  // This method must be implemented in the derived class
  protected abstract void ProtectedAbstractPrint();
}

class DerivedClass : AbstractBaseClass
{
  public void PrintInDerivedClass()
  {
    Console.WriteLine("We're in the derived class!");
    ProtectedPrintInBaseClass();
    Console.WriteLine("We're leaving the method in the derived class!");
  }

  protected override void ProtectedAbstractPrint()
  {
    Console.WriteLine("ProtectedAbstractPrint");
  }
}

// Virtual methods
class BaseClass2
{
  protected void PrintInBaseClass()
  {
    Console.WriteLine("PrintInBaseClass");
  }

  public virtual void VirtualPrintInBaseClass()
  {
    Console.WriteLine("VirtualPrintInBaseClass");
  }
}

class DerivedClass2 : BaseClass2
{
  public void PrintInDerivedClass()
  {
    Console.WriteLine("PrintInDerivedClass... then base!");
    PrintInBaseClass();
  }

  public override void VirtualPrintInBaseClass()
  {
    Console.WriteLine("VirtualPrintInBaseClass in the derived class");
    base.VirtualPrintInBaseClass();
    /*
      Base is a keyword to call the base class method. It could be used on the other examples too, but it was not necessary.
      On this one it is necessary because the method is being overridden and we still want to call the original one.
    */
  }
}