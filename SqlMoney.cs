public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4350
{	// Fields
	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }

	// Methods

	// RVA: 0x117FC0 Offset: 0x1173C0 VA: 0x180117FC0
	private void .ctor(bool fNull) { }

	// RVA: 0x11A1B0 Offset: 0x1195B0 VA: 0x18011A1B0
	internal void .ctor(long value, int ignored) { }

	// RVA: 0x11A890 Offset: 0x119C90 VA: 0x18011A890
	public void .ctor(int value) { }

	// RVA: 0x11A8A0 Offset: 0x119CA0 VA: 0x18011A8A0
	public void .ctor(long value) { }

	// RVA: 0x11A8B0 Offset: 0x119CB0 VA: 0x18011A8B0
	public void .ctor(Decimal value) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x11A8D0 Offset: 0x119CD0 VA: 0x18011A8D0
	public Decimal get_Value() { }

	// RVA: 0x11A740 Offset: 0x119B40 VA: 0x18011A740
	public Decimal ToDecimal() { }

	// RVA: 0x11A760 Offset: 0x119B60 VA: 0x18011A760
	public double ToDouble() { }

	// RVA: 0xCC2530 Offset: 0xCC1930 VA: 0x180CC2530
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0xCC2360 Offset: 0xCC1760 VA: 0x180CC2360
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x11A820 Offset: 0x119C20 VA: 0x18011A820 Slot: 3
	public override string ToString() { }

	// RVA: 0xCC28B0 Offset: 0xCC1CB0 VA: 0x180CC28B0
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0xCC1D30 Offset: 0xCC1130 VA: 0x180CC1D30
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC2750 Offset: 0xCC1B50 VA: 0x180CC2750
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC2620 Offset: 0xCC1A20 VA: 0x180CC2620
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC1E90 Offset: 0xCC1290 VA: 0x180CC1E90
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC2200 Offset: 0xCC1600 VA: 0x180CC2200
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0xCC22A0 Offset: 0xCC16A0 VA: 0x180CC22A0
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0xCC23B0 Offset: 0xCC17B0 VA: 0x180CC23B0
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0xCC2470 Offset: 0xCC1870 VA: 0x180CC2470
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0xCC2080 Offset: 0xCC1480 VA: 0x180CC2080
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0xCC1FC0 Offset: 0xCC13C0 VA: 0x180CC1FC0
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC2560 Offset: 0xCC1960 VA: 0x180CC2560
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC2140 Offset: 0xCC1540 VA: 0x180CC2140
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC1310 Offset: 0xCC0710 VA: 0x180CC1310
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xCC1200 Offset: 0xCC0600 VA: 0x180CC1200
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x11A800 Offset: 0x119C00 VA: 0x18011A800
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x11A770 Offset: 0x119B70 VA: 0x18011A770
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x11A240 Offset: 0x119640 VA: 0x18011A240 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x11A220 Offset: 0x119620 VA: 0x18011A220
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x11A350 Offset: 0x119750 VA: 0x18011A350 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x11A4E0 Offset: 0x1198E0 VA: 0x18011A4E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x11A500 Offset: 0x119900 VA: 0x18011A500 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x11A650 Offset: 0x119A50 VA: 0x18011A650 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC11A0 Offset: 0xCC05A0 VA: 0x180CC11A0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC1810 Offset: 0xCC0C10 VA: 0x180CC1810
	private static void .cctor() { }

}

