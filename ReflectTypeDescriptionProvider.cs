internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2742
{	private Hashtable _typeData; // 0x20
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

	private static Hashtable IntrinsicTypeConverters { get; }


	internal void .ctor() { }

	private static Hashtable get_IntrinsicTypeConverters() { }

	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	private static object CreateInstance(Type objectType, Type callingType) { }

	internal AttributeCollection GetAttributes(Type type) { }

	public override IDictionary GetCache(object instance) { }

	internal TypeConverter GetConverter(Type type, object instance) { }

	internal AttributeCollection GetExtendedAttributes(object instance) { }

	internal TypeConverter GetExtendedConverter(object instance) { }

	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	internal PropertyDescriptorCollection GetProperties(Type type) { }

	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	public override Type GetReflectionType(Type objectType, object instance) { }

	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	private static Type GetTypeFromName(string typeName) { }

	internal bool IsPopulated(Type type) { }

	private static Attribute[] ReflectGetAttributes(Type type) { }

	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	internal void Refresh(Type type) { }

	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	private static void .cctor() { }

}

private class ReflectTypeDescriptionProvider.ReflectedTypeData // TypeDefIndex: 2743
{	private Type _type; // 0x10
	private AttributeCollection _attributes; // 0x18
	private EventDescriptorCollection _events; // 0x20
	private PropertyDescriptorCollection _properties; // 0x28
	private TypeConverter _converter; // 0x30
	private object[] _editors; // 0x38
	private Type[] _editorTypes; // 0x40
	private int _editorCount; // 0x48

	internal bool IsPopulated { get; }


	internal void .ctor(Type type) { }

	internal bool get_IsPopulated() { }

	internal AttributeCollection GetAttributes() { }

	internal TypeConverter GetConverter(object instance) { }

	internal PropertyDescriptorCollection GetProperties() { }

	private Type GetTypeFromName(string typeName) { }

	internal void Refresh() { }

}

