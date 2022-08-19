public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 4342
{	// Fields
	internal char[] _rgchBuf; // 0x10
	private long _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private char[] _rgchWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public char[] Buffer { get; }
	public long Length { get; }
	public char[] Value { get; }
	public static SqlChars Null { get; }

	// Methods

	// RVA: 0xEB1750 Offset: 0xEB0B50 VA: 0x180EB1750
	public void .ctor() { }

	// RVA: 0xEB1640 Offset: 0xEB0A40 VA: 0x180EB1640
	public void .ctor(char[] buffer) { }

	// RVA: 0xEB21E0 Offset: 0xEB15E0 VA: 0x180EB21E0
	public void .ctor(SqlString value) { }

	// RVA: 0xEB1900 Offset: 0xEB0D00 VA: 0x180EB1900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xEB2240 Offset: 0xEB1640 VA: 0x180EB2240
	public char[] get_Buffer() { }

	// RVA: 0xEB23B0 Offset: 0xEB17B0 VA: 0x180EB23B0
	public long get_Length() { }

	// RVA: 0xEB2490 Offset: 0xEB1890 VA: 0x180EB2490
	public char[] get_Value() { }

	// RVA: 0xEB1180 Offset: 0xEB0580 VA: 0x180EB1180
	public void SetNull() { }

	// RVA: 0xEB10A0 Offset: 0xEB04A0 VA: 0x180EB10A0
	internal bool FStream() { }

	// RVA: 0xEB1BE0 Offset: 0xEB0FE0 VA: 0x180EB1BE0
	private void CopyStreamToBuffer() { }

	// RVA: 0xEB1110 Offset: 0xEB0510 VA: 0x180EB1110
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xEB1E00 Offset: 0xEB1200 VA: 0x180EB1E00 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xEB1F50 Offset: 0xEB1350 VA: 0x180EB1F50 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEB1D50 Offset: 0xEB1150 VA: 0x180EB1D50
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEB1DB0 Offset: 0xEB11B0 VA: 0x180EB1DB0 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEB2440 Offset: 0xEB1840 VA: 0x180EB2440
	public static SqlChars get_Null() { }

}

