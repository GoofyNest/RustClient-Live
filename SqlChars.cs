public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 4342
{
	internal char[] _rgchBuf; 
	private long _lCurLen; 
	internal SqlStreamChars _stream; 
	private SqlBytesCharsState _state; 
	private char[] _rgchWorkBuf; 

public bool IsNull { get; }
public char[] Buffer { get; }
public long Length { get; }
public char[] Value { get; }
public static SqlChars Null { get; }


public void .ctor() { }

public void .ctor(char[] buffer) { }

public void .ctor(SqlString value) { }

public bool get_IsNull() { }

public char[] get_Buffer() { }

public long get_Length() { }

public char[] get_Value() { }

public void SetNull() { }

internal bool FStream() { }

private void CopyStreamToBuffer() { }

private void SetBuffer(char[] buffer) { }

private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

public static SqlChars get_Null() { }

}

