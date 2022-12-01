internal sealed class ObjectWriter // TypeDefIndex: 1115
{
	private Queue m_objectQueue;
	private ObjectIDGenerator m_idGenerator;
	private int m_currentId;
	private ISurrogateSelector m_surrogates;
	private StreamingContext m_context;
	private __BinaryWriter serWriter;
	private SerializationObjectManager m_objectManager;
	private long topId;
	private string topName;
	private Header[] headers;
	private InternalFE formatterEnums;
	private SerializationBinder m_binder;
	private SerObjectInfoInit serObjectInfoInit;
	private IFormatterConverter m_formatterConverter;
	internal object[] crossAppDomainArray;
	private object previousObj;
	private long previousId;
	private Type previousType;
	private InternalPrimitiveTypeE previousCode;
	private Hashtable assemblyToIdTable;
	private SerStack niPool;

	internal SerializationObjectManager ObjectManager { get; }


	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	internal SerializationObjectManager get_ObjectManager() { }

	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	private object GetNext(out long objID) { }

	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	private NameInfo TypeToNameInfo(Type type) { }

	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	private NameInfo MemberToNameInfo(string name) { }

	internal InternalPrimitiveTypeE ToCode(Type type) { }

	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	private Type GetType(object obj) { }

	private NameInfo GetNameInfo() { }

	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	private void PutNameInfo(NameInfo nameInfo) { }

}

