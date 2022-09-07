namespace OOP
{
  // Always when you Inherite a class you're assuming the base class is the same as the class being inherited
  // always the inherited class transmits its states and behaviour to the child class
  public class Employee : Person
  {
    public DateTime AdmissionDate { get; set; }
    public string Register { get; set; }
  }

  public class Process
  {
    public void Run()
    {
      var employee = new Employee
      {
        Name = "Mark",
        BirthDate = Convert.ToDateTime("1999/10/27"),
        AdmissionDate = DateTime.UtcNow,
        Register = "0003"
      };

      employee.AgeCalculator();
    }
  }
}