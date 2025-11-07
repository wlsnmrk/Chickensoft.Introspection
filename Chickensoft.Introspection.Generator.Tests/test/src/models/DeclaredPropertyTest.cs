namespace Chickensoft.Introspection.Generator.Tests.Models;

using Chickensoft.Introspection.Generator.Models;
using Shouldly;
using Xunit;

public class DeclaredPropertyTest
{
  [Fact]
  public void Equality()
  {
    var prop = new DeclaredProperty(
      Name: "Name",
      HasGetter: true,
      HasSetter: true,
      IsInit: false,
      IsRequired: false,
      IsNullable: false,
      DefaultValueExpression: null,
      ExplicitInterfaceName: null,
      TypeNode: new TypeNode("System.String", false, Children: []),
      Attributes: []
    );

    prop.GetHashCode().ShouldBeOfType<int>();

    prop.Equals(null).ShouldBeFalse();

    prop.ShouldBe(
      new DeclaredProperty(
        Name: "Name",
        HasGetter: true,
        HasSetter: true,
        IsInit: false,
        IsRequired: false,
        IsNullable: false,
        DefaultValueExpression: null,
        ExplicitInterfaceName: null,
        TypeNode: new TypeNode("System.String", false, Children: []),
        Attributes: []
      )
    );

    new DeclaredProperty(
      Name: "Name",
      HasGetter: true,
      HasSetter: true,
      IsInit: false,
      IsRequired: false,
      IsNullable: false,
      DefaultValueExpression: null,
      ExplicitInterfaceName: null,
      TypeNode: new TypeNode(
        "System.String", false, Children: []
      ),
      Attributes: [new("", [], [])]
    ).ShouldNotBe(
      new DeclaredProperty(
        Name: "Name",
        HasGetter: true,
        HasSetter: true,
        IsInit: false,
        IsRequired: false,
        IsNullable: false,
        DefaultValueExpression: null,
        ExplicitInterfaceName: null,
        TypeNode: new TypeNode("System.String", false, Children: []),
        Attributes: []
      )
    );
  }
}
