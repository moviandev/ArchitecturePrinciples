namespace OOP
{
  // Encapsulation its the art of encapsulate behaivours through exposing methods publics or privates
  public class CoffeeAutomation
  {
    public void PourCoffee()
    {
      var espresso = new EspressoMachine();
      espresso.TurnOn();
      // Encapsulating means you're going to hide some behaviours of your class to other class do not know how it's done.
      espresso.MakeCoffee();
      espresso.TurnOff();
    }
  }
}