public sealed class TypeDescriptor // TypeDefIndex: 2758
{	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static int _metadataVersion; // 0x20
	private static int _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static object _internalSyncObject; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public static Type ComObjectType { get; }
	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }

	// Methods

	// RVA: 0x173BE90 Offset: 0x173B290 VA: 0x18173BE90
	public static Type get_ComObjectType() { }

	// RVA: 0x173BEF0 Offset: 0x173B2F0 VA: 0x18173BEF0
	public static Type get_InterfaceType() { }

	// RVA: 0x173BF50 Offset: 0x173B350 VA: 0x18173BF50
	internal static int get_MetadataVersion() { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x1735380 Offset: 0x1734780 VA: 0x181735380
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1735620 Offset: 0x1734A20 VA: 0x181735620
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x1735CE0 Offset: 0x17350E0 VA: 0x181735CE0
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1735F40 Offset: 0x1735340 VA: 0x181735F40
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x1736160 Offset: 0x1735560 VA: 0x181736160
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x1736640 Offset: 0x1735A40 VA: 0x181736640
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x17365E0 Offset: 0x17359E0 VA: 0x1817365E0
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x1736710 Offset: 0x1735B10 VA: 0x181736710
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1736A20 Offset: 0x1735E20 VA: 0x181736A20
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x1736AE0 Offset: 0x1735EE0 VA: 0x181736AE0
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1736B60 Offset: 0x1735F60 VA: 0x181736B60
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x1736C90 Offset: 0x1736090 VA: 0x181736C90
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1736EF0 Offset: 0x17362F0 VA: 0x181736EF0
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x1736FE0 Offset: 0x17363E0 VA: 0x181736FE0
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x1737250 Offset: 0x1736650 VA: 0x181737250
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x1737920 Offset: 0x1736D20 VA: 0x181737920
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x17378B0 Offset: 0x1736CB0 VA: 0x1817378B0
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x17373D0 Offset: 0x17367D0 VA: 0x1817373D0
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x17379D0 Offset: 0x1736DD0 VA: 0x1817379D0
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x1737A30 Offset: 0x1736E30 VA: 0x181737A30
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x17381A0 Offset: 0x17375A0 VA: 0x1817381A0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x1737B50 Offset: 0x1736F50 VA: 0x181737B50
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x1738140 Offset: 0x1737540 VA: 0x181738140
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x1738200 Offset: 0x1737600 VA: 0x181738200
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x1738430 Offset: 0x1737830 VA: 0x181738430
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x1738870 Offset: 0x1737C70 VA: 0x181738870
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x1739C10 Offset: 0x1739010 VA: 0x181739C10
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x1739FF0 Offset: 0x17393F0 VA: 0x181739FF0
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x173A8F0 Offset: 0x1739CF0 VA: 0x18173A8F0
	private static void RaiseRefresh(object component) { }

	// RVA: 0x173AA10 Offset: 0x1739E10 VA: 0x18173AA10
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x173B030 Offset: 0x173A430 VA: 0x18173B030
	public static void Refresh(object component) { }

	// RVA: 0x173B090 Offset: 0x173A490 VA: 0x18173B090
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x173AB00 Offset: 0x1739F00 VA: 0x18173AB00
	public static void Refresh(Type type) { }

	// RVA: 0x173B7B0 Offset: 0x173ABB0 VA: 0x18173B7B0
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x173B870 Offset: 0x173AC70 VA: 0x18173B870
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x173B950 Offset: 0x173AD50 VA: 0x18173B950
	private static void .cctor() { }

}

private sealed class TypeDescriptor.AttributeFilterCacheItem // TypeDefIndex: 2759
{	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x17228F0 Offset: 0x1721CF0 VA: 0x1817228F0
	internal bool IsValid(Attribute[] filter) { }

}

private sealed class TypeDescriptor.FilterCacheItem // TypeDefIndex: 2760
{	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0xE31A40 Offset: 0xE30E40 VA: 0x180E31A40
	internal bool IsValid(ITypeDescriptorFilterService filterService) { }

}

private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
{
// Namespace: 
private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
	// Fields
	public static readonly TypeDescriptor.MemberDescriptorComparer Instance; // 0x2B0AE8C

	// Methods

	// RVA: 0x1726CF0 Offset: 0x17260F0 VA: 0x181726CF0 Slot: 4
	public int Compare(object left, object right) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1726EC0 Offset: 0x17262C0 VA: 0x181726EC0
	private static void .cctor() { }

}

private sealed class TypeDescriptor.MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2763
{	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x1726F20 Offset: 0x1726320 VA: 0x181726F20 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1726F90 Offset: 0x1726390 VA: 0x181726F90 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1727000 Offset: 0x1726400 VA: 0x181727000 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1727070 Offset: 0x1726470 VA: 0x181727070 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x17270F0 Offset: 0x17264F0 VA: 0x1817270F0 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class TypeDescriptor.TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 2764
{	// Fields
	internal TypeDescriptor.TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x1734E30 Offset: 0x1734230 VA: 0x181734E30
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x1734890 Offset: 0x1733C90 VA: 0x181734890 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1734A10 Offset: 0x1733E10 VA: 0x181734A10 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1734AA0 Offset: 0x1733EA0 VA: 0x181734AA0 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1734B60 Offset: 0x1733F60 VA: 0x181734B60 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1734BF0 Offset: 0x1733FF0 VA: 0x181734BF0 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1734CC0 Offset: 0x17340C0 VA: 0x181734CC0 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2765
{	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private object _instance; // 0x8

	// Methods

	// RVA: 0xF5940 Offset: 0xF4D40 VA: 0x1800F5940
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, object instance) { }

	// RVA: 0x207870 Offset: 0x206C70 VA: 0x180207870 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x207880 Offset: 0x206C80 VA: 0x180207880 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x2078A0 Offset: 0x206CA0 VA: 0x1802078A0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x207890 Offset: 0x206C90 VA: 0x180207890 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x2078B0 Offset: 0x206CB0 VA: 0x1802078B0 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2766
{	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private Type _objectType; // 0x8
	private object _instance; // 0x10

	// Methods

	// RVA: 0xF5B60 Offset: 0xF4F60 VA: 0x1800F5B60
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x2078E0 Offset: 0x206CE0 VA: 0x1802078E0 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x2078F0 Offset: 0x206CF0 VA: 0x1802078F0 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x207910 Offset: 0x206D10 VA: 0x180207910 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x207900 Offset: 0x206D00 VA: 0x180207900 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x207920 Offset: 0x206D20 VA: 0x180207920 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

