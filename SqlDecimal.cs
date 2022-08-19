public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4344
{	// Fields
	internal byte _bStatus; // 0x0
	internal byte _bLen; // 0x1
	internal byte _bPrec; // 0x2
	internal byte _bScale; // 0x3
	internal uint _data1; // 0x4
	internal uint _data2; // 0x8
	internal uint _data3; // 0xC
	internal uint _data4; // 0x10
	private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly byte MaxPrecision; // 0x1
	public static readonly byte MaxScale; // 0x2
	private static readonly byte s_bNullMask; // 0x3
	private static readonly byte s_bIsNull; // 0x4
	private static readonly byte s_bNotNull; // 0x5
	private static readonly byte s_bReverseNullMask; // 0x6
	private static readonly byte s_bSignMask; // 0x7
	private static readonly byte s_bPositive; // 0x8
	private static readonly byte s_bNegative; // 0x9
	private static readonly byte s_bReverseSignMask; // 0xA
	private static readonly uint s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly long s_lInt32Base; // 0x18
	private static readonly ulong s_ulInt32Base; // 0x20
	private static readonly ulong s_ulInt32BaseForMod; // 0x28
	internal static readonly ulong s_llMax; // 0x30
	private static readonly uint s_ulBase10; // 0x38
	private static readonly double s_DUINT_BASE; // 0x40
	private static readonly double s_DUINT_BASE2; // 0x48
	private static readonly double s_DUINT_BASE3; // 0x50
	private static readonly double s_DMAX_NUME; // 0x58
	private static readonly uint s_DBL_DIG; // 0x60
	private static readonly byte s_cNumeDivScaleMin; // 0x64
	private static readonly uint[] s_rgulShiftBase; // 0x68
	private static readonly uint[] s_decimalHelpersLo; // 0x70
	private static readonly uint[] s_decimalHelpersMid; // 0x78
	private static readonly uint[] s_decimalHelpersHi; // 0x80
	private static readonly uint[] s_decimalHelpersHiHi; // 0x88
	private static readonly byte[] s_rgCLenFromPrec; // 0x90
	private static readonly uint s_ulT1; // 0x98
	private static readonly uint s_ulT2; // 0x9C
	private static readonly uint s_ulT3; // 0xA0
	private static readonly uint s_ulT4; // 0xA4
	private static readonly uint s_ulT5; // 0xA8
	private static readonly uint s_ulT6; // 0xAC
	private static readonly uint s_ulT7; // 0xB0
	private static readonly uint s_ulT8; // 0xB4
	private static readonly uint s_ulT9; // 0xB8
	private static readonly ulong s_dwlT10; // 0xC0
	private static readonly ulong s_dwlT11; // 0xC8
	private static readonly ulong s_dwlT12; // 0xD0
	private static readonly ulong s_dwlT13; // 0xD8
	private static readonly ulong s_dwlT14; // 0xE0
	private static readonly ulong s_dwlT15; // 0xE8
	private static readonly ulong s_dwlT16; // 0xF0
	private static readonly ulong s_dwlT17; // 0xF8
	private static readonly ulong s_dwlT18; // 0x100
	private static readonly ulong s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }

	// Methods

	// RVA: 0x139050 Offset: 0x138450 VA: 0x180139050
	private byte CalculatePrecision() { }

	// RVA: 0x1399E0 Offset: 0x138DE0 VA: 0x1801399E0
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x139A50 Offset: 0x138E50 VA: 0x180139A50
	private void .ctor(bool fNull) { }

	// RVA: 0x139A10 Offset: 0x138E10 VA: 0x180139A10
	public void .ctor(Decimal value) { }

	// RVA: 0x139A40 Offset: 0x138E40 VA: 0x180139A40
	public void .ctor(int value) { }

	// RVA: 0x139A30 Offset: 0x138E30 VA: 0x180139A30
	public void .ctor(long value) { }

	// RVA: 0x1399F0 Offset: 0x138DF0 VA: 0x1801399F0
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x139A70 Offset: 0x138E70 VA: 0x180139A70 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x139BB0 Offset: 0x138FB0 VA: 0x180139BB0
	public Decimal get_Value() { }

	// RVA: 0x139AE0 Offset: 0x138EE0 VA: 0x180139AE0
	public bool get_IsPositive() { }

	// RVA: 0x139480 Offset: 0x138880 VA: 0x180139480
	private void SetPositive() { }

	// RVA: 0x139490 Offset: 0x138890 VA: 0x180139490
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x139AF0 Offset: 0x138EF0 VA: 0x180139AF0
	public byte get_Scale() { }

	// RVA: 0x139A60 Offset: 0x138E60 VA: 0x180139A60
	public int[] get_Data() { }

	// RVA: 0x1399D0 Offset: 0x138DD0 VA: 0x1801399D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xEB74B0 Offset: 0xEB68B0 VA: 0x180EB74B0
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x139810 Offset: 0x138C10 VA: 0x180139810
	public double ToDouble() { }

	// RVA: 0x1397F0 Offset: 0x138BF0 VA: 0x1801397F0
	private Decimal ToDecimal() { }

	// RVA: 0xEBAFA0 Offset: 0xEBA3A0 VA: 0x180EBAFA0
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0xEBB180 Offset: 0xEBA580 VA: 0x180EBB180
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0xEBC480 Offset: 0xEBB880 VA: 0x180EBC480
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0xEB9C40 Offset: 0xEB9040 VA: 0x180EB9C40
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEBC1B0 Offset: 0xEBB5B0 VA: 0x180EBC1B0
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEBB3F0 Offset: 0xEBA7F0 VA: 0x180EBB3F0
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEBA4A0 Offset: 0xEB98A0 VA: 0x180EBA4A0
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEBB0B0 Offset: 0xEBA4B0 VA: 0x180EBB0B0
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0xEBAE40 Offset: 0xEBA240 VA: 0x180EBAE40
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0xEBAEF0 Offset: 0xEBA2F0 VA: 0x180EBAEF0
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0xEBB1D0 Offset: 0xEBA5D0 VA: 0x180EBB1D0
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0xEBAFE0 Offset: 0xEBA3E0 VA: 0x180EBAFE0
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0xEB8AC0 Offset: 0xEB7EC0 VA: 0x180EB8AC0
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x1392A0 Offset: 0x1386A0 VA: 0x1801392A0
	private bool FZero() { }

	// RVA: 0x139200 Offset: 0x138600 VA: 0x180139200
	private bool FGt10_38() { }

	// RVA: 0x139240 Offset: 0x138640 VA: 0x180139240
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0xEB4680 Offset: 0xEB3A80 VA: 0x180EB4680
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0xEB4870 Offset: 0xEB3C70 VA: 0x180EB4870
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x139030 Offset: 0x138430 VA: 0x180139030
	private void AddULong(uint ulAdd) { }

	// RVA: 0x139470 Offset: 0x138870 VA: 0x180139470
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x1391E0 Offset: 0x1385E0 VA: 0x1801391E0
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x139040 Offset: 0x138440 VA: 0x180139040
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x139440 Offset: 0x138840 VA: 0x180139440
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0xEB6F70 Offset: 0xEB6370 VA: 0x180EB6F70
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0xEB7150 Offset: 0xEB6550 VA: 0x180EB7150
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0xEB7100 Offset: 0xEB6500 VA: 0x180EB7100
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0xEB6FE0 Offset: 0xEB63E0 VA: 0x180EB6FE0
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0xEB5E20 Offset: 0xEB5220 VA: 0x180EB5E20
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0xEB5440 Offset: 0xEB4840 VA: 0x180EB5440
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0xEB5B50 Offset: 0xEB4F50 VA: 0x180EB5B50
	private static uint HI(ulong x) { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	private static uint LO(ulong x) { }

	// RVA: 0xEB5F50 Offset: 0xEB5350 VA: 0x180EB5F50
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x139060 Offset: 0x138460 VA: 0x180139060
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0xEB4F60 Offset: 0xEB4360 VA: 0x180EB4F60
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0xEBAB80 Offset: 0xEB9F80 VA: 0x180EBAB80
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEBB290 Offset: 0xEBA690 VA: 0x180EBB290
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEBACE0 Offset: 0xEBA0E0 VA: 0x180EBACE0
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEB5D90 Offset: 0xEB5190 VA: 0x180EB5D90
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xEB5AC0 Offset: 0xEB4EC0 VA: 0x180EB5AC0
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x139820 Offset: 0x138C20 VA: 0x180139820
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1398B0 Offset: 0x138CB0 VA: 0x1801398B0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x139940 Offset: 0x138D40 VA: 0x180139940
	public SqlMoney ToSqlMoney() { }

	// RVA: 0xEB4F50 Offset: 0xEB4350 VA: 0x180EB4F50
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1394B0 Offset: 0x1388B0 VA: 0x1801394B0
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x1394A0 Offset: 0x1388A0 VA: 0x1801394A0
	private void SetToZero() { }

	// RVA: 0x139090 Offset: 0x138490 VA: 0x180139090 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1391B0 Offset: 0x1385B0 VA: 0x1801391B0
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x1391F0 Offset: 0x1385F0 VA: 0x1801391F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1392C0 Offset: 0x1386C0 VA: 0x1801392C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x139540 Offset: 0x138940 VA: 0x180139540 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1396E0 Offset: 0x138AE0 VA: 0x1801396E0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEB5A60 Offset: 0xEB4E60 VA: 0x180EB5A60
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEB8B50 Offset: 0xEB7F50 VA: 0x180EB8B50
	private static void .cctor() { }

}

