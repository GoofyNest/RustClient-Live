public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4346
{	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private byte[] m_value; // 0x0
	public static readonly SqlGuid Null; // 0x10

	// Properties
	public bool IsNull { get; }
	public Guid Value { get; }

	// Methods

	// RVA: 0x118690 Offset: 0x117A90 VA: 0x180118690
	private void .ctor(bool fNull) { }

	// RVA: 0x118650 Offset: 0x117A50 VA: 0x180118650
	public void .ctor(Guid g) { }

	// RVA: 0x1186B0 Offset: 0x117AB0 VA: 0x1801186B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1186C0 Offset: 0x117AC0 VA: 0x1801186C0
	public Guid get_Value() { }

	// RVA: 0xCBCE40 Offset: 0xCBC240 VA: 0x180CBCE40
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x118610 Offset: 0x117A10 VA: 0x180118610 Slot: 3
	public override string ToString() { }

	// RVA: 0xCBC7F0 Offset: 0xCBBBF0 VA: 0x180CBC7F0
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCBCCA0 Offset: 0xCBC0A0 VA: 0x180CBCCA0
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCBCE80 Offset: 0xCBC280 VA: 0x180CBCE80
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xCBCD70 Offset: 0xCBC170 VA: 0x180CBCD70
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x118090 Offset: 0x117490 VA: 0x180118090 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x118080 Offset: 0x117480 VA: 0x180118080
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x118190 Offset: 0x117590 VA: 0x180118190 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x118350 Offset: 0x117750 VA: 0x180118350 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1183F0 Offset: 0x1177F0 VA: 0x1801183F0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x118510 Offset: 0x117910 VA: 0x180118510 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCBCAC0 Offset: 0xCBBEC0 VA: 0x180CBCAC0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCBCB20 Offset: 0xCBBF20 VA: 0x180CBCB20
	private static void .cctor() { }

}

