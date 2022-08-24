public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4338
{
	private byte m_value; 
	public static readonly SqlBoolean True; 
	public static readonly SqlBoolean False; 
	public static readonly SqlBoolean Null; 
	public static readonly SqlBoolean Zero; 
	public static readonly SqlBoolean One; 

	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }


	public void .ctor(bool value) { }

	public void .ctor(int value) { }

	private void .ctor(int value, bool fNull) { }

	public bool get_IsNull() { }

	public bool get_Value() { }

	public bool get_IsTrue() { }

	public bool get_IsFalse() { }

	public static SqlBoolean op_Implicit(bool x) { }

	public static bool op_True(SqlBoolean x) { }

	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	public byte get_ByteValue() { }

	public override string ToString() { }

	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlBoolean value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

