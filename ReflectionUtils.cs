internal static class ReflectionUtils // TypeDefIndex: 5965
{	// Fields
	public static readonly Type[] EmptyTypes; // 0x2790

	// Methods

	// RVA: 0x180B5F0 Offset: 0x180A9F0 VA: 0x18180B5F0
	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180AF30 Offset: 0x180A330 VA: 0x18180AF30
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1807A00 Offset: 0x1806E00 VA: 0x181807A00
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x180AEB0 Offset: 0x180A2B0 VA: 0x18180AEB0
	public static bool IsPublic(PropertyInfo property) { }

	// RVA: 0x1809A70 Offset: 0x1808E70 VA: 0x181809A70
	public static Type GetObjectType(object v) { }

	// RVA: 0x1809D40 Offset: 0x1809140 VA: 0x181809D40
	public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder) { }

	// RVA: 0x180B000 Offset: 0x180A400 VA: 0x18180B000
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x1809F30 Offset: 0x1809330 VA: 0x181809F30
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x1808350 Offset: 0x1807750 VA: 0x181808350
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x1808220 Offset: 0x1807620 VA: 0x181808220
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x180AB90 Offset: 0x1809F90 VA: 0x18180AB90
	public static bool IsNullable(Type t) { }

	// RVA: 0x180AA90 Offset: 0x1809E90 VA: 0x18180AA90
	public static bool IsNullableType(Type t) { }

	// RVA: 0x18072D0 Offset: 0x18066D0 VA: 0x1818072D0
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x180A820 Offset: 0x1809C20 VA: 0x18180A820
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x180A020 Offset: 0x1809420 VA: 0x18180A020
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x180A090 Offset: 0x1809490 VA: 0x18180A090
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x180A460 Offset: 0x1809860 VA: 0x18180A460
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x180A660 Offset: 0x1809A60 VA: 0x18180A660
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x180A340 Offset: 0x1809740 VA: 0x18180A340
	private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x1807F30 Offset: 0x1807330 VA: 0x181807F30
	public static Type GetCollectionItemType(Type type) { }

	// RVA: 0x1808660 Offset: 0x1807A60 VA: 0x181808660
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x1809370 Offset: 0x1808770 VA: 0x181809370
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x180A930 Offset: 0x1809D30 VA: 0x18180A930
	public static bool IsIndexedProperty(MemberInfo member) { }

	// RVA: 0x180A880 Offset: 0x1809C80 VA: 0x18180A880
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x18096F0 Offset: 0x1808AF0 VA: 0x1818096F0
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x180B170 Offset: 0x180A570 VA: 0x18180B170
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x1806FD0 Offset: 0x18063D0 VA: 0x181806FD0
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x1807140 Offset: 0x1806540 VA: 0x181807140
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x1808970 Offset: 0x1807D70 VA: 0x181808970
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x180AC60 Offset: 0x180A060 VA: 0x18180AC60
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED380 Offset: 0x5EC780 VA: 0x1805ED380
	|-ReflectionUtils.GetAttribute<JsonExtensionDataAttribute>
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED2E0 Offset: 0x5EC6E0 VA: 0x1805ED2E0
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2AB0 Offset: 0x1AA1EB0 VA: 0x181AA2AB0
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x1807400 Offset: 0x1806800 VA: 0x181807400
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x180B460 Offset: 0x180A860 VA: 0x18180B460
	public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName) { }

	// RVA: 0x1807340 Offset: 0x1806740 VA: 0x181807340
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x1809100 Offset: 0x1808500 VA: 0x181809100
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x1808E80 Offset: 0x1808280 VA: 0x181808E80
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x1807AD0 Offset: 0x1806ED0 VA: 0x181807AD0
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x1809A80 Offset: 0x1808E80 VA: 0x181809A80
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180B160 Offset: 0x180A560 VA: 0x18180B160
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x1807C80 Offset: 0x1807080 VA: 0x181807C80
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x18083B0 Offset: 0x18077B0 VA: 0x1818083B0
	public static object GetDefaultValue(Type type) { }

}

private sealed class ReflectionUtils.<>c // TypeDefIndex: 5966
{	// Fields
	public static readonly ReflectionUtils.<>c <>9; // 0x0
	public static Func<ConstructorInfo, bool> <>9__10_0; // 0x8
	public static Func<MemberInfo, string> <>9__29_0; // 0x10
	public static Func<ParameterInfo, Type> <>9__37_0; // 0x18
	public static Func<FieldInfo, bool> <>9__39_0; // 0x20

	// Methods

	// RVA: 0x18103E0 Offset: 0x180F7E0 VA: 0x1818103E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x180F920 Offset: 0x180ED20 VA: 0x18180F920
	internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c) { }

	// RVA: 0x180F980 Offset: 0x180ED80 VA: 0x18180F980
	internal string <GetFieldsAndProperties>b__29_0(MemberInfo m) { }

	// RVA: 0x180F980 Offset: 0x180ED80 VA: 0x18180F980
	internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p) { }

	// RVA: 0x180F900 Offset: 0x180ED00 VA: 0x18180F900
	internal bool <GetChildPrivateFields>b__39_0(FieldInfo f) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass42_0 // TypeDefIndex: 5967
{	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x180FF90 Offset: 0x180F390 VA: 0x18180FF90
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0x1810000 Offset: 0x180F400 VA: 0x181810000
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

	// RVA: 0x18100C0 Offset: 0x180F4C0 VA: 0x1818100C0
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass43_0 // TypeDefIndex: 5968
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

