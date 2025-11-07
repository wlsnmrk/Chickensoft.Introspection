namespace Chickensoft.Introspection.Generator.Tests.TestCases;

[Meta]
public partial class ExplicitInterfaceProperty : IInterfaceOne, IInterfaceTwo
{
  string IInterfaceOne.Name => "IInterfaceOne.Name";
  string IInterfaceTwo.Name => "IInterfaceTwo.Name";
}

public interface IInterfaceOne
{
  string Name { get; }
}

public interface IInterfaceTwo
{
  string Name { get; }
}
