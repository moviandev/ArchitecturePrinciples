namespace OOP
{

  #region Case 1
  public class FisicalPerson : Person
  {
    public string Document { get; set; }
  }

  public class FisicalPerson2
  {
    public Person Person { get; set; }
    public string Document { get; set; }
  }

  public class InheritanceCompositionTest
  {
    public InheritanceCompositionTest()
    {
      var personInheritance = new FisicalPerson
      {
        Name = "John",
        BirthDate = DateTime.Now,
        Document = "12345678912"
      };

      var personComposition = new FisicalPerson2
      {
        Person = new Person
        {
          Name = "John",
          BirthDate = DateTime.Now,
        },
        Document = "12345678912"
      };

      var nameInheritance = personInheritance.Name;
      var nameComposition = personComposition.Person.Name;
    }
  }
  #endregion Case 1

  #region  Case 2
  public interface IRepository<T>
  {
    void Add(T obj);
    void Remove(T obj);
  }

  public interface IPersonRepository
  {
    void Add(Person obj);
  }

  public class Repository<T> : IRepository<T>
  {
    public void Add(T obj)
    {
      throw new NotImplementedException();
    }

    public void Remove(T obj)
    {
      throw new NotImplementedException();
    }
  }

  public class PersonInheritanceRepository : Repository<Person>, IPersonRepository
  {

  }

  public class PersonCompositionRepository : IPersonRepository
  {
    private readonly IRepository<Person> _personRepository;

    public PersonCompositionRepository(IRepository<Person> personRepository)
    {
      _personRepository = personRepository;
    }

    public void Add(Person obj)
    {
      _personRepository.Add(obj);
    }
  }

  public class InheritanceCompositionTest2
  {
    public InheritanceCompositionTest2()
    {
      var repoInh = new PersonInheritanceRepository();
      repoInh.Add(new Person());
      repoInh.Remove(new Person());

      var repoC = new PersonCompositionRepository(new Repository<Person>());
      repoC.Add(new Person());
    }
  }


  #endregion Case 2
}