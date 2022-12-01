internal static class ReflectionUtils // TypeDefIndex: 5974
{
	public static readonly Type[] EmptyTypes;


	private static void .cctor() { }

	[ExtensionAttribute]
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[ExtensionAttribute]
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
	|-ReflectionUtils.GetAttribute<JsonExtensionDataAttribute>
	|-ReflectionUtils.GetAttribute<object>
	*/

	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-ReflectionUtils.GetAttribute<object>
	*/

	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-ReflectionUtils.GetAttributes<object>
	*/

	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName) { }

	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr) { }

	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[ExtensionAttribute]
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr) { }

	public static object GetDefaultValue(Type type) { }

}

private sealed class ReflectionUtils.<>c // TypeDefIndex: 5975
{
	public static readonly ReflectionUtils.<>c <>9;
	public static Func<ConstructorInfo, bool> <>9__10_0;
	public static Func<MemberInfo, string> <>9__29_0;
	public static Func<ParameterInfo, Type> <>9__37_0;
	public static Func<FieldInfo, bool> <>9__39_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetDefaultConstructor>

	internal string <GetFieldsAndProperties>

	internal Type <GetMemberInfoFromType>

	internal bool <GetChildPrivateFields>

}

private sealed class ReflectionUtils.<>c__DisplayClass42_0 // TypeDefIndex: 5976
{
	public PropertyInfo subTypeProperty;


	public void .ctor() { }

	internal bool <GetChildPrivateProperties>

	internal bool <GetChildPrivateProperties>

	internal bool <GetChildPrivateProperties>

}

private sealed class ReflectionUtils.<>c__DisplayClass43_0 // TypeDefIndex: 5977
{

	public void .ctor() { }

}

