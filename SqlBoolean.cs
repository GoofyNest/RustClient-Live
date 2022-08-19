public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4338
{	// Fields
	private byte m_value; // 0x0
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Properties
	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }

	// Methods

	// RVA: 0x138360 Offset: 0x137760 VA: 0x180138360
	public void .ctor(bool value) { }

	// RVA: 0x138350 Offset: 0x137750 VA: 0x180138350
	public void .ctor(int value) { }

	// RVA: 0x138370 Offset: 0x137770 VA: 0x180138370
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x138410 Offset: 0x137810 VA: 0x180138410
	public bool get_Value() { }

	// RVA: 0x138400 Offset: 0x137800 VA: 0x180138400
	public bool get_IsTrue() { }

	// RVA: 0x1383F0 Offset: 0x1377F0 VA: 0x1801383F0
	public bool get_IsFalse() { }

	// RVA: 0xEB01E0 Offset: 0xEAF5E0 VA: 0x180EB01E0
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0xEB01F0 Offset: 0xEAF5F0 VA: 0x180EB01F0
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0xEAFF30 Offset: 0xEAF330 VA: 0x180EAFF30
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xEB0040 Offset: 0xEAF440 VA: 0x180EB0040
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x138390 Offset: 0x137790 VA: 0x180138390
	public byte get_ByteValue() { }

	// RVA: 0x1382A0 Offset: 0x1376A0 VA: 0x1801382A0 Slot: 3
	public override string ToString() { }

	// RVA: 0xEB0150 Offset: 0xEAF550 VA: 0x180EB0150
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xEAF860 Offset: 0xEAEC60 VA: 0x180EAF860
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xEAFCE0 Offset: 0xEAF0E0 VA: 0x180EAFCE0
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x137D90 Offset: 0x137190 VA: 0x180137D90 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x137E90 Offset: 0x137290 VA: 0x180137E90
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x137EA0 Offset: 0x1372A0 VA: 0x180137EA0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x138040 Offset: 0x137440 VA: 0x180138040 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1380D0 Offset: 0x1374D0 VA: 0x1801380D0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1381F0 Offset: 0x1375F0 VA: 0x1801381F0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEAFC80 Offset: 0xEAF080 VA: 0x180EAFC80
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEAFE10 Offset: 0xEAF210 VA: 0x180EAFE10
	private static void .cctor() { }

}

