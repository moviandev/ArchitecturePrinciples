namespace OOP
{
  // Class definition
  // Class it's data sctructure that represents something in the real world
  public class Home
  {
    public int SizeM2 { get; set; }
    public int Floors { get; set; }
    public decimal Value { get; set; }
    public int Vacancy { get; set; }
  }

  public class Object
  {
    public Object()
    {
      // Object definition
      // It's when you instantiate a class, and then it pass to be an object in the memory
      // When you instantiate a class with new, it'll have a pointer saying there's an object X
      var home = new Home
      {
        SizeM2 = 100,
        Floors = 2,
        Value = 100000,
        Vacancy = 3
      };
    }
  }
}