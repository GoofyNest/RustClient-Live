public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4337
{	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x118690 Offset: 0x117A90 VA: 0x180118690
	private void .ctor(bool fNull) { }

	// RVA: 0x137C90 Offset: 0x137090 VA: 0x180137C90
	public void .ctor(byte[] value) { }

	// RVA: 0x1186B0 Offset: 0x117AB0 VA: 0x1801186B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x137D20 Offset: 0x137120 VA: 0x180137D20
	public byte[] get_Value() { }

	// RVA: 0xEAF6F0 Offset: 0xEAEAF0 VA: 0x180EAF6F0
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x137BE0 Offset: 0x136FE0 VA: 0x180137BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0xEAF290 Offset: 0xEAE690 VA: 0x180EAF290
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0xEAF530 Offset: 0xEAE930 VA: 0x180EAF530
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0xEAF780 Offset: 0xEAEB80 VA: 0x180EAF780
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xEAF610 Offset: 0xEAEA10 VA: 0x180EAF610
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1377D0 Offset: 0x136BD0 VA: 0x1801377D0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1377C0 Offset: 0x136BC0 VA: 0x1801377C0
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x1378D0 Offset: 0x136CD0 VA: 0x1801378D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xEAF220 Offset: 0xEAE620 VA: 0x180EAF220
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x1378E0 Offset: 0x136CE0 VA: 0x1801378E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1379D0 Offset: 0x136DD0 VA: 0x1801379D0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x137B10 Offset: 0x136F10 VA: 0x180137B10 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEAF1C0 Offset: 0xEAE5C0 VA: 0x180EAF1C0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEAF3A0 Offset: 0xEAE7A0 VA: 0x180EAF3A0
	private static void .cctor() { }

}

