public class BinaryReader : IDisposable // TypeDefIndex: 616
{	// Fields
	private const int MaxCharBytesSize = 128;
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

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x1371D80 Offset: 0x1371180 VA: 0x181371D80
	public void .ctor(Stream input) { }

	// RVA: 0x1371B00 Offset: 0x1370F00 VA: 0x181371B00
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x1371B20 Offset: 0x1370F20 VA: 0x181371B20
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x13703D0 Offset: 0x136F7D0 VA: 0x1813703D0 Slot: 6
	public virtual void Close() { }

	// RVA: 0x13703F0 Offset: 0x136F7F0 VA: 0x1813703F0 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x13703D0 Offset: 0x136F7D0 VA: 0x1813703D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1371AD0 Offset: 0x1370ED0 VA: 0x181371AD0 Slot: 8
	public virtual int Read() { }

	// RVA: 0x1370C90 Offset: 0x1370090 VA: 0x181370C90 Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x1370CE0 Offset: 0x13700E0 VA: 0x181370CE0 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x13714C0 Offset: 0x13708C0 VA: 0x1813714C0 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x1370EC0 Offset: 0x13702C0 VA: 0x181370EC0 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x1371170 Offset: 0x1370570 VA: 0x181371170 Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1371170 Offset: 0x1370570 VA: 0x181371170 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x13711E0 Offset: 0x13705E0 VA: 0x1813711E0 Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1371860 Offset: 0x1370C60 VA: 0x181371860 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x1371350 Offset: 0x1370750 VA: 0x181371350 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1371350 Offset: 0x1370750 VA: 0x181371350 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x1371510 Offset: 0x1370910 VA: 0x181371510 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x1371130 Offset: 0x1370530 VA: 0x181371130 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x1371040 Offset: 0x1370440 VA: 0x181371040 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x1371550 Offset: 0x1370950 VA: 0x181371550 Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x13705F0 Offset: 0x136F9F0 VA: 0x1813705F0
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x1370920 Offset: 0x136FD20 VA: 0x181370920
	private int InternalReadOneChar() { }

	// RVA: 0x1370EF0 Offset: 0x13702F0 VA: 0x181370EF0 Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x1371910 Offset: 0x1370D10 VA: 0x181371910 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x1370D30 Offset: 0x1370130 VA: 0x181370D30 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x13704A0 Offset: 0x136F8A0 VA: 0x1813704A0 Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x1370BE0 Offset: 0x136FFE0 VA: 0x181370BE0
	protected internal int Read7BitEncodedInt() { }

}

public class BinaryWriter : IDisposable // TypeDefIndex: 617
{	// Fields
	public static readonly BinaryWriter Null; // 0x0
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

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x1373010 Offset: 0x1372410 VA: 0x181373010
	protected void .ctor() { }

	// RVA: 0x1372F90 Offset: 0x1372390 VA: 0x181372F90
	public void .ctor(Stream output) { }

	// RVA: 0x1372F70 Offset: 0x1372370 VA: 0x181372F70
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x1372DD0 Offset: 0x13721D0 VA: 0x181372DD0
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0xFDFAC0 Offset: 0xFDEEC0 VA: 0x180FDFAC0 Slot: 5
	public virtual void Close() { }

	// RVA: 0x1371E00 Offset: 0x1371200 VA: 0x181371E00 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xFDFAC0 Offset: 0xFDEEC0 VA: 0x180FDFAC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1373120 Offset: 0x1372520 VA: 0x181373120 Slot: 7
	public virtual Stream get_BaseStream() { }

	// RVA: 0xBC43E0 Offset: 0xBC37E0 VA: 0x180BC43E0 Slot: 8
	public virtual void Flush() { }

	// RVA: 0x1372320 Offset: 0x1371720 VA: 0x181372320 Slot: 9
	public virtual void Write(bool value) { }

