public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4358
{
	private string m_value; 
	private CompareInfo m_cmpInfo; 
	private int m_lcid; 
	private SqlCompareOptions m_flag; 
	private bool m_fNotNull; 
	public static readonly SqlString Null; 
	internal static readonly UnicodeEncoding s_unicodeEncoding; 
	public static readonly int IgnoreCase; 
	public static readonly int IgnoreWidth; 
	public static readonly int IgnoreNonSpace; 
	public static readonly int IgnoreKanaType; 
	public static readonly int BinarySort; 
	public static readonly int BinarySort2; 
	private static readonly SqlCompareOptions s_iDefaultFlag; 
	private static readonly CompareOptions s_iValidCompareOptionMask; 
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; 
	internal static readonly int s_lcidUSEnglish; 
	private static readonly int s_lcidBinary; 

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

