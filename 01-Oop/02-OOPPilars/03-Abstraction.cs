namespace OOP
{
  // Abstraction create generic implementations for other classes to implement
  public abstract class HomeAppliance
  {
    private readonly string _name;
    private readonly int _voltage;

    protected HomeAppliance(string name, int voltage)
    {
      _name = name;
      _voltage = voltage;
    }

    // Abstract method obliged you to implement a behaviour to it;
    public abstract void TurnOn();
    public abstract void TurnOff();

    // when you use virtual, you're saying you have behaviour for that metod but you can overwrite it
    public virtual void Test()
    {
      // Test machine
    }
  }
}