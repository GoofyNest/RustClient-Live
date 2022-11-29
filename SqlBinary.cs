public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4342
{
	private byte[] _value; 
	public static readonly SqlBinary Null; 

	public bool IsNull { get; }
	public byte[] Value { get; }


	private void .ctor(bool fNull) { }

	public void .ctor(byte[] value) { }

	public bool get_IsNull() { }

	public byte[] get_Value() { }

	public static SqlBinary op_Implicit(byte[] x) { }

	public override string ToString() { }

	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlBinary value) { }

	public override bool Equals(object value) { }

	internal static int HashByteArray(byte[] rgbValue, int length) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

