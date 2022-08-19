internal sealed class ObjectWriter // TypeDefIndex: 1115
{	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x11FA740 Offset: 0x11F9B40 VA: 0x1811FA740
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x11F70D0 Offset: 0x11F64D0 VA: 0x1811F70D0
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x11F9D60 Offset: 0x11F9160 VA: 0x1811F9D60
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x11F98C0 Offset: 0x11F8CC0 VA: 0x1811F98C0
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x11F8D80 Offset: 0x11F8180 VA: 0x1811F8D80
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11F8EF0 Offset: 0x11F82F0 VA: 0x1811F8EF0
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11F7F50 Offset: 0x11F7350 VA: 0x1811F7F50
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x11F7B60 Offset: 0x11F6F60 VA: 0x1811F7B60
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x11F94C0 Offset: 0x11F88C0 VA: 0x1811F94C0
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x11F6B70 Offset: 0x11F5F70 VA: 0x1811F6B70
	private object GetNext(out long objID) { }

	// RVA: 0x11F6D00 Offset: 0x11F6100 VA: 0x1811F6D00
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x11F6FB0 Offset: 0x11F63B0 VA: 0x1811F6FB0
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x11F6E60 Offset: 0x11F6260 VA: 0x1811F6E60
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x11F8B50 Offset: 0x11F7F50 VA: 0x1811F8B50
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x11F94A0 Offset: 0x11F88A0 VA: 0x1811F94A0
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x11F9750 Offset: 0x11F8B50 VA: 0x1811F9750
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x11F6720 Offset: 0x11F5B20 VA: 0x1811F6720
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x11F9720 Offset: 0x11F8B20 VA: 0x1811F9720
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x11F79C0 Offset: 0x11F6DC0 VA: 0x1811F79C0
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x11F7960 Offset: 0x11F6D60 VA: 0x1811F7960
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x11F77B0 Offset: 0x11F6BB0 VA: 0x1811F77B0
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x11F7860 Offset: 0x11F6C60 VA: 0x1811F7860
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x11F7AB0 Offset: 0x11F6EB0 VA: 0x1811F7AB0
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x11F6DF0 Offset: 0x11F61F0 VA: 0x1811F6DF0
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x11F76F0 Offset: 0x11F6AF0 VA: 0x1811F76F0
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x11F67F0 Offset: 0x11F5BF0 VA: 0x1811F67F0
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x9CA440 Offset: 0x9C9840 VA: 0x1809CA440
	private Type GetType(object obj) { }

	// RVA: 0x11F6A80 Offset: 0x11F5E80 VA: 0x1811F6A80
	private NameInfo GetNameInfo() { }

	// RVA: 0xF96E90 Offset: 0xF96290 VA: 0x180F96E90
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x11F6E30 Offset: 0x11F6230 VA: 0x1811F6E30
	private void PutNameInfo(NameInfo nameInfo) { }

}

