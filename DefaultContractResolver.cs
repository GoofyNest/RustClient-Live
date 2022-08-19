public class DefaultContractResolver : IContractResolver // TypeDefIndex: 5991
{	// Fields
	private static readonly IContractResolver _instance; // 0x0
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

	// Properties
	internal static IContractResolver Instance { get; }
	[ObsoleteAttribute] // RVA: 0x7F500 Offset: 0x7E900 VA: 0x18007F500
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; }
	public bool IgnoreSerializableInterface { get; }
	public bool IgnoreSerializableAttribute { get; set; }

	// Methods

	// RVA: 0xE2AD40 Offset: 0xE2A140 VA: 0x180E2AD40
	internal static IContractResolver get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB90 Offset: 0xB0AF90 VA: 0x180B0BB90
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BBA0 Offset: 0xB0AFA0 VA: 0x180B0BBA0
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE2ADA0 Offset: 0xE2A1A0 VA: 0x180E2ADA0
	public void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xE2ACD0 Offset: 0xE2A0D0 VA: 0x180E2ACD0
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7F350 Offset: 0x7E750 VA: 0x18007F350
	// RVA: 0xE2AC40 Offset: 0xE2A040 VA: 0x180E2AC40
	public void .ctor(bool shareCache) { }

	// RVA: 0xE28600 Offset: 0xE27A00 VA: 0x180E28600
	internal DefaultContractResolverState GetState() { }

	// RVA: 0xE295C0 Offset: 0xE289C0 VA: 0x180E295C0 Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0xE27F20 Offset: 0xE27320 VA: 0x180E27F20 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xE2A860 Offset: 0xE29C60 VA: 0x180E2A860
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xE25E50 Offset: 0xE25250 VA: 0x180E25E50 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xE27C90 Offset: 0xE27090 VA: 0x180E27C90
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xE29810 Offset: 0xE28C10 VA: 0x180E29810
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xE26E30 Offset: 0xE26230 VA: 0x180E26E30
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xE27E60 Offset: 0xE27260 VA: 0x180E27E60
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xE24F80 Offset: 0xE24380 VA: 0x180E24F80 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xE266D0 Offset: 0xE25AD0 VA: 0x180E266D0 Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xE29560 Offset: 0xE28960 VA: 0x180E29560 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xE27BF0 Offset: 0xE26FF0 VA: 0x180E27BF0
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xE28670 Offset: 0xE27A70 VA: 0x180E28670
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0xE293D0 Offset: 0xE287D0 VA: 0x180E293D0
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xE27230 Offset: 0xE26630 VA: 0x180E27230
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xE27940 Offset: 0xE26D40 VA: 0x180E27940
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xE256E0 Offset: 0xE24AE0 VA: 0x180E256E0 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xE24C70 Offset: 0xE24070 VA: 0x180E24C70 Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xE262E0 Offset: 0xE256E0 VA: 0x180E262E0 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xE25D80 Offset: 0xE25180 VA: 0x180E25D80 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xE25B60 Offset: 0xE24F60 VA: 0x180E25B60 Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xE26DC0 Offset: 0xE261C0 VA: 0x180E26DC0 Slot: 16
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xE25150 Offset: 0xE24550 VA: 0x180E25150 Slot: 17
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0xE28BE0 Offset: 0xE27FE0 VA: 0x180E28BE0
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xE28A60 Offset: 0xE27E60 VA: 0x180E28A60
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0xE24A50 Offset: 0xE23E50 VA: 0x180E24A50
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0xE28C50 Offset: 0xE28050 VA: 0x180E28C50
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0xE27A20 Offset: 0xE26E20 VA: 0x180E27A20
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0xE26350 Offset: 0xE25750 VA: 0x180E26350 Slot: 18
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xE25DF0 Offset: 0xE251F0 VA: 0x180E25DF0 Slot: 19
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xE269A0 Offset: 0xE25DA0 VA: 0x180E269A0 Slot: 20
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xE2A350 Offset: 0xE29750 VA: 0x180E2A350
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0xE26BC0 Offset: 0xE25FC0 VA: 0x180E26BC0
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xE2A090 Offset: 0xE29490 VA: 0x180E2A090
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0 Slot: 21
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0xE27F00 Offset: 0xE27300 VA: 0x180E27F00 Slot: 22
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xE27F00 Offset: 0xE27300 VA: 0x180E27F00
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xE2A970 Offset: 0xE29D70 VA: 0x180E2A970
	private static void .cctor() { }

}

private sealed class DefaultContractResolver.<>c // TypeDefIndex: 5994
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
private sealed class DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue> // TypeDefIndex: 5993

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
[Serializable]
private sealed class DefaultContractResolver.<>c // TypeDefIndex: 5994
	// Fields
	public static readonly DefaultContractResolver.<>c <>9; // 0x0
	public static Func<MemberInfo, bool> <>9__30_0; // 0x8
	public static Func<MemberInfo, bool> <>9__30_1; // 0x10
	public static Func<Type, IEnumerable<MemberInfo>> <>9__33_0; // 0x18
	public static Func<MemberInfo, bool> <>9__33_1; // 0x20
	public static Func<ConstructorInfo, bool> <>9__36_0; // 0x28
	public static Func<JsonProperty, int> <>9__60_0; // 0x30

	// Methods

	// RVA: 0x1403C50 Offset: 0x1403050 VA: 0x181403C50
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1403400 Offset: 0x1402800 VA: 0x181403400
	internal bool <GetSerializableMembers>b__30_0(MemberInfo m) { }

	// RVA: 0x1403460 Offset: 0x1402860 VA: 0x181403460
	internal bool <GetSerializableMembers>b__30_1(MemberInfo m) { }

	// RVA: 0x1402EF0 Offset: 0x14022F0 VA: 0x181402EF0
	internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType) { }

	// RVA: 0x1402FB0 Offset: 0x14023B0 VA: 0x181402FB0
	internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m) { }

	// RVA: 0x1402E60 Offset: 0x1402260 VA: 0x181402E60
	internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c) { }

	// RVA: 0x1402E10 Offset: 0x1402210 VA: 0x181402E10
	internal int <CreateProperties>b__60_0(JsonProperty p) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_0 // TypeDefIndex: 5995
{	// Fields
	public Func<object, object> getExtensionDataDictionary; // 0x10
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_1 // TypeDefIndex: 5996
{	// Fields
	public Action<object, object> setExtensionDataDictionary; // 0x10
	public Func<object> createExtensionDataDictionary; // 0x18
	public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
	public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14034C0 Offset: 0x14028C0 VA: 0x1814034C0
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_2 // TypeDefIndex: 5997
{	// Fields
	public ObjectConstructor<object> createEnumerableWrapper; // 0x10
	public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1403720 Offset: 0x1402B20 VA: 0x181403720
	internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass64_0 // TypeDefIndex: 5998
{	// Fields
	public MethodCall<object, object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1403870 Offset: 0x1402C70 VA: 0x181403870
	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass65_0 // TypeDefIndex: 5999
{	// Fields
	public Func<object, object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1403910 Offset: 0x1402D10 VA: 0x181403910
	internal bool <SetIsSpecifiedActions>b__0(object o) { }

}

