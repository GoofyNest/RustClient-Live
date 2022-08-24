internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2742
{
	private Hashtable _typeData; 
	private static Type[] _typeConstructor; 
	private static Hashtable _intrinsicTypeConverters; 
	private static object _intrinsicReferenceKey; 
	private static object _intrinsicNullableKey; 
	private static object _dictionaryKey; 
	private static Hashtable _propertyCache; 
	private static Hashtable _attributeCache; 
	private static Hashtable _extendedPropertyCache; 
	private static readonly Guid _extenderProviderKey; 
	private static readonly Guid _extenderPropertiesKey; 
	private static readonly Guid _extenderProviderPropertiesKey; 
	private static readonly Type[] _skipInterfaceAttributeList; 
	private static object _internalSyncObject; 

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
{
	private Type _type; 
	private AttributeCollection _attributes; 
	private EventDescriptorCollection _events; 
	private PropertyDescriptorCollection _properties; 
	private TypeConverter _converter; 
	private object[] _editors; 
	private Type[] _editorTypes; 
	private int _editorCount; 

internal bool IsPopulated { get; }


internal void .ctor(Type type) { }

internal bool get_IsPopulated() { }

internal AttributeCollection GetAttributes() { }

internal TypeConverter GetConverter(object instance) { }

internal PropertyDescriptorCollection GetProperties() { }

private Type GetTypeFromName(string typeName) { }

internal void Refresh() { }

}

