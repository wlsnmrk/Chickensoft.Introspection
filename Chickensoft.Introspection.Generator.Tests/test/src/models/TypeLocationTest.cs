namespace Chickensoft.Introspection.Generator.Tests.Models;

using Chickensoft.Introspection.Generator.Models;
using Shouldly;
using Xunit;

public class TypeLocationTest
{
  [Fact]
  public void Equality()
  {
    var location = new TypeLocation([], []);

    location.Equals(null).ShouldBeFalse();
  }
}
