public sealed class TypeDescriptor // TypeDefIndex: 2758
{
	private static WeakHashtable _providerTable; 
	private static Hashtable _providerTypeTable; 
	private static Hashtable _defaultProviders; 
	private static WeakHashtable _associationTable; 
	private static int _metadataVersion; 
	private static int _collisionIndex; 
	private static BooleanSwitch TraceDescriptor; 
	private static readonly Guid[] _pipelineInitializeKeys; 
	private static readonly Guid[] _pipelineMergeKeys; 
	private static readonly Guid[] _pipelineFilterKeys; 
	private static readonly Guid[] _pipelineAttributeFilterKeys; 
	private static object _internalSyncObject; 
	[CompilerGeneratedAttribute] 
	private static RefreshEventHandler Refreshed; 

	[EditorBrowsableAttribute] 
	public static Type ComObjectType { get; }
	[EditorBrowsableAttribute] 
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }


	public static Type get_ComObjectType() { }

	public static Type get_InterfaceType() { }

	internal static int get_MetadataVersion() { }

	[EditorBrowsableAttribute] 
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	private static void CheckDefaultProvider(Type type) { }

	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsableAttribute] 
	public static object GetAssociation(Type type, object primary) { }

	public static AttributeCollection GetAttributes(Type componentType) { }

	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsableAttribute] 
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	internal static IDictionary GetCache(object instance) { }

	public static TypeConverter GetConverter(Type type) { }

	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	private static Type GetNodeForBaseType(Type searchType) { }

	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsableAttribute] 
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsableAttribute] 
	public static Type GetReflectionType(Type type) { }

	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	private static void RaiseRefresh(object component) { }

	private static void RaiseRefresh(Type type) { }

	public static void Refresh(object component) { }

	private static void Refresh(object component, bool refreshReflectionProvider) { }

	public static void Refresh(Type type) { }

	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	public static void SortDescriptorArray(IList infos) { }

	private static void .cctor() { }

}

private sealed class TypeDescriptor.AttributeFilterCacheItem // TypeDefIndex: 2759
{
	private Attribute[] _filter; 
	internal ICollection FilteredMembers; 


	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	internal bool IsValid(Attribute[] filter) { }

}

private sealed class TypeDescriptor.FilterCacheItem // TypeDefIndex: 2760
{
	private ITypeDescriptorFilterService _filterService; 
	internal ICollection FilteredMembers; 


	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	internal bool IsValid(ITypeDescriptorFilterService filterService) { }

}

private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
{

private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer 
	public static readonly TypeDescriptor.MemberDescriptorComparer Instance; 


	public int Compare(object left, object right) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class TypeDescriptor.MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2763
{
	private ICustomTypeDescriptor _primary; 
	private ICustomTypeDescriptor _secondary; 


	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class TypeDescriptor.TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 2764
{
	internal TypeDescriptor.TypeDescriptionNode Next; 
	internal TypeDescriptionProvider Provider; 


	internal void .ctor(TypeDescriptionProvider provider) { }

	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	public override IDictionary GetCache(object instance) { }

	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	public override Type GetReflectionType(Type objectType, object instance) { }

	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2765
{
	private TypeDescriptor.TypeDescriptionNode _node; 
	private object _instance; 


	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, object instance) { }

	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2766
{
	private TypeDescriptor.TypeDescriptionNode _node; 
	private Type _objectType; 
	private object _instance; 


	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance) { }

	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

