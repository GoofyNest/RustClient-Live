public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4353
{	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	public bool IsNull { get; }
	public string Value { get; }


	private void .ctor(bool fNull) { }

	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	public void .ctor(string data) { }

	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	public bool get_IsNull() { }

	public string get_Value() { }

	private void SetCompareInfo() { }

	public static SqlString op_Implicit(string x) { }

	public override string ToString() { }

	public static SqlString op_Addition(SqlString x, SqlString y) { }

	private static int StringCompare(SqlString x, SqlString y) { }

	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	private bool FBinarySort() { }

	private static int CompareBinary(SqlString x, SqlString y) { }

	private static int CompareBinary2(SqlString x, SqlString y) { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlString value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

