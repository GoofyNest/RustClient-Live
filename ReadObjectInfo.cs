internal sealed class ReadObjectInfo // TypeDefIndex: 1108
{
	internal int objectInfoId;
	internal static int readObjectInfoCounter;
	internal Type objectType;
	internal ObjectManager objectManager;
	internal int count;
	internal bool isSi;
	internal bool isNamed;
	internal bool isTyped;
	internal bool bSimpleAssembly;
	internal SerObjectInfoCache cache;
	internal string[] wireMemberNames;
	internal Type[] wireMemberTypes;
	private int lastPosition;
	internal ISerializationSurrogate serializationSurrogate;
	internal StreamingContext context;
	internal List<Type> memberTypesList;
	internal SerObjectInfoInit serObjectInfoInit;
	internal IFormatterConverter formatterConverter;


	internal void .ctor() { }

	internal void ObjectEnd() { }

	internal void PrepareForReuse() { }

	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	private void InitSiRead() { }

	private void InitNoMembers() { }

	private void InitMemberInfo() { }

	internal MemberInfo GetMemberInfo(string name) { }

	internal Type GetType(string name) { }

	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	internal void RecordFixup(long objectId, string name, long idRef) { }

	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	private int Position(string name) { }

	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	internal Type GetMemberType(MemberInfo objMember) { }

	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

}

