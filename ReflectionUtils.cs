internal static class ReflectionUtils // TypeDefIndex: 5965
{	public static readonly Type[] EmptyTypes; // 0x2790


	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	public static bool IsPublic(PropertyInfo property) { }

	public static Type GetObjectType(object v) { }

	public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder) { }

	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	public static bool IsNullable(Type t) { }

	public static bool IsNullableType(Type t) { }

	public static Type EnsureNotNullableType(Type t) { }

	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType) { }

	public static Type GetCollectionItemType(Type type) { }

	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	public static bool IsIndexedProperty(MemberInfo member) { }

	public static bool IsIndexedProperty(PropertyInfo property) { }

	public static object GetMemberValue(MemberInfo member, object target) { }

	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED380 Offset: 0x5EC780 VA: 0x1805ED380
	|-ReflectionUtils.GetAttribute<JsonExtensionDataAttribute>
	|-ReflectionUtils.GetAttribute<object>
	*/

	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED2E0 Offset: 0x5EC6E0 VA: 0x1805ED2E0
	|-ReflectionUtils.GetAttribute<object>
	*/

	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2AB0 Offset: 0x1AA1EB0 VA: 0x181AA2AB0
	|-ReflectionUtils.GetAttributes<object>
	*/

	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName) { }

	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr) { }

	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr) { }

	public static object GetDefaultValue(Type type) { }

}

private sealed class ReflectionUtils.<>c // TypeDefIndex: 5966
{	public static readonly ReflectionUtils.<>c <>9; // 0x0
	public static Func<ConstructorInfo, bool> <>9__10_0; // 0x8
	public static Func<MemberInfo, string> <>9__29_0; // 0x10
	public static Func<ParameterInfo, Type> <>9__37_0; // 0x18
	public static Func<FieldInfo, bool> <>9__39_0; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c) { }

	internal string <GetFieldsAndProperties>b__29_0(MemberInfo m) { }

	internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p) { }

	internal bool <GetChildPrivateFields>b__39_0(FieldInfo f) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass42_0 // TypeDefIndex: 5967
{	public PropertyInfo subTypeProperty; // 0x10


	public void .ctor() { }

	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass43_0 // TypeDefIndex: 5968
{
	public void .ctor() { }

}

