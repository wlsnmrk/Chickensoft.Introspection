namespace Chickensoft.Introspection.Generator.Tests;

using Chickensoft.Introspection.Generator.Tests.TestCases;
using Shouldly;
using Xunit;

public class NoIdTest
{
  [Fact]
  public void ModelWithoutExplicitIdIsAllowed()
  {
    TypeRegistry.Instance.VisibleTypes[typeof(NoId)]
      .ShouldBeOfType<IntrospectiveTypeMetadata>();
  }
}
