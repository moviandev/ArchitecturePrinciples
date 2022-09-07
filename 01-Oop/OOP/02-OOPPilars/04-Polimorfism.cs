namespace OOP
{
  // Polimorfism
  public class EspressoMachine : HomeAppliance
  {
    public EspressoMachine(string name, int voltage)
      : base(name, voltage)
    {
    }

    public EspressoMachine()
      : base("Default", 220)
    {
    }

    private static void Heat() { }

    private static void Grind() { }

    public void MakeCoffee()
    {
      Test();
      Heat();
      Grind();
    }

    // Override you're overwriting a base behaviour, and you are obliged to do;
    public override void TurnOn()
    {
      // Validate water container
    }

    public override void TurnOff()
    {
      // cool down heater
    }
  }
}