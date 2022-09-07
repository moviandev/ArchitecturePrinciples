namespace OOP
{
  // Interfaces cannot be confuded with abstract classe 
  // because interface are simple contracts while abstract class can enforce you to use 
  // some implemented behaviour
  // Always choose to use interfaces insted direct implementation
  public interface IRepository
  {
    void Add();
  }

  public class Repository : IRepository
  {
    public void Add()
    {
      // Add item
    }
  }

  // Fake repository is to us mock a test, when need to mock a repository 
  // we do not need to persist the data somewhere
  public class FakeRepository : IRepository
  {
    public void Add()
    {
      // Fake add item
    }
  }

  public class ImplementationUsage
  {
    public void Process()
    {
      // Direct relationship netween the implemented class and the implementee class
      var repo = new Repository();
      repo.Add();
    }
  }

  public class AbstractionUsage
  {
    private readonly IRepository _repo;

    public AbstractionUsage(IRepository repo)
    {
      _repo = repo;
    }

    public void Process()
    {
      _repo.Add();
    }
  }

  public class ImplementationInterfaceTest
  {
    public ImplementationInterfaceTest()
    {
      var repoImpl = new ImplementationUsage();
      repoImpl.Process();

      var repoAbs = new AbstractionUsage(new Repository());
      repoAbs.Process();

      var repoAbsFake = new AbstractionUsage(new FakeRepository());
      repoAbsFake.Process();
    }
  }
}