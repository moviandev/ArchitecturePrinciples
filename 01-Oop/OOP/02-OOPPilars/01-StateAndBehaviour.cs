namespace OOP
{
  public class Person
  {
    // The state it's being represented by the properties of this class
    // because it's in the state = x for example the Name state is Mark now 
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    // Behaviour is when you generate and/or  process a new information using the own class
    // like the method below
    public int AgeCalculator()
    {
      var currentDate = DateTime.Now;
      var age = currentDate.Year - BirthDate.Year;
      if (currentDate < BirthDate.AddYears(age)) age--;

      return age;
    }
  }
}