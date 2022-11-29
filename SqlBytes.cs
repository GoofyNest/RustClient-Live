public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 4346
{
	internal byte[] _rgbBuf; 
	private long _lCurLen; 
	internal Stream _stream; 
	private SqlBytesCharsState _state; 
	private byte[] _rgbWorkBuf; 

	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }


	public void .ctor() { }

	public void .ctor(byte[] buffer) { }

	public void .ctor(SqlBinary value) { }

	public bool get_IsNull() { }

	public byte[] get_Buffer() { }

	public long get_Length() { }

	public byte[] get_Value() { }

	public void SetNull() { }

	private void CopyStreamToBuffer() { }

	internal bool FStream() { }

	private void SetBuffer(byte[] buffer) { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public static SqlBytes get_Null() { }

}

