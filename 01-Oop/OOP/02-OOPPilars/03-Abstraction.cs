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

    public abstract void TurnOn();
    public abstract void TurnOff();
  }
}