	// RVA: 0x1313190 Offset: 0x1312590 VA: 0x181313190 Slot: 10
	public virtual void Write(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1313190 Offset: 0x1312590 VA: 0x181313190 Slot: 11
	public virtual void Write(sbyte value) { }

	// RVA: 0x1372BE0 Offset: 0x1371FE0 VA: 0x181372BE0 Slot: 12
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x1372BB0 Offset: 0x1371FB0 VA: 0x181372BB0 Slot: 13
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x1372A70 Offset: 0x1371E70 VA: 0x181372A70 Slot: 14
	public virtual void Write(char ch) { }

	// RVA: 0x13721B0 Offset: 0x13715B0 VA: 0x1813721B0 Slot: 15
	public virtual void Write(char[] chars) { }

	// RVA: 0x13722D0 Offset: 0x13716D0 VA: 0x1813722D0 Slot: 16
	public virtual void Write(double value) { }

	// RVA: 0x1371F60 Offset: 0x1371360 VA: 0x181371F60 Slot: 17
	public virtual void Write(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1371ED0 Offset: 0x13712D0 VA: 0x181371ED0 Slot: 18
	public virtual void Write(ushort value) { }

	// RVA: 0x1372390 Offset: 0x1371790 VA: 0x181372390 Slot: 19
	public virtual void Write(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1372640 Offset: 0x1371A40 VA: 0x181372640 Slot: 20
	public virtual void Write(uint value) { }

	// RVA: 0x1371FF0 Offset: 0x13713F0 VA: 0x181371FF0 Slot: 21
	public virtual void Write(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1372480 Offset: 0x1371880 VA: 0x181372480 Slot: 22
	public virtual void Write(ulong value) { }

	// RVA: 0x1372280 Offset: 0x1371680 VA: 0x181372280 Slot: 23
	public virtual void Write(float value) { }

	// RVA: 0x1372730 Offset: 0x1371B30 VA: 0x181372730 Slot: 24
	public virtual void Write(string value) { }

	// RVA: 0x1371E60 Offset: 0x1371260 VA: 0x181371E60
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x1372C80 Offset: 0x1372080 VA: 0x181372C80
	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1022
{	// Fields
	public static readonly bool TargetsAtLeast_Desktop_V4_5; // 0x0
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; // 0x1

	// Methods

	// RVA: 0x128CEB0 Offset: 0x128C2B0 VA: 0x18128CEB0
	private static void .cctor() { }

}

internal static class BinaryConverter // TypeDefIndex: 1068
{	// Methods

	// RVA: 0x11E7370 Offset: 0x11E6770 VA: 0x1811E7370
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x11E76F0 Offset: 0x11E6AF0 VA: 0x1811E76F0
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x11E8070 Offset: 0x11E7470 VA: 0x1811E8070
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x11E7990 Offset: 0x11E6D90 VA: 0x1811E7990
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x11E7B90 Offset: 0x11E6F90 VA: 0x1811E7B90
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }

}

internal sealed class BinaryAssemblyInfo // TypeDefIndex: 1070
{	// Fields
	internal string assemblyString; // 0x10
	private Assembly assembly; // 0x18

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(string assemblyString) { }

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(string assemblyString, Assembly assembly) { }

	// RVA: 0x11E7160 Offset: 0x11E6560 VA: 0x1811E7160
	internal Assembly GetAssembly() { }

}

internal sealed class BinaryAssembly // TypeDefIndex: 1072
{	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11E7300 Offset: 0x11E6700 VA: 0x1811E7300
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x11E7320 Offset: 0x11E6720 VA: 0x1811E7320 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11E7290 Offset: 0x11E6690 VA: 0x1811E7290 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainAssembly // TypeDefIndex: 1073
{	// Fields
	internal int assemId; // 0x10
	internal int assemblyIndex; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11E8270 Offset: 0x11E7670 VA: 0x1811E8270 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

internal sealed class BinaryObject // TypeDefIndex: 1074
{	// Fields
	internal int objectId; // 0x10
	internal int mapId; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11E9E00 Offset: 0x11E9200 VA: 0x1811E9E00
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x11E9E10 Offset: 0x11E9210 VA: 0x1811E9E10 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11E8270 Offset: 0x11E7670 VA: 0x1811E8270 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

internal sealed class BinaryMethodCall // TypeDefIndex: 1075
{	// Fields
	private string methodName; // 0x10
	private string typeName; // 0x18
	private object[] args; // 0x20
	private object callContext; // 0x28
	private Type[] argTypes; // 0x30
	private bool bArgsPrimitive; // 0x38
	private MessageEnum messageEnum; // 0x3C

	// Methods

	// RVA: 0x11E8DE0 Offset: 0x11E81E0 VA: 0x1811E8DE0
	internal void Write(__BinaryWriter sout) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void Dump() { }

	// RVA: 0x11E90B0 Offset: 0x11E84B0 VA: 0x1811E90B0
	public void .ctor() { }

}

internal sealed class BinaryMethodReturn // TypeDefIndex: 1076
{	// Fields
	private object returnValue; // 0x10
	private object[] args; // 0x18
	private object callContext; // 0x20
	private Type[] argTypes; // 0x28
	private bool bArgsPrimitive; // 0x30
	private MessageEnum messageEnum; // 0x34
	private Type returnType; // 0x38
	private static object instanceOfVoid; // 0x0

	// Methods

	// RVA: 0x11E9430 Offset: 0x11E8830 VA: 0x1811E9430
	private static void .cctor() { }

	// RVA: 0x11E94D0 Offset: 0x11E88D0 VA: 0x1811E94D0
	internal void .ctor() { }

	// RVA: 0x11E90C0 Offset: 0x11E84C0 VA: 0x1811E90C0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

internal sealed class BinaryObjectString // TypeDefIndex: 1077
{	// Fields
	internal int objectId; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11E7300 Offset: 0x11E6700 VA: 0x1811E7300
	internal void Set(int objectId, string value) { }

	// RVA: 0x11E94E0 Offset: 0x11E88E0 VA: 0x1811E94E0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11E7290 Offset: 0x11E6690 VA: 0x1811E7290 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainString // TypeDefIndex: 1078
{	// Fields
	internal int objectId; // 0x10
	internal int value; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11E8270 Offset: 0x11E7670 VA: 0x1811E8270 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainMap // TypeDefIndex: 1079
{	// Fields
	internal int crossAppDomainArrayIndex; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11E82D0 Offset: 0x11E76D0 VA: 0x1811E82D0 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

internal sealed class BinaryObjectWithMap // TypeDefIndex: 1081
{	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x11E9CE0 Offset: 0x11E90E0 VA: 0x1811E9CE0
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x11E9D40 Offset: 0x11E9140 VA: 0x1811E9D40 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11E9B30 Offset: 0x11E8F30 VA: 0x1811E9B30 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 1082
{	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x11E98D0 Offset: 0x11E8CD0 VA: 0x1811E98D0
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x11E9970 Offset: 0x11E8D70 VA: 0x1811E9970 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11E9530 Offset: 0x11E8930 VA: 0x1811E9530 Slot: 5
	public void Read(__BinaryParser input) { }

}

internal sealed class BinaryArray // TypeDefIndex: 1083
{	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11E7130 Offset: 0x11E6530 VA: 0x1811E7130
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x11E6DB0 Offset: 0x11E61B0 VA: 0x1811E6DB0
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x11E6E70 Offset: 0x11E6270 VA: 0x1811E6E70 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11E68D0 Offset: 0x11E5CD0 VA: 0x1811E68D0 Slot: 5
	public void Read(__BinaryParser input) { }

}

internal enum BinaryHeaderEnum // TypeDefIndex: 1091
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const BinaryArrayTypeEnum Single = 0;
	public const BinaryArrayTypeEnum Jagged = 1;
	public const BinaryArrayTypeEnum Rectangular = 2;
	public const BinaryArrayTypeEnum SingleOffset = 3;
	public const BinaryArrayTypeEnum JaggedOffset = 4;
	public const BinaryArrayTypeEnum RectangularOffset = 5;

}

public sealed class BinaryFormatter // TypeDefIndex: 1104
{	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0xD6ED70 Offset: 0xD6E170 VA: 0x180D6ED70
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x11E8D70 Offset: 0x11E8170 VA: 0x1811E8D70
	public void .ctor() { }

	// RVA: 0x11E8D10 Offset: 0x11E8110 VA: 0x1811E8D10
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x11E8310 Offset: 0x11E7710 VA: 0x1811E8310 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x11E8330 Offset: 0x11E7730 VA: 0x1811E8330
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x11E86D0 Offset: 0x11E7AD0 VA: 0x1811E86D0 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x11E8C90 Offset: 0x11E8090 VA: 0x1811E8C90 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x11E89D0 Offset: 0x11E7DD0 VA: 0x1811E89D0 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x11E89F0 Offset: 0x11E7DF0 VA: 0x1811E89F0
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x11E86F0 Offset: 0x11E7AF0 VA: 0x1811E86F0
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x11E8CB0 Offset: 0x11E80B0 VA: 0x1811E8CB0
	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1833
{	// Fields
	private static bool _targetsAtLeast_Desktop_V4_5_2; // 0x1347D

	// Properties
	internal static bool TargetsAtLeast_Desktop_V4_5_2 { get; }

	// Methods

	// RVA: 0x12DD1D0 Offset: 0x12DC5D0 VA: 0x1812DD1D0
	internal static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

	// RVA: 0x12DCFF0 Offset: 0x12DC3F0 VA: 0x1812DCFF0
	private static bool RunningOnCheck(string propertyName) { }

	// RVA: 0x12DD180 Offset: 0x12DC580 VA: 0x1812DD180
	private static void .cctor() { }

}

internal class BinaryFacetsChecker : FacetsChecker // TypeDefIndex: 2255
{	// Methods

	// RVA: 0xF412F0 Offset: 0xF406F0 VA: 0x180F412F0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xF41390 Offset: 0xF40790 VA: 0x180F41390 Slot: 14
	internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0xF41540 Offset: 0xF40940 VA: 0x180F41540 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xF41690 Offset: 0xF40A90 VA: 0x180F41690
	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

internal class BinaryNode : ExpressionNode // TypeDefIndex: 4243
{	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x126B630 Offset: 0x126AA30 VA: 0x18126B630
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x1265660 Offset: 0x1264A60 VA: 0x181265660 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCC8540 Offset: 0xCC7940 VA: 0x180CC8540 Slot: 6
	internal override object Eval() { }

	// RVA: 0x126A520 Offset: 0x1269920 VA: 0x18126A520 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x126A4A0 Offset: 0x12698A0 VA: 0x18126A4A0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x126A910 Offset: 0x1269D10 VA: 0x18126A910 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x126AA50 Offset: 0x1269E50 VA: 0x18126AA50 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x126A850 Offset: 0x1269C50 VA: 0x18126A850 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x126A8B0 Offset: 0x1269CB0 VA: 0x18126A8B0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x12656E0 Offset: 0x1264AE0 VA: 0x1812656E0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x126AAB0 Offset: 0x1269EB0 VA: 0x18126AAB0 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x126B4E0 Offset: 0x126A8E0 VA: 0x18126B4E0
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x126A4E0 Offset: 0x12698E0 VA: 0x18126A4E0
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x12648F0 Offset: 0x1263CF0 VA: 0x1812648F0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x1264920 Offset: 0x1263D20 VA: 0x181264920
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x1265750 Offset: 0x1264B50 VA: 0x181265750
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x126A6C0 Offset: 0x1269AC0 VA: 0x18126A6C0
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x126A550 Offset: 0x1269950 VA: 0x18126A550
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x126A9E0 Offset: 0x1269DE0 VA: 0x18126A9E0
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x126A970 Offset: 0x1269D70 VA: 0x18126A970
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x126B1C0 Offset: 0x126A5C0 VA: 0x18126B1C0
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x126ADA0 Offset: 0x126A1A0 VA: 0x18126ADA0
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x126B540 Offset: 0x126A940 VA: 0x18126B540
	private int SqlResultType(int typeCode) { }

}

private enum BinaryNode.DataTypePrecedence // TypeDefIndex: 4244
{	// Fields
	public int value__; // 0x0
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
// Namespace: Newtonsoft.Json.Converters
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public class BinaryConverter : JsonConverter // TypeDefIndex: 6099
	// Fields
	private ReflectionObject _reflectionObject; // 0x10

	// Methods

	// RVA: 0xF7FE00 Offset: 0xF7F200 VA: 0x180F7FE00 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF7F720 Offset: 0xF7EB20 VA: 0x180F7F720
	private byte[] GetByteArray(object value) { }

	// RVA: 0xF7F560 Offset: 0xF7E960 VA: 0x180F7F560
	private void EnsureReflectionObject(Type t) { }

	// RVA: 0xF7FA70 Offset: 0xF7EE70 VA: 0x180F7FA70 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF7F870 Offset: 0xF7EC70 VA: 0x180F7F870
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xF7F510 Offset: 0xF7E910 VA: 0x180F7F510 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 6104
{	// Methods

	// RVA: 0xF803E0 Offset: 0xF7F7E0 VA: 0x180F803E0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF801F0 Offset: 0xF7F5F0 VA: 0x180F801F0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF80180 Offset: 0xF7F580 VA: 0x180F80180 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal enum BsonBinaryType // TypeDefIndex: 6132
{	// Fields
	public byte value__; // 0x0
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
{	// Fields
	private static readonly Encoding Encoding; // 0x2B0AAA0

	// Methods

	// RVA: 0xF80120 Offset: 0xF7F520 VA: 0x180F80120
	private static void .cctor() { }

}

public class BsonReader : JsonReader // TypeDefIndex: 6134
{	// Fields
	private static readonly byte[] SeqRange1; // 0x0
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

	// Properties
	public DateTimeKind DateTimeKindHandling { get; }

	// Methods

	// RVA: 0xA2BC00 Offset: 0xA2B000 VA: 0x180A2BC00
	public DateTimeKind get_DateTimeKindHandling() { }

	// RVA: 0xF81650 Offset: 0xF80A50 VA: 0x180F81650
	private string ReadElement() { }

	// RVA: 0xF82A20 Offset: 0xF81E20 VA: 0x180F82A20 Slot: 10
	public override bool Read() { }

	// RVA: 0xF81240 Offset: 0xF80640 VA: 0x180F81240
	private bool ReadCodeWScope() { }

	// RVA: 0xF81AE0 Offset: 0xF80EE0 VA: 0x180F81AE0
	private bool ReadReference() { }

	// RVA: 0xF817B0 Offset: 0xF80BB0 VA: 0x180F817B0
	private bool ReadNormal() { }

	// RVA: 0xF80FA0 Offset: 0xF803A0 VA: 0x180F80FA0
	private void PopContext() { }

	// RVA: 0xF81050 Offset: 0xF80450 VA: 0x180F81050
	private void PushContext(BsonReader.ContainerContext newContext) { }

	// RVA: 0xF811C0 Offset: 0xF805C0 VA: 0x180F811C0
	private byte ReadByte() { }

	// RVA: 0xF821F0 Offset: 0xF815F0 VA: 0x180F821F0
	private void ReadType(BsonType type) { }

	// RVA: 0xF810C0 Offset: 0xF804C0 VA: 0x180F810C0
	private byte[] ReadBinary(out BsonBinaryType binaryType) { }

	// RVA: 0xF81EC0 Offset: 0xF812C0 VA: 0x180F81EC0
	private string ReadString() { }

	// RVA: 0xF81720 Offset: 0xF80B20 VA: 0x180F81720
	private string ReadLengthString() { }

	// RVA: 0xF80C80 Offset: 0xF80080 VA: 0x180F80C80
	private string GetString(int length) { }

	// RVA: 0xF80BF0 Offset: 0xF7FFF0 VA: 0x180F80BF0
	private int GetLastFullCharStop(int start) { }

	// RVA: 0xF80890 Offset: 0xF7FC90 VA: 0x180F80890
	private int BytesInSequence(byte b) { }

	// RVA: 0xF80B30 Offset: 0xF7FF30 VA: 0x180F80B30
	private void EnsureBuffers() { }

	// RVA: 0xF81610 Offset: 0xF80A10 VA: 0x180F81610
	private double ReadDouble() { }

	// RVA: 0xF816A0 Offset: 0xF80AA0 VA: 0x180F816A0
	private int ReadInt32() { }

	// RVA: 0xF816E0 Offset: 0xF80AE0 VA: 0x180F816E0
	private long ReadInt64() { }

	// RVA: 0xF821B0 Offset: 0xF815B0 VA: 0x180F821B0
	private BsonType ReadType() { }

	// RVA: 0xF80F80 Offset: 0xF80380 VA: 0x180F80F80
	private void MovePosition(int count) { }

	// RVA: 0xF81200 Offset: 0xF80600 VA: 0x180F81200
	private byte[] ReadBytes(int count) { }

	// RVA: 0xF82BC0 Offset: 0xF81FC0 VA: 0x180F82BC0
	private static void .cctor() { }

}

private enum BsonReader.BsonReaderState // TypeDefIndex: 6135
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public readonly BsonType Type; // 0x10
	public int Length; // 0x14
	public int Position; // 0x18

	// Methods

	// RVA: 0xF835B0 Offset: 0xF829B0 VA: 0x180F835B0
	public void .ctor(BsonType type) { }

}

internal abstract class BsonToken // TypeDefIndex: 6137
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonToken <Parent>k__BackingField; // 0x10

	// Properties
	public abstract BsonType Type { get; }
	public BsonToken Parent { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BsonType get_Type();

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Parent(BsonToken value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable // TypeDefIndex: 6138
{	// Fields
	private readonly List<BsonProperty> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF80690 Offset: 0xF7FA90 VA: 0x180F80690
	public void Add(string name, BsonToken token) { }

	// RVA: 0xF80880 Offset: 0xF7FC80 VA: 0x180F80880 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0xF80790 Offset: 0xF7FB90 VA: 0x180F80790 Slot: 5
	public IEnumerator<BsonProperty> GetEnumerator() { }

	// RVA: 0xF80790 Offset: 0xF7FB90 VA: 0x180F80790 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF80810 Offset: 0xF7FC10 VA: 0x180F80810
	public void .ctor() { }

}

internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable // TypeDefIndex: 6139
{	// Fields
	private readonly List<BsonToken> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF7FFB0 Offset: 0xF7F3B0 VA: 0x180F7FFB0
	public void Add(BsonToken token) { }

	// RVA: 0xF80110 Offset: 0xF7F510 VA: 0x180F80110 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0xF80020 Offset: 0xF7F420 VA: 0x180F80020 Slot: 5
	public IEnumerator<BsonToken> GetEnumerator() { }

	// RVA: 0xF80020 Offset: 0xF7F420 VA: 0x180F80020 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF800A0 Offset: 0xF7F4A0 VA: 0x180F800A0
	public void .ctor() { }

}

internal class BsonValue : BsonToken // TypeDefIndex: 6140
{	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF82ED0 Offset: 0xF822D0 VA: 0x180F82ED0
	public void .ctor(object value, BsonType type) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80 Slot: 4
	public override BsonType get_Type() { }

}

internal class BsonString : BsonValue // TypeDefIndex: 6141
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IncludeLength>k__BackingField; // 0x28

	// Properties
	public bool IncludeLength { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9775D0 Offset: 0x9769D0 VA: 0x1809775D0
	public void set_IncludeLength(bool value) { }

	// RVA: 0xF82E80 Offset: 0xF82280 VA: 0x180F82E80
	public void .ctor(object value, bool includeLength) { }

}

internal class BsonRegex : BsonToken // TypeDefIndex: 6143
{
// Namespace: Newtonsoft.Json.Bson
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
internal class BsonRegex : BsonToken // TypeDefIndex: 6143
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonString <Pattern>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonString <Options>k__BackingField; // 0x20

	// Properties
	public BsonString Pattern { set; }
	public BsonString Options { set; }
	public override BsonType Type { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Pattern(BsonString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Options(BsonString value) { }

	// RVA: 0xF82D90 Offset: 0xF82190 VA: 0x180F82D90
	public void .ctor(string pattern, string options) { }

	// RVA: 0xF82E70 Offset: 0xF82270 VA: 0x180F82E70 Slot: 4
	public override BsonType get_Type() { }

}

internal class BsonProperty // TypeDefIndex: 6144
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonString <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BsonToken <Value>k__BackingField; // 0x18

	// Properties
	public BsonString Name { set; }
	public BsonToken Value { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Name(BsonString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Value(BsonToken value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal enum BsonType // TypeDefIndex: 6145
{	// Fields
	public sbyte value__; // 0x0
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
{	// Fields
	private BsonToken _root; // 0x60
	private BsonToken _parent; // 0x68
	private string _propertyName; // 0x70

	// Methods

	// RVA: 0xF832D0 Offset: 0xF826D0 VA: 0x180F832D0
	private void AddValue(object value, BsonType type) { }

	// RVA: 0xF82F20 Offset: 0xF82320 VA: 0x180F82F20
	internal void AddToken(BsonToken token) { }

	// RVA: 0xF83360 Offset: 0xF82760 VA: 0x180F83360
	public void WriteObjectId(byte[] value) { }

	// RVA: 0xF83460 Offset: 0xF82860 VA: 0x180F83460
	public void WriteRegex(string pattern, string options) { }

}

public class BsonObjectId // TypeDefIndex: 6147
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte[] <Value>k__BackingField; // 0x10

	// Properties
	public byte[] Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public byte[] get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Value(byte[] value) { }

	// RVA: 0xF805E0 Offset: 0xF7F9E0 VA: 0x180F805E0
	public void .ctor(byte[] value) { }

}

public static class BinaryReaderExtensions // TypeDefIndex: 6221
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14E1D00 Offset: 0x14E1100 VA: 0x1814E1D00
	public static Vector3 ReadVector3(BinaryReader o) { }

}

public static class BinaryWriterExtensions // TypeDefIndex: 6222
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14E1DA0 Offset: 0x14E11A0 VA: 0x1814E1DA0
	public static void Write(BinaryWriter o, Vector3 vec) { }

}

public sealed class BinaryDataHandler : MulticastDelegate // TypeDefIndex: 6911
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A34400 Offset: 0x1A33800 VA: 0x181A34400 Slot: 12
	public virtual void Invoke(Span<byte> data) { }

	// RVA: 0x22000A0 Offset: 0x21FF4A0 VA: 0x1822000A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Span<byte> data, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class BinaryWriterEx : BinaryWriter // TypeDefIndex: 7297
{	// Methods

	// RVA: 0xB75730 Offset: 0xB74B30 VA: 0x180B75730
	public void .ctor() { }

	// RVA: 0xB756D0 Offset: 0xB74AD0 VA: 0x180B756D0
	public void .ctor(string fileName) { }

	// RVA: 0xB75150 Offset: 0xB74550 VA: 0x180B75150
	public long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xB751C0 Offset: 0xB745C0 VA: 0x180B751C0
	public void WriteStruct(object theStruct) { }

	// RVA: 0xB754C0 Offset: 0xB748C0 VA: 0x180B754C0
	public void Write(int[] array) { }

	// RVA: 0xB752B0 Offset: 0xB746B0 VA: 0x180B752B0
	public void Write(float[] array) { }

}

