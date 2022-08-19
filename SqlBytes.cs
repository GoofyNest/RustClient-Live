public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 4341
{	// Fields
	internal byte[] _rgbBuf; // 0x10
	private long _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private byte[] _rgbWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }

	// Methods

	// RVA: 0xEB1750 Offset: 0xEB0B50 VA: 0x180EB1750
	public void .ctor() { }

	// RVA: 0xEB1640 Offset: 0xEB0A40 VA: 0x180EB1640
	public void .ctor(byte[] buffer) { }

	// RVA: 0xEB16C0 Offset: 0xEB0AC0 VA: 0x180EB16C0
	public void .ctor(SqlBinary value) { }

	// RVA: 0xEB1900 Offset: 0xEB0D00 VA: 0x180EB1900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xEB1790 Offset: 0xEB0B90 VA: 0x180EB1790
	public byte[] get_Buffer() { }

	// RVA: 0xEB1910 Offset: 0xEB0D10 VA: 0x180EB1910
	public long get_Length() { }

	// RVA: 0xEB19F0 Offset: 0xEB0DF0 VA: 0x180EB19F0
	public byte[] get_Value() { }

	// RVA: 0xEB1180 Offset: 0xEB0580 VA: 0x180EB1180
	public void SetNull() { }

	// RVA: 0xEB0F30 Offset: 0xEB0330 VA: 0x180EB0F30
	private void CopyStreamToBuffer() { }

	// RVA: 0xEB10A0 Offset: 0xEB04A0 VA: 0x180EB10A0
	internal bool FStream() { }

	// RVA: 0xEB1110 Offset: 0xEB0510 VA: 0x180EB1110
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xEB1200 Offset: 0xEB0600 VA: 0x180EB1200 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xEB1390 Offset: 0xEB0790 VA: 0x180EB1390 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEB10B0 Offset: 0xEB04B0 VA: 0x180EB10B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEB11B0 Offset: 0xEB05B0 VA: 0x180EB11B0 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEB19A0 Offset: 0xEB0DA0 VA: 0x180EB19A0
	public static SqlBytes get_Null() { }

}

