internal sealed class ObjectReader // TypeDefIndex: 1112
{	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x11F6660 Offset: 0x11F5A60 VA: 0x1811F6660
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal object get_TopObject() { }

	// RVA: 0x11F66E0 Offset: 0x11F5AE0 VA: 0x1811F66E0
	internal void set_TopObject(object value) { }

	// RVA: 0x11F6530 Offset: 0x11F5930 VA: 0x1811F6530
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x11F2110 Offset: 0x11F1510 VA: 0x1811F2110
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x11F2FC0 Offset: 0x11F23C0 VA: 0x1811F2FC0
	private bool HasSurrogate(Type t) { }

	// RVA: 0x11F1CD0 Offset: 0x11F10D0 VA: 0x1811F1CD0
	private void CheckSerializable(Type t) { }

	// RVA: 0x11F30B0 Offset: 0x11F24B0 VA: 0x1811F30B0
	private void InitFullDeserialization() { }

	// RVA: 0x11F20D0 Offset: 0x11F14D0 VA: 0x1811F20D0
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x11F2080 Offset: 0x11F1480 VA: 0x1811F2080
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x11F1F00 Offset: 0x11F1300 VA: 0x1811F1F00
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x11F6070 Offset: 0x11F5470 VA: 0x1811F6070
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x11F4AF0 Offset: 0x11F3EF0 VA: 0x1811F4AF0
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x11F5F20 Offset: 0x11F5320 VA: 0x1811F5F20
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x11F5EF0 Offset: 0x11F52F0 VA: 0x1811F5EF0
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x11F5B70 Offset: 0x11F4F70 VA: 0x1811F5B70
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x11F56C0 Offset: 0x11F4AC0 VA: 0x1811F56C0
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x11F4160 Offset: 0x11F3560 VA: 0x1811F4160
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x11F31C0 Offset: 0x11F25C0 VA: 0x1811F31C0
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x11F3300 Offset: 0x11F2700 VA: 0x1811F3300
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x11F32D0 Offset: 0x11F26D0 VA: 0x1811F32D0
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x11F4DF0 Offset: 0x11F41F0 VA: 0x1811F4DF0
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x11F4D40 Offset: 0x11F4140 VA: 0x1811F4D40
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x11F5F50 Offset: 0x11F5350 VA: 0x1811F5F50
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x11F62A0 Offset: 0x11F56A0 VA: 0x1811F62A0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x11F6380 Offset: 0x11F5780 VA: 0x1811F6380
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x11F2860 Offset: 0x11F1C60 VA: 0x1811F2860
	internal long GetId(long objectId) { }

	// RVA: 0x11F1C70 Offset: 0x11F1070 VA: 0x1811F1C70
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x11F2520 Offset: 0x11F1920 VA: 0x1811F2520
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x11F64C0 Offset: 0x11F58C0 VA: 0x1811F64C0
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x11F2AB0 Offset: 0x11F1EB0 VA: 0x1811F2AB0
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x11F2CB0 Offset: 0x11F20B0 VA: 0x1811F2CB0
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x11F1E20 Offset: 0x11F1220 VA: 0x1811F1E20
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }

}

internal class ObjectReader.TypeNAssembly // TypeDefIndex: 1113
{	// Fields
	public Type type; // 0x10
	public string assemblyName; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal sealed class ObjectReader.TopLevelAssemblyTypeResolver // TypeDefIndex: 1114
{	// Fields
	private Assembly m_topLevelAssembly; // 0x10

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(Assembly topLevelAssembly) { }

	// RVA: 0x1200110 Offset: 0x11FF510 VA: 0x181200110
	public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }

}

