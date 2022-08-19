internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2742
{	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _intrinsicTypeConverters; // 0x8
	private static object _intrinsicReferenceKey; // 0x10
	private static object _intrinsicNullableKey; // 0x18
	private static object _dictionaryKey; // 0x20
	private static Hashtable _propertyCache; // 0x28
	private static Hashtable _attributeCache; // 0x30
	private static Hashtable _extendedPropertyCache; // 0x38
	private static readonly Guid _extenderProviderKey; // 0x40
	private static readonly Guid _extenderPropertiesKey; // 0x50
	private static readonly Guid _extenderProviderPropertiesKey; // 0x60
	private static readonly Type[] _skipInterfaceAttributeList; // 0x70
	private static object _internalSyncObject; // 0x78

	// Properties
	private static Hashtable IntrinsicTypeConverters { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x172CF10 Offset: 0x172C310 VA: 0x18172CF10
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x1728BD0 Offset: 0x1727FD0 VA: 0x181728BD0 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1728AB0 Offset: 0x1727EB0 VA: 0x181728AB0
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x1728DA0 Offset: 0x17281A0 VA: 0x181728DA0
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x1728DD0 Offset: 0x17281D0 VA: 0x181728DD0 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1728F90 Offset: 0x1728390 VA: 0x181728F90
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x1728FD0 Offset: 0x17283D0 VA: 0x181728FD0
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x1729030 Offset: 0x1728430 VA: 0x181729030
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x1729090 Offset: 0x1728490 VA: 0x181729090
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x17295E0 Offset: 0x17289E0 VA: 0x1817295E0 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1729870 Offset: 0x1728C70 VA: 0x181729870
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x1729560 Offset: 0x1728960 VA: 0x181729560
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x172A0A0 Offset: 0x17294A0 VA: 0x18172A0A0
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x172A0D0 Offset: 0x17294D0 VA: 0x18172A0D0
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x172A140 Offset: 0x1729540 VA: 0x18172A140
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x172A400 Offset: 0x1729800 VA: 0x18172A400
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x172A510 Offset: 0x1729910 VA: 0x18172A510
	internal bool IsPopulated(Type type) { }

	// RVA: 0x172A560 Offset: 0x1729960 VA: 0x18172A560
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x172AA50 Offset: 0x1729E50 VA: 0x18172AA50
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x172AF40 Offset: 0x172A340 VA: 0x18172AF40
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x172BC20 Offset: 0x172B020 VA: 0x18172BC20
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x172C2B0 Offset: 0x172B6B0 VA: 0x18172C2B0
	internal void Refresh(Type type) { }

	// RVA: 0x172C340 Offset: 0x172B740 VA: 0x18172C340
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x172CB50 Offset: 0x172BF50 VA: 0x18172CB50
	private static void .cctor() { }

}

private class ReflectTypeDescriptionProvider.ReflectedTypeData // TypeDefIndex: 2743
{	// Fields
	private Type _type; // 0x10
	private AttributeCollection _attributes; // 0x18
	private EventDescriptorCollection _events; // 0x20
	private PropertyDescriptorCollection _properties; // 0x28
	private TypeConverter _converter; // 0x30
	private object[] _editors; // 0x38
	private Type[] _editorTypes; // 0x40
	private int _editorCount; // 0x48

	// Properties
	internal bool IsPopulated { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(Type type) { }

	// RVA: 0x172E640 Offset: 0x172DA40 VA: 0x18172E640
	internal bool get_IsPopulated() { }

	// RVA: 0x172D620 Offset: 0x172CA20 VA: 0x18172D620
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x172DBC0 Offset: 0x172CFC0 VA: 0x18172DBC0
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x172E130 Offset: 0x172D530 VA: 0x18172E130
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x172E3E0 Offset: 0x172D7E0 VA: 0x18172E3E0
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x172E5C0 Offset: 0x172D9C0 VA: 0x18172E5C0
	internal void Refresh() { }

}

