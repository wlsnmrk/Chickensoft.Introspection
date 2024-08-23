﻿#pragma warning disable
#nullable enable
public partial class TypeRegistry : Chickensoft.Introspection.ITypeRegistry {
  public static Chickensoft.Introspection.ITypeRegistry Instance { get; } = new TypeRegistry();
  
  public System.Collections.Generic.IReadOnlyDictionary<System.Type, Chickensoft.Introspection.ITypeMetadata> VisibleTypes { get; } = new System.Collections.Generic.Dictionary<System.Type, Chickensoft.Introspection.ITypeMetadata>() {
      [typeof(Chickensoft.Introspection.Tests.Attributes.IdAttributeTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("IdAttributeTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.Attributes.IdAttributeTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.Attributes.IdAttributeTest>()), 
      [typeof(Chickensoft.Introspection.Tests.Attributes.MetaAttributeTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("MetaAttributeTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.Attributes.MetaAttributeTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.Attributes.MetaAttributeTest>()), 
      [typeof(Chickensoft.Introspection.Tests.Attributes.MixinAttributeTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("MixinAttributeTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.Attributes.MixinAttributeTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.Attributes.MixinAttributeTest>()), 
      [typeof(Chickensoft.Introspection.Tests.Attributes.VersionAttributeTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("VersionAttributeTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.Attributes.VersionAttributeTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.Attributes.VersionAttributeTest>()), 
      [typeof(Chickensoft.Introspection.Tests.EmptyMetatypeTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("EmptyMetatypeTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.EmptyMetatypeTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.EmptyMetatypeTest>()), 
      [typeof(Chickensoft.Introspection.Tests.IIntrospectiveTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("IIntrospectiveTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.IIntrospectiveTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.IIntrospectiveTest>()), 
      [typeof(Chickensoft.Introspection.Tests.MetaAttributeTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("MetaAttributeTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.MetaAttributeTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.MetaAttributeTest>()), 
      [typeof(Chickensoft.Introspection.Tests.Models.GenericTypeTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("GenericTypeTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.Models.GenericTypeTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.Models.GenericTypeTest>()), 
      [typeof(Chickensoft.Introspection.Tests.Models.MixinBlackboardTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("MixinBlackboardTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.Models.MixinBlackboardTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.Models.MixinBlackboardTest>()), 
      [typeof(Chickensoft.Introspection.Tests.Models.PropertyMetadataTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("PropertyMetadataTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.Models.PropertyMetadataTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.Models.PropertyMetadataTest>()), 
      [typeof(Chickensoft.Introspection.Tests.Models.TypeMetadataTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("TypeMetadataTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.Models.TypeMetadataTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.Models.TypeMetadataTest>()), 
      [typeof(Chickensoft.Introspection.Tests.MyTypeWithAMixin)] = new Chickensoft.Introspection.IntrospectiveTypeMetadata("MyTypeWithAMixin", static (r) => r.Receive<Chickensoft.Introspection.Tests.MyTypeWithAMixin>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.MyTypeWithAMixin>(), new Chickensoft.Introspection.Tests.MyTypeWithAMixin.MetatypeMetadata(), 1), 
      [typeof(Chickensoft.Introspection.Tests.TagAttribute)] = new Chickensoft.Introspection.ConcreteTypeMetadata("TagAttribute", static (r) => r.Receive<Chickensoft.Introspection.Tests.TagAttribute>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TagAttribute>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphAncestryTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("TypeGraphAncestryTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphAncestryTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphAncestryTest>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Ancestor)] = new Chickensoft.Introspection.ConcreteTypeMetadata("Ancestor", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Ancestor>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Ancestor>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphAncestryTest.AncestorSibling)] = new Chickensoft.Introspection.ConcreteTypeMetadata("AncestorSibling", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.AncestorSibling>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.AncestorSibling>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Child)] = new Chickensoft.Introspection.ConcreteTypeMetadata("Child", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Child>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Child>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphAncestryTest.ChildCousin)] = new Chickensoft.Introspection.ConcreteTypeMetadata("ChildCousin", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.ChildCousin>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.ChildCousin>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Parent)] = new Chickensoft.Introspection.ConcreteTypeMetadata("Parent", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Parent>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.Parent>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphAncestryTest.ParentCousin)] = new Chickensoft.Introspection.ConcreteTypeMetadata("ParentCousin", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.ParentCousin>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphAncestryTest.ParentCousin>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("TypeGraphMemberMetadataTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest.ChildModel)] = new Chickensoft.Introspection.IntrospectiveTypeMetadata("ChildModel", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest.ChildModel>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest.ChildModel>(), new Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest.ChildModel.MetatypeMetadata(), 1), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest.Model)] = new Chickensoft.Introspection.IntrospectiveTypeMetadata("Model", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest.Model>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest.Model>(), new Chickensoft.Introspection.Tests.TypeGraphMemberMetadataTest.Model.MetatypeMetadata(), 1), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("TypeGraphTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphTest>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphTest.Model)] = new Chickensoft.Introspection.IdentifiableTypeMetadata("Model", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphTest.Model>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphTest.Model>(), new Chickensoft.Introspection.Tests.TypeGraphTest.Model.MetatypeMetadata(), "test_model", 1), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphTest.NoSubtypes)] = new Chickensoft.Introspection.IntrospectiveTypeMetadata("NoSubtypes", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphTest.NoSubtypes>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphTest.NoSubtypes>(), new Chickensoft.Introspection.Tests.TypeGraphTest.NoSubtypes.MetatypeMetadata(), 1), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeA)] = new Chickensoft.Introspection.IdentifiableTypeMetadata("SubtypeA", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeA>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeA>(), new Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeA.MetatypeMetadata(), "test_model_subtype_a", 1), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeA.SubtypeB)] = new Chickensoft.Introspection.IdentifiableTypeMetadata("SubtypeB", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeA.SubtypeB>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeA.SubtypeB>(), new Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeA.SubtypeB.MetatypeMetadata(), "test_model_subtype_b", 1), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeC)] = new Chickensoft.Introspection.IdentifiableTypeMetadata("SubtypeC", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeC>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeC>(), new Chickensoft.Introspection.Tests.TypeGraphTest.SubtypeC.MetatypeMetadata(), "test_model_subtype_c", 1), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphVersionTest)] = new Chickensoft.Introspection.ConcreteTypeMetadata("TypeGraphVersionTest", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphVersionTest>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphVersionTest>()), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model)] = new Chickensoft.Introspection.AbstractIdentifiableTypeMetadata("Model", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model>(), new Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model.MetatypeMetadata(), "version_test_model"), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model1)] = new Chickensoft.Introspection.IntrospectiveTypeMetadata("Model1", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model1>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model1>(), new Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model1.MetatypeMetadata(), 1), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model2)] = new Chickensoft.Introspection.IntrospectiveTypeMetadata("Model2", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model2>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model2>(), new Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model2.MetatypeMetadata(), 2), 
      [typeof(Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model3)] = new Chickensoft.Introspection.IntrospectiveTypeMetadata("Model3", static (r) => r.Receive<Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model3>(), static () => System.Activator.CreateInstance<Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model3>(), new Chickensoft.Introspection.Tests.TypeGraphVersionTest.Model3.MetatypeMetadata(), 3)
  };
  
  [System.Runtime.CompilerServices.ModuleInitializer]
  internal static void Initialize() => Chickensoft.Introspection.Types.Graph.Register(TypeRegistry.Instance);
}

#nullable restore
#pragma warning restore
