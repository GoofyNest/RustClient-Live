internal sealed class ObjectReader // TypeDefIndex: 1112
{	internal Stream m_stream; // 0x10
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

	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }


	private SerStack get_ValueFixupStack() { }

	internal object get_TopObject() { }

	internal void set_TopObject(object value) { }

	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	private bool HasSurrogate(Type t) { }

	private void CheckSerializable(Type t) { }

	private void InitFullDeserialization() { }

	internal object CrossAppDomainArray(int index) { }

	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	internal void Parse(ParseRecord pr) { }

	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	private void ParseObject(ParseRecord pr) { }

	private void ParseObjectEnd(ParseRecord pr) { }

	private void ParseArray(ParseRecord pr) { }

	private void NextRectangleMap(ParseRecord pr) { }

	private void ParseArrayMember(ParseRecord pr) { }

	private void ParseArrayMemberEnd(ParseRecord pr) { }

	private void ParseMember(ParseRecord pr) { }

	private void ParseMemberEnd(ParseRecord pr) { }

	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	internal long GetId(long objectId) { }

	internal Type Bind(string assemblyString, string typeString) { }

	internal Type FastBindToType(string assemblyName, string typeName) { }

	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }

}

internal class ObjectReader.TypeNAssembly // TypeDefIndex: 1113
{	public Type type; // 0x10
	public string assemblyName; // 0x18


	public void .ctor() { }

}

internal sealed class ObjectReader.TopLevelAssemblyTypeResolver // TypeDefIndex: 1114
{	private Assembly m_topLevelAssembly; // 0x10


	public void .ctor(Assembly topLevelAssembly) { }

	public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }

}

