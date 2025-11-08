using System.Diagnostics.CodeAnalysis;
using Chickensoft.Introspection;

[
  SuppressMessage(
    "Design",
    "CA1050",
    Justification = "Testing type in global scope"
  )
]
public partial class GlobalScopeContainer
{
  [Meta]
  public partial class TypeInGlobalScope;
}
