public class DefaultContractResolver : IContractResolver // TypeDefIndex: 6000
{
	private static readonly IContractResolver _instance;
	private static readonly JsonConverter[] BuiltInConverters;
	private static readonly object TypeContractCacheLock;
	private static readonly DefaultContractResolverState _sharedState;
	private readonly DefaultContractResolverState _instanceState;
	private readonly bool _sharedCache;
	[CompilerGeneratedAttribute]
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <SerializeCompilerGeneratedMembers>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <IgnoreSerializableInterface>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <IgnoreSerializableAttribute>k__BackingField;

	internal static IContractResolver Instance { get; }
	[ObsoleteAttribute]
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; }
	public bool IgnoreSerializableInterface { get; }
	public bool IgnoreSerializableAttribute { get; set; }


	internal static IContractResolver get_Instance() { }

	[CompilerGeneratedAttribute]
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGeneratedAttribute]
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGeneratedAttribute]
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGeneratedAttribute]
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGeneratedAttribute]
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGeneratedAttribute]
	public void set_IgnoreSerializableAttribute(bool value) { }

	public void .ctor() { }

	[ObsoleteAttribute]
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

private sealed class DefaultContractResolver.<>c // TypeDefIndex: 6003
{

[CompilerGeneratedAttribute]
private sealed class DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue>

[CompilerGeneratedAttribute]
[Serializable]
private sealed class DefaultContractResolver.<>c
	public static readonly DefaultContractResolver.<>c <>9;
	public static Func<MemberInfo, bool> <>9__30_0;
	public static Func<MemberInfo, bool> <>9__30_1;
	public static Func<Type, IEnumerable<MemberInfo>> <>9__33_0;
	public static Func<MemberInfo, bool> <>9__33_1;
	public static Func<ConstructorInfo, bool> <>9__36_0;
	public static Func<JsonProperty, int> <>9__60_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetSerializableMembers>

	internal bool <GetSerializableMembers>

	internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>

	internal bool <GetExtensionDataMemberForType>

	internal bool <GetAttributeConstructor>

	internal int <CreateProperties>

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_0 // TypeDefIndex: 6004
{
	public Func<object, object> getExtensionDataDictionary;
	public MemberInfo member;


	public void .ctor() { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_1 // TypeDefIndex: 6005
{
	public Action<object, object> setExtensionDataDictionary;
	public Func<object> createExtensionDataDictionary;
	public MethodCall<object, object> setExtensionDataDictionaryValue;
	public DefaultContractResolver.<>c


	public void .ctor() { }

	internal void <SetExtensionDataDelegates>

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_2 // TypeDefIndex: 6006
{
	public ObjectConstructor<object> createEnumerableWrapper;
	public DefaultContractResolver.<>c


	public void .ctor() { }

	internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>

}

private sealed class DefaultContractResolver.<>c__DisplayClass64_0 // TypeDefIndex: 6007
{
	public MethodCall<object, object> shouldSerializeCall;


	public void .ctor() { }

	internal bool <CreateShouldSerializeTest>

}

private sealed class DefaultContractResolver.<>c__DisplayClass65_0 // TypeDefIndex: 6008
{
	public Func<object, object> specifiedPropertyGet;


	public void .ctor() { }

	internal bool <SetIsSpecifiedActions>

}

