public class BinaryReader : IDisposable // TypeDefIndex: 616
{	private const int MaxCharBytesSize = 128;
	private Stream m_stream; // 0x10
	private byte[] m_buffer; // 0x18
	private Decoder m_decoder; // 0x20
	private byte[] m_charBytes; // 0x28
	private char[] m_singleChar; // 0x30
	private char[] m_charBuffer; // 0x38
	private int m_maxCharsSize; // 0x40
	private bool m_2BytesPerChar; // 0x44
	private bool m_isMemoryStream; // 0x45
	private bool m_leaveOpen; // 0x46

	public virtual Stream BaseStream { get; }


	public void .ctor(Stream input) { }

	public void .ctor(Stream input, Encoding encoding) { }

	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	public virtual Stream get_BaseStream() { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public virtual int Read() { }

	public virtual bool ReadBoolean() { }

	public virtual byte ReadByte() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public virtual sbyte ReadSByte() { }

	public virtual char ReadChar() { }

	public virtual short ReadInt16() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public virtual ushort ReadUInt16() { }

	public virtual int ReadInt32() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public virtual uint ReadUInt32() { }

	public virtual long ReadInt64() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public virtual ulong ReadUInt64() { }

	public virtual float ReadSingle() { }

	public virtual double ReadDouble() { }

	public virtual Decimal ReadDecimal() { }

	public virtual string ReadString() { }

	private int InternalReadChars(char[] buffer, int index, int count) { }

	private int InternalReadOneChar() { }

	public virtual char[] ReadChars(int count) { }

	public virtual int Read(byte[] buffer, int index, int count) { }

	public virtual byte[] ReadBytes(int count) { }

	protected virtual void FillBuffer(int numBytes) { }

	protected internal int Read7BitEncodedInt() { }

}

public class BinaryWriter : IDisposable // TypeDefIndex: 617
{	public static readonly BinaryWriter Null; // 0x0
	protected Stream OutStream; // 0x10
	private byte[] _buffer; // 0x18
	private Encoding _encoding; // 0x20
	private Encoder _encoder; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private bool _leaveOpen; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private char[] _tmpOneCharBuffer; // 0x38
	private byte[] _largeByteBuffer; // 0x40
	private int _maxChars; // 0x48
	private const int LargeByteBufferSize = 256;

	public virtual Stream BaseStream { get; }


	protected void .ctor() { }

	public void .ctor(Stream output) { }

	public void .ctor(Stream output, Encoding encoding) { }

	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public virtual Stream get_BaseStream() { }

	public virtual void Flush() { }

	public virtual void Write(bool value) { }

