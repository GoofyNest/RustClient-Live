public class DefaultContractResolver : IContractResolver // TypeDefIndex: 5991
{	private static readonly IContractResolver _instance; // 0x0
	private static readonly JsonConverter[] BuiltInConverters; // 0x8
	private static readonly object TypeContractCacheLock; // 0x10
	private static readonly DefaultContractResolverState _sharedState; // 0x18
	private readonly DefaultContractResolverState _instanceState; // 0x10
	private readonly bool _sharedCache; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x22

	internal static IContractResolver Instance { get; }
	[ObsoleteAttribute] // RVA: 0x7F500 Offset: 0x7E900 VA: 0x18007F500
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; }
	public bool IgnoreSerializableInterface { get; }
	public bool IgnoreSerializableAttribute { get; set; }


	internal static IContractResolver get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_IgnoreSerializableAttribute(bool value) { }

	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7F350 Offset: 0x7E750 VA: 0x18007F350
	public void .ctor(bool shareCache) { }

	internal DefaultContractResolverState GetState() { }

	public virtual JsonContract ResolveContract(Type type) { }

	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	private Func<object> GetDefaultCreator(Type createdType) { }

	private void InitializeContract(JsonContract contract) { }

	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	private static bool ShouldSkipDeserialized(Type t) { }

	private static bool ShouldSkipSerializing(Type t) { }

	private List<Type> GetClassHierarchyForType(Type type) { }

	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	protected virtual JsonContract CreateContract(Type objectType) { }

	internal static bool IsJsonPrimitiveType(Type t) { }

	internal static bool IsIConvertible(Type t) { }

	internal static bool CanConvertToString(Type type) { }

	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	internal static string GetClrTypeFullName(Type type) { }

	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	protected virtual string ResolvePropertyName(string propertyName) { }

	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	public string GetResolvedPropertyName(string propertyName) { }

	private static void .cctor() { }

}

private sealed class DefaultContractResolver.<>c // TypeDefIndex: 5994
{
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
private sealed class DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue> // TypeDefIndex: 5993

[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
[Serializable]
private sealed class DefaultContractResolver.<>c // TypeDefIndex: 5994
	public static readonly DefaultContractResolver.<>c <>9; // 0x0
	public static Func<MemberInfo, bool> <>9__30_0; // 0x8
	public static Func<MemberInfo, bool> <>9__30_1; // 0x10
	public static Func<Type, IEnumerable<MemberInfo>> <>9__33_0; // 0x18
	public static Func<MemberInfo, bool> <>9__33_1; // 0x20
	public static Func<ConstructorInfo, bool> <>9__36_0; // 0x28
	public static Func<JsonProperty, int> <>9__60_0; // 0x30


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetSerializableMembers>b__30_0(MemberInfo m) { }

	internal bool <GetSerializableMembers>b__30_1(MemberInfo m) { }

	internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType) { }

	internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m) { }

	internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c) { }

	internal int <CreateProperties>b__60_0(JsonProperty p) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_0 // TypeDefIndex: 5995
{	public Func<object, object> getExtensionDataDictionary; // 0x10
	public MemberInfo member; // 0x18


	public void .ctor() { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_1 // TypeDefIndex: 5996
{	public Action<object, object> setExtensionDataDictionary; // 0x10
	public Func<object> createExtensionDataDictionary; // 0x18
	public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
	public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals1; // 0x28


	public void .ctor() { }

	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_2 // TypeDefIndex: 5997
{	public ObjectConstructor<object> createEnumerableWrapper; // 0x10
	public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals2; // 0x18


	public void .ctor() { }

	internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass64_0 // TypeDefIndex: 5998
{	public MethodCall<object, object> shouldSerializeCall; // 0x10


	public void .ctor() { }

	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass65_0 // TypeDefIndex: 5999
{	public Func<object, object> specifiedPropertyGet; // 0x10


	public void .ctor() { }

	internal bool <SetIsSpecifiedActions>b__0(object o) { }

}

