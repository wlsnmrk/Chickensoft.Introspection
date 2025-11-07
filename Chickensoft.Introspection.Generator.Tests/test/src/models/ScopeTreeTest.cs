namespace Chickensoft.Introspection.Generator.Tests.Models;

using System;
using System.Collections.Generic;
using Chickensoft.Introspection.Generator.Models;
using Shouldly;
using Xunit;

public class ScopeTreeTest
{
  private readonly DeclaredType _genericOuter = new(
  Reference: new TypeReference(
    "GenericOuter",
    Construction: Construction.Class,
    IsPartial: false,
    TypeParameters: ["T"]
  ),
  SyntaxLocation: Microsoft.CodeAnalysis.Location.None,
  Location: new TypeLocation(Namespaces: [], ContainingTypes: []),
  BaseType: null,
  Usings: [],
  Kind: DeclaredTypeKind.ConcreteType,
  IsStatic: false,
  IsPublicOrInternal: true,
  Properties: [],
  Attributes: [],
  Mixins: []
);

  private readonly DeclaredType _outer = new(
    Reference: new TypeReference(
      "Outer",
      Construction: Construction.Class,
      IsPartial: false,
      TypeParameters: []
    ),
    SyntaxLocation: Microsoft.CodeAnalysis.Location.None,
    Location: new TypeLocation(
      Namespaces: [],
      ContainingTypes:
      [
        // Nested inside _outer
        new TypeReference(
          "GenericOuter",
          Construction.Class,
          false,
          ["T"]
        )
      ]
    ),
    BaseType: null,
    Usings: [],
    Kind: DeclaredTypeKind.ConcreteType,
    IsStatic: false,
    IsPublicOrInternal: true,
    Properties: [],
    Attributes: [],
    Mixins: []
  );

  private readonly DeclaredType _inner = new(
    Reference: new TypeReference(
      "Inner",
      Construction: Construction.Class,
      IsPartial: false,
      TypeParameters: []
    ),
    SyntaxLocation: Microsoft.CodeAnalysis.Location.None,
    Location: new TypeLocation(
      Namespaces: [],
      ContainingTypes:
      [
        // Nested inside _outer
        new TypeReference(
          "GenericOuter",
          Construction.Class,
          false,
          TypeParameters: ["T"]
        ),
        new TypeReference(
          "Outer",
          Construction.Class,
          false,
          []
        )
      ]
    ),
    BaseType: null,
    Usings: [],
    Kind: DeclaredTypeKind.ConcreteType,
    IsStatic: false,
    IsPublicOrInternal: true,
    Properties: [],
    Attributes: [],
    Mixins: []
  );

  private readonly DeclaredType _typeInOtherNs = new(
    Reference: new TypeReference(
      "OtherType",
      Construction: Construction.Class,
      IsPartial: false,
      TypeParameters: []
    ),
    SyntaxLocation: Microsoft.CodeAnalysis.Location.None,
    Location: new TypeLocation(
      Namespaces: ["A", "B", "C"],
      ContainingTypes: []
    ),
    BaseType: null,
    Usings: [],
    Kind: DeclaredTypeKind.ConcreteType,
    IsStatic: false,
    IsPublicOrInternal: true,
    Properties: [],
    Attributes: [],
    Mixins: []
  );

  private readonly DeclaredType _typeExtendingTypeInOtherNs = new(
    Reference: new TypeReference(
      "OtherTypeChild",
      Construction: Construction.Class,
      IsPartial: false,
      TypeParameters: []
    ),
    SyntaxLocation: Microsoft.CodeAnalysis.Location.None,
    Location: new TypeLocation(Namespaces: [], ContainingTypes: []),
    BaseType: "OtherType",
    Usings:
    [
      new UsingDirective(Alias: null, Name: "A.B.C", false, false, false)
    ],
    Kind: DeclaredTypeKind.ConcreteType,
    IsStatic: false,
    IsPublicOrInternal: true,
    Properties: [],
    Attributes: [],
    Mixins: []
  );

  [Fact]
  public void AddsDeclaredTypes()
  {
    // Use a map to guarantee types are added in the order shown below.
    var tree = new ScopeTree(
      [
        _inner,
        _outer,
        _genericOuter
      ],
      new Dictionary<string, DeclaredType>()
      {
        [_inner.FullNameOpen] = _inner,
        [_outer.FullNameOpen] = _outer,
        [_genericOuter.FullNameOpen] = _genericOuter
      }
    );

    tree
      .GetTypes((_) => false, searchGenericTypes: false)
      .ShouldBeEmpty();

    tree
      .GetTypes((_) => true, searchGenericTypes: true)
      .ShouldBe(
        [
          _inner,
          _outer,
          _genericOuter
        ],
        ignoreOrder: true
    );
  }

  [Fact]
  public void ThrowsIfContainingTypeIsNotAbleToBeFound() =>
    Should.Throw<InvalidOperationException>(
      () => new ScopeTree(
        [_inner, _outer],
        new Dictionary<string, DeclaredType>()
        {
          [_inner.FullNameOpen] = _inner,
          [_outer.FullNameOpen] = _outer
        }
      )
    );

  [Fact]
  public void FindsTypesInScope()
  {
    var tree = new ScopeTree(
      [_typeInOtherNs, _typeExtendingTypeInOtherNs],
      new Dictionary<string, DeclaredType>()
      {
        [_typeInOtherNs.FullNameOpen] = _typeInOtherNs,
        [_typeExtendingTypeInOtherNs.FullNameOpen] = _typeExtendingTypeInOtherNs,
      }
    );

    tree.ResolveTypeReference([], _typeExtendingTypeInOtherNs, "OtherType")
      .ShouldNotBeNull()
      .FullNameOpen
      .ShouldBe("A.B.C.OtherType");
  }
}
