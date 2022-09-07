namespace ProjectA
{
  #region Classes
  public class PublicClass
  {
    public void PublicTest() { }
    private void PrivateTest() { }
    internal void InternalTest() { }
    protected void ProtectedTest() { }
    private protected void PrivateProtectedTest() { }
    protected internal void ProtectedInternalTest() { }
  }

  // This type of modifier say that this class cannot b inherited just instantiated
  public sealed class SealedClass
  {

  }

  // You dont need to use the private
  class PrivateClass
  {

  }

  internal class InternalClass
  {

  }

  abstract class AbstractClass { }
  #endregion Classes

  #region  Tests
  public class ClassTest
  {
    public ClassTest()
    {
      var publicClass = new PublicClass();
      var privateClass = new PrivateClass();
      var internalClass = new InternalClass();
      // var abstractClass = new AbstractClass();
    }
  }

  // class SealedClass : Sealed { }

  class Modifier1Test
  {
    public Modifier1Test()
    {
      var publicClass = new PublicClass();
      publicClass.PublicTest();
      publicClass.InternalTest();
      publicClass.ProtectedInternalTest();
      // publicClaas.ProtectedTest();
      // publicClaas.PrivateProtectedTest();
      // publicClass.PrivateTest();
    }
  }

  class Modifier2Test : PublicClass
  {
    public Modifier2Test()
    {
      PublicTest();
      InternalTest();
      ProtectedTest();
      ProtectedInternalTest();
      PrivateProtectedTest();
      // PrivateTest();

    }
  }
  #endregion Tests
}

/********************/
// public:

// Access is not restricted
/********************/
/********************/
// protected:

// Access  is limited to the containing class or types
// Derived from the containing class.
/********************/
/********************/
// internal:

// Access is  limited to the current assembly
/********************/
/********************/
// protected internal:

// Access is  limited to the current assembly or types
// derived from the contaning classes
/********************/
/********************/
// private:

// Access is limited to the containing type
/********************/
/********************/
// private protected:

// Access is limited to the containing class or type
// derived from the contaning classes whitin the current assembly.Available since C# 7.2.
/********************/