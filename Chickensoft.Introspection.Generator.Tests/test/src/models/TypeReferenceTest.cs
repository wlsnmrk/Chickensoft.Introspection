namespace Chickensoft.Introspection.Generator.Tests.Models;

using System;
using Chickensoft.Introspection.Generator.Models;
using Shouldly;
using Xunit;

public class TypeReferenceTest
{
  [Fact]
  public void MergePartialDefinition()
  {
    var a = new TypeReference(
      SimpleName: "A",
      Construction: Construction.Class,
      IsPartial: true,
      TypeParameters: []
    );

    var b = new TypeReference(
      SimpleName: "B",
      Construction: Construction.Class,
      IsPartial: false,
      TypeParameters: []
    );


    a.MergePartialDefinition(b).IsPartial.ShouldBeTrue();
    b.MergePartialDefinition(a).IsPartial.ShouldBeTrue();
  }

  [Fact]
  public void GetConstructionCodeString()
  {
    var a = new TypeReference(
      SimpleName: "A",
      Construction: Construction.Struct,
      IsPartial: false,
      TypeParameters: []
    );

    a.CodeString.ShouldBe("struct A");

    var b = a with
    {
      Construction = (Construction)(-1)
    };

    Should.Throw<ArgumentException>(() => b.CodeString);
  }
}
