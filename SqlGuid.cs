public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4346
{
	private static readonly int s_sizeOfGuid; 
	private static readonly int[] s_rgiGuidOrder; 
	private byte[] m_value; 
	public static readonly SqlGuid Null; 

	public bool IsNull { get; }
	public Guid Value { get; }


	private void .ctor(bool fNull) { }

	public void .ctor(Guid g) { }

	public bool get_IsNull() { }

	public Guid get_Value() { }

	public static SqlGuid op_Implicit(Guid x) { }

	public override string ToString() { }

	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlGuid value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

