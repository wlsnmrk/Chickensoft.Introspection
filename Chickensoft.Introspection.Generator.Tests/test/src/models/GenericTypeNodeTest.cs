namespace Chickensoft.Introspection.Generator.Tests.Models;

using Chickensoft.Introspection.Generator.Models;
using Shouldly;
using Xunit;

public class TypeNodeTest
{
  [Fact]
  public void Equality()
  {
    var node = new TypeNode(
      "Type", false, []
    );

    node.Equals(null).ShouldBeFalse();
  }
}
