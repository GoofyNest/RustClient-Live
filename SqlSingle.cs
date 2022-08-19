public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4351
{	// Fields
	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Properties
	public bool IsNull { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x119720 Offset: 0x118B20 VA: 0x180119720
	private void .ctor(bool fNull) { }

	// RVA: 0x11AFC0 Offset: 0x11A3C0 VA: 0x18011AFC0
	public void .ctor(float value) { }

	// RVA: 0x11AFD0 Offset: 0x11A3D0 VA: 0x18011AFD0
	public void .ctor(double value) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11AFE0 Offset: 0x11A3E0 VA: 0x18011AFE0
	public float get_Value() { }

	// RVA: 0xCC3A00 Offset: 0xCC2E00 VA: 0x180CC3A00
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x11AFA0 Offset: 0x11A3A0 VA: 0x18011AFA0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC40C0 Offset: 0xCC34C0 VA: 0x180CC40C0
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0xCC3180 Offset: 0xCC2580 VA: 0x180CC3180
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC3FC0 Offset: 0xCC33C0 VA: 0x180CC3FC0
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC3EC0 Offset: 0xCC32C0 VA: 0x180CC3EC0
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC3280 Offset: 0xCC2680 VA: 0x180CC3280
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC3680 Offset: 0xCC2A80 VA: 0x180CC3680
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0xCC3BD0 Offset: 0xCC2FD0 VA: 0x180CC3BD0
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC37B0 Offset: 0xCC2BB0 VA: 0x180CC37B0
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC38E0 Offset: 0xCC2CE0 VA: 0x180CC38E0
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC3D00 Offset: 0xCC3100 VA: 0x180CC3D00
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0xCC3AB0 Offset: 0xCC2EB0 VA: 0x180CC3AB0
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0xCC34B0 Offset: 0xCC28B0 VA: 0x180CC34B0
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0xCC33E0 Offset: 0xCC27E0 VA: 0x180CC33E0
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC3E10 Offset: 0xCC3210 VA: 0x180CC3E10
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC35D0 Offset: 0xCC29D0 VA: 0x180CC35D0
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC2DE0 Offset: 0xCC21E0 VA: 0x180CC2DE0
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xCC2D70 Offset: 0xCC2170 VA: 0x180CC2D70
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x11AE90 Offset: 0x11A290 VA: 0x18011AE90
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x11A960 Offset: 0x119D60 VA: 0x18011A960 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x11A950 Offset: 0x119D50 VA: 0x18011A950
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x11AA60 Offset: 0x119E60 VA: 0x18011AA60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x11AC00 Offset: 0x11A000 VA: 0x18011AC00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x11AC90 Offset: 0x11A090 VA: 0x18011AC90 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x11ADB0 Offset: 0x11A1B0 VA: 0x18011ADB0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC2D10 Offset: 0xCC2110 VA: 0x180CC2D10
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC2F60 Offset: 0xCC2360 VA: 0x180CC2F60
	private static void .cctor() { }

}