	public virtual void Write(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public virtual void Write(sbyte value) { }

	public virtual void Write(byte[] buffer) { }

	public virtual void Write(byte[] buffer, int index, int count) { }

	public virtual void Write(char ch) { }

	public virtual void Write(char[] chars) { }

	public virtual void Write(double value) { }

	public virtual void Write(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public virtual void Write(ushort value) { }

	public virtual void Write(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public virtual void Write(uint value) { }

	public virtual void Write(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public virtual void Write(ulong value) { }

	public virtual void Write(float value) { }

	public virtual void Write(string value) { }

	protected void Write7BitEncodedInt(int value) { }

	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1022
{	public static readonly bool TargetsAtLeast_Desktop_V4_5; // 0x0
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; // 0x1


	private static void .cctor() { }

}

internal static class BinaryConverter // TypeDefIndex: 1068
{
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }

}

internal sealed class BinaryAssemblyInfo // TypeDefIndex: 1070
{	internal string assemblyString; // 0x10
	private Assembly assembly; // 0x18


	internal void .ctor(string assemblyString) { }

	internal void .ctor(string assemblyString, Assembly assembly) { }

	internal Assembly GetAssembly() { }

}

internal sealed class BinaryAssembly // TypeDefIndex: 1072
{	internal int assemId; // 0x10
	internal string assemblyString; // 0x18


	internal void .ctor() { }

	internal void Set(int assemId, string assemblyString) { }

	public void Write(__BinaryWriter sout) { }

	public void Read(__BinaryParser input) { }

	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainAssembly // TypeDefIndex: 1073
{	internal int assemId; // 0x10
	internal int assemblyIndex; // 0x14


	internal void .ctor() { }

	public void Read(__BinaryParser input) { }

	public void Dump() { }

}

internal sealed class BinaryObject // TypeDefIndex: 1074
{	internal int objectId; // 0x10
	internal int mapId; // 0x14


	internal void .ctor() { }

	internal void Set(int objectId, int mapId) { }

	public void Write(__BinaryWriter sout) { }

	public void Read(__BinaryParser input) { }

	public void Dump() { }

}

internal sealed class BinaryMethodCall // TypeDefIndex: 1075
{	private string methodName; // 0x10
	private string typeName; // 0x18
	private object[] args; // 0x20
	private object callContext; // 0x28
	private Type[] argTypes; // 0x30
	private bool bArgsPrimitive; // 0x38
	private MessageEnum messageEnum; // 0x3C


	internal void Write(__BinaryWriter sout) { }

	internal void Dump() { }

	public void .ctor() { }

}

internal sealed class BinaryMethodReturn // TypeDefIndex: 1076
{	private object returnValue; // 0x10
	private object[] args; // 0x18
	private object callContext; // 0x20
	private Type[] argTypes; // 0x28
	private bool bArgsPrimitive; // 0x30
	private MessageEnum messageEnum; // 0x34
	private Type returnType; // 0x38
	private static object instanceOfVoid; // 0x0


	private static void .cctor() { }

	internal void .ctor() { }

	public void Write(__BinaryWriter sout) { }

	public void Dump() { }

}

internal sealed class BinaryObjectString // TypeDefIndex: 1077
{	internal int objectId; // 0x10
	internal string value; // 0x18


	internal void .ctor() { }

	internal void Set(int objectId, string value) { }

	public void Write(__BinaryWriter sout) { }

	public void Read(__BinaryParser input) { }

	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainString // TypeDefIndex: 1078
{	internal int objectId; // 0x10
	internal int value; // 0x14


	internal void .ctor() { }

	public void Read(__BinaryParser input) { }

	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainMap // TypeDefIndex: 1079
{	internal int crossAppDomainArrayIndex; // 0x10


	internal void .ctor() { }

	public void Read(__BinaryParser input) { }

	public void Dump() { }

}

internal sealed class BinaryObjectWithMap // TypeDefIndex: 1081
{	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30


	internal void .ctor() { }

	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	public void Write(__BinaryWriter sout) { }

	public void Read(__BinaryParser input) { }

	public void Dump() { }

}

internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 1082
{	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48


	internal void .ctor() { }

	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	public void Write(__BinaryWriter sout) { }

	public void Read(__BinaryParser input) { }

}

internal sealed class BinaryArray // TypeDefIndex: 1083
{	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40


	internal void .ctor() { }

	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	public void Write(__BinaryWriter sout) { }

	public void Read(__BinaryParser input) { }

}

internal enum BinaryHeaderEnum // TypeDefIndex: 1091
{	public int value__; // 0x0
	public const BinaryHeaderEnum SerializedStreamHeader = 0;
	public const BinaryHeaderEnum Object = 1;
	public const BinaryHeaderEnum ObjectWithMap = 2;
	public const BinaryHeaderEnum ObjectWithMapAssemId = 3;
	public const BinaryHeaderEnum ObjectWithMapTyped = 4;
	public const BinaryHeaderEnum ObjectWithMapTypedAssemId = 5;
	public const BinaryHeaderEnum ObjectString = 6;
	public const BinaryHeaderEnum Array = 7;
	public const BinaryHeaderEnum MemberPrimitiveTyped = 8;
	public const BinaryHeaderEnum MemberReference = 9;
	public const BinaryHeaderEnum ObjectNull = 10;
	public const BinaryHeaderEnum MessageEnd = 11;
	public const BinaryHeaderEnum Assembly = 12;
	public const BinaryHeaderEnum ObjectNullMultiple256 = 13;
	public const BinaryHeaderEnum ObjectNullMultiple = 14;
	public const BinaryHeaderEnum ArraySinglePrimitive = 15;
	public const BinaryHeaderEnum ArraySingleObject = 16;
	public const BinaryHeaderEnum ArraySingleString = 17;
	public const BinaryHeaderEnum CrossAppDomainMap = 18;
	public const BinaryHeaderEnum CrossAppDomainString = 19;
	public const BinaryHeaderEnum CrossAppDomainAssembly = 20;
	public const BinaryHeaderEnum MethodCall = 21;
	public const BinaryHeaderEnum MethodReturn = 22;

}

internal enum BinaryTypeEnum // TypeDefIndex: 1092
{	public int value__; // 0x0
	public const BinaryTypeEnum Primitive = 0;
	public const BinaryTypeEnum String = 1;
	public const BinaryTypeEnum Object = 2;
	public const BinaryTypeEnum ObjectUrt = 3;
	public const BinaryTypeEnum ObjectUser = 4;
	public const BinaryTypeEnum ObjectArray = 5;
	public const BinaryTypeEnum StringArray = 6;
	public const BinaryTypeEnum PrimitiveArray = 7;

}

internal enum BinaryArrayTypeEnum // TypeDefIndex: 1093
{	public int value__; // 0x0
	public const BinaryArrayTypeEnum Single = 0;
	public const BinaryArrayTypeEnum Jagged = 1;
	public const BinaryArrayTypeEnum Rectangular = 2;
	public const BinaryArrayTypeEnum SingleOffset = 3;
	public const BinaryArrayTypeEnum JaggedOffset = 4;
	public const BinaryArrayTypeEnum RectangularOffset = 5;

}

public sealed class BinaryFormatter // TypeDefIndex: 1104
{	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }


	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	public void set_SurrogateSelector(ISurrogateSelector value) { }

	public void .ctor() { }

	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	public object Deserialize(Stream serializationStream) { }

	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	public void Serialize(Stream serializationStream, object graph) { }

	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	internal static TypeInformation GetTypeInformation(Type type) { }

	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1833
{	private static bool _targetsAtLeast_Desktop_V4_5_2; // 0x1347D

	internal static bool TargetsAtLeast_Desktop_V4_5_2 { get; }


	internal static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

	private static bool RunningOnCheck(string propertyName) { }

	private static void .cctor() { }

}

internal class BinaryFacetsChecker : FacetsChecker // TypeDefIndex: 2255
{
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	public void .ctor() { }

}

internal class BinaryNode : ExpressionNode // TypeDefIndex: 4243
{	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28


	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	internal override void Bind(DataTable table, List<DataColumn> list) { }

	internal override object Eval() { }

	internal override object Eval(DataRow row, DataRowVersion version) { }

	internal override object Eval(int[] recordNos) { }

	internal override bool IsConstant() { }

	internal override bool IsTableConstant() { }

	internal override bool HasLocalAggregate() { }

	internal override bool HasRemoteAggregate() { }

	internal override bool DependsOn(DataColumn column) { }

	internal override ExpressionNode Optimize() { }

	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	private bool IsMixed(StorageType left, StorageType right) { }

	private bool IsMixedSql(StorageType left, StorageType right) { }

	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	private int SqlResultType(int typeCode) { }

}

private enum BinaryNode.DataTypePrecedence // TypeDefIndex: 4244
{	public int value__; // 0x0
	public const BinaryNode.DataTypePrecedence SqlDateTime = 25;
	public const BinaryNode.DataTypePrecedence DateTimeOffset = 24;
	public const BinaryNode.DataTypePrecedence DateTime = 23;
	public const BinaryNode.DataTypePrecedence TimeSpan = 20;
	public const BinaryNode.DataTypePrecedence SqlDouble = 19;
	public const BinaryNode.DataTypePrecedence Double = 18;
	public const BinaryNode.DataTypePrecedence SqlSingle = 17;
	public const BinaryNode.DataTypePrecedence Single = 16;
	public const BinaryNode.DataTypePrecedence SqlDecimal = 15;
	public const BinaryNode.DataTypePrecedence Decimal = 14;
	public const BinaryNode.DataTypePrecedence SqlMoney = 13;
	public const BinaryNode.DataTypePrecedence UInt64 = 12;
	public const BinaryNode.DataTypePrecedence SqlInt64 = 11;
	public const BinaryNode.DataTypePrecedence Int64 = 10;
	public const BinaryNode.DataTypePrecedence UInt32 = 9;
	public const BinaryNode.DataTypePrecedence SqlInt32 = 8;
	public const BinaryNode.DataTypePrecedence Int32 = 7;
	public const BinaryNode.DataTypePrecedence UInt16 = 6;
	public const BinaryNode.DataTypePrecedence SqlInt16 = 5;
	public const BinaryNode.DataTypePrecedence Int16 = 4;
	public const BinaryNode.DataTypePrecedence Byte = 3;
	public const BinaryNode.DataTypePrecedence SqlByte = 2;
	public const BinaryNode.DataTypePrecedence SByte = 1;
	public const BinaryNode.DataTypePrecedence Error = 0;
	public const BinaryNode.DataTypePrecedence SqlBoolean = -1;
	public const BinaryNode.DataTypePrecedence Boolean = -2;
	public const BinaryNode.DataTypePrecedence SqlGuid = -3;
	public const BinaryNode.DataTypePrecedence SqlString = -4;
	public const BinaryNode.DataTypePrecedence String = -5;
	public const BinaryNode.DataTypePrecedence SqlXml = -6;
	public const BinaryNode.DataTypePrecedence SqlChars = -7;
	public const BinaryNode.DataTypePrecedence Char = -8;
	public const BinaryNode.DataTypePrecedence SqlBytes = -9;
	public const BinaryNode.DataTypePrecedence SqlBinary = -10;

}

public class BinaryConverter : JsonConverter // TypeDefIndex: 6099
{
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public class BinaryConverter : JsonConverter // TypeDefIndex: 6099
	private ReflectionObject _reflectionObject; // 0x10


	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	private byte[] GetByteArray(object value) { }

	private void EnsureReflectionObject(Type t) { }

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	private byte[] ReadByteArray(JsonReader reader) { }

	public override bool CanConvert(Type objectType) { }

	public void .ctor() { }

}

public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 6104
{
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public override bool CanConvert(Type objectType) { }

	public void .ctor() { }

}

internal enum BsonBinaryType // TypeDefIndex: 6132
{	public byte value__; // 0x0
	public const BsonBinaryType Binary = 0;
	public const BsonBinaryType Function = 1;
	[ObsoleteAttribute] // RVA: 0x96ED0 Offset: 0x962D0 VA: 0x180096ED0
	public const BsonBinaryType BinaryOld = 2;
	[ObsoleteAttribute] // RVA: 0x97000 Offset: 0x96400 VA: 0x180097000
	public const BsonBinaryType UuidOld = 3;
	public const BsonBinaryType Uuid = 4;
	public const BsonBinaryType Md5 = 5;
	public const BsonBinaryType UserDefined = 128;

}

internal class BsonBinaryWriter // TypeDefIndex: 6133
{	private static readonly Encoding Encoding; // 0x2B0AAA0


	private static void .cctor() { }

}

public class BsonReader : JsonReader // TypeDefIndex: 6134
{	private static readonly byte[] SeqRange1; // 0x0
	private static readonly byte[] SeqRange2; // 0x8
	private static readonly byte[] SeqRange3; // 0x10
	private static readonly byte[] SeqRange4; // 0x18
	private readonly BinaryReader _reader; // 0x78
	private readonly List<BsonReader.ContainerContext> _stack; // 0x80
	private byte[] _byteBuffer; // 0x88
	private char[] _charBuffer; // 0x90
	private BsonType _currentElementType; // 0x98
	private BsonReader.BsonReaderState _bsonReaderState; // 0x9C
	private BsonReader.ContainerContext _currentContext; // 0xA0
	private bool _readRootValueAsArray; // 0xA8
	private bool _jsonNet35BinaryCompatibility; // 0xA9
	private DateTimeKind _dateTimeKindHandling; // 0xAC

	public DateTimeKind DateTimeKindHandling { get; }


	public DateTimeKind get_DateTimeKindHandling() { }

	private string ReadElement() { }

	public override bool Read() { }

	private bool ReadCodeWScope() { }

	private bool ReadReference() { }

	private bool ReadNormal() { }

	private void PopContext() { }

	private void PushContext(BsonReader.ContainerContext newContext) { }

	private byte ReadByte() { }

	private void ReadType(BsonType type) { }

	private byte[] ReadBinary(out BsonBinaryType binaryType) { }

	private string ReadString() { }

	private string ReadLengthString() { }

	private string GetString(int length) { }

	private int GetLastFullCharStop(int start) { }

	private int BytesInSequence(byte b) { }

	private void EnsureBuffers() { }

	private double ReadDouble() { }

	private int ReadInt32() { }

	private long ReadInt64() { }

	private BsonType ReadType() { }

	private void MovePosition(int count) { }

	private byte[] ReadBytes(int count) { }

	private static void .cctor() { }

}

private enum BsonReader.BsonReaderState // TypeDefIndex: 6135
{	public int value__; // 0x0
	public const BsonReader.BsonReaderState Normal = 0;
	public const BsonReader.BsonReaderState ReferenceStart = 1;
	public const BsonReader.BsonReaderState ReferenceRef = 2;
	public const BsonReader.BsonReaderState ReferenceId = 3;
	public const BsonReader.BsonReaderState CodeWScopeStart = 4;
	public const BsonReader.BsonReaderState CodeWScopeCode = 5;
	public const BsonReader.BsonReaderState CodeWScopeScope = 6;
	public const BsonReader.BsonReaderState CodeWScopeScopeObject = 7;
	public const BsonReader.BsonReaderState CodeWScopeScopeEnd = 8;

}

private class BsonReader.ContainerContext // TypeDefIndex: 6136
{	public readonly BsonType Type; // 0x10
	public int Length; // 0x14
	public int Position; // 0x18


	public void .ctor(BsonType type) { }

}

internal abstract class BsonToken // TypeDefIndex: 6137
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonToken <Parent>k__BackingField; // 0x10

	public abstract BsonType Type { get; }
	public BsonToken Parent { set; }


	public abstract BsonType get_Type();

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Parent(BsonToken value) { }

	protected void .ctor() { }

}

internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable // TypeDefIndex: 6138
{	private readonly List<BsonProperty> _children; // 0x18

	public override BsonType Type { get; }


	public void Add(string name, BsonToken token) { }

	public override BsonType get_Type() { }

	public IEnumerator<BsonProperty> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void .ctor() { }

}

internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable // TypeDefIndex: 6139
{	private readonly List<BsonToken> _children; // 0x18

	public override BsonType Type { get; }


	public void Add(BsonToken token) { }

	public override BsonType get_Type() { }

	public IEnumerator<BsonToken> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void .ctor() { }

}

internal class BsonValue : BsonToken // TypeDefIndex: 6140
{	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	public override BsonType Type { get; }


	public void .ctor(object value, BsonType type) { }

	public override BsonType get_Type() { }

}

internal class BsonString : BsonValue // TypeDefIndex: 6141
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IncludeLength>k__BackingField; // 0x28

	public bool IncludeLength { set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_IncludeLength(bool value) { }

	public void .ctor(object value, bool includeLength) { }

}

internal class BsonRegex : BsonToken // TypeDefIndex: 6143
{
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal class BsonRegex : BsonToken // TypeDefIndex: 6143
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonString <Pattern>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonString <Options>k__BackingField; // 0x20

	public BsonString Pattern { set; }
	public BsonString Options { set; }
	public override BsonType Type { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Pattern(BsonString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Options(BsonString value) { }

	public void .ctor(string pattern, string options) { }

	public override BsonType get_Type() { }

}

internal class BsonProperty // TypeDefIndex: 6144
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonString <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonToken <Value>k__BackingField; // 0x18

	public BsonString Name { set; }
	public BsonToken Value { set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Name(BsonString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Value(BsonToken value) { }

	public void .ctor() { }

}

internal enum BsonType // TypeDefIndex: 6145
{	public sbyte value__; // 0x0
	public const BsonType Number = 1;
	public const BsonType String = 2;
	public const BsonType Object = 3;
	public const BsonType Array = 4;
	public const BsonType Binary = 5;
	public const BsonType Undefined = 6;
	public const BsonType Oid = 7;
	public const BsonType Boolean = 8;
	public const BsonType Date = 9;
	public const BsonType Null = 10;
	public const BsonType Regex = 11;
	public const BsonType Reference = 12;
	public const BsonType Code = 13;
	public const BsonType Symbol = 14;
	public const BsonType CodeWScope = 15;
	public const BsonType Integer = 16;
	public const BsonType TimeStamp = 17;
	public const BsonType Long = 18;
	public const BsonType MinKey = -1;
	public const BsonType MaxKey = 127;

}

public class BsonWriter : JsonWriter // TypeDefIndex: 6146
{	private BsonToken _root; // 0x60
	private BsonToken _parent; // 0x68
	private string _propertyName; // 0x70


	private void AddValue(object value, BsonType type) { }

	internal void AddToken(BsonToken token) { }

	public void WriteObjectId(byte[] value) { }

	public void WriteRegex(string pattern, string options) { }

}

public class BsonObjectId // TypeDefIndex: 6147
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte[] <Value>k__BackingField; // 0x10

	public byte[] Value { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public byte[] get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Value(byte[] value) { }

	public void .ctor(byte[] value) { }

}

public static class BinaryReaderExtensions // TypeDefIndex: 6221
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Vector3 ReadVector3(BinaryReader o) { }

}

public static class BinaryWriterExtensions // TypeDefIndex: 6222
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void Write(BinaryWriter o, Vector3 vec) { }

}

public sealed class BinaryDataHandler : MulticastDelegate // TypeDefIndex: 6911
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(Span<byte> data) { }

	public virtual IAsyncResult BeginInvoke(Span<byte> data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class BinaryWriterEx : BinaryWriter // TypeDefIndex: 7297
{
	public void .ctor() { }

	public void .ctor(string fileName) { }

	public long Seek(long offset, SeekOrigin origin) { }

	public void WriteStruct(object theStruct) { }

	public void Write(int[] array) { }

	public void Write(float[] array) { }

}

