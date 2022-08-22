public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4344
{	internal byte _bStatus; // 0x0
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

	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }


	private byte CalculatePrecision() { }

	private bool VerifyPrecision(byte precision) { }

	private void .ctor(bool fNull) { }

	public void .ctor(Decimal value) { }

	public void .ctor(int value) { }

	public void .ctor(long value) { }

	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	public bool get_IsNull() { }

	public Decimal get_Value() { }

	public bool get_IsPositive() { }

	private void SetPositive() { }

	private void SetSignBit(bool fPositive) { }

	public byte get_Scale() { }

	public int[] get_Data() { }

	public override string ToString() { }

	public static SqlDecimal Parse(string s) { }

	public double ToDouble() { }

	private Decimal ToDecimal() { }

	public static SqlDecimal op_Implicit(Decimal x) { }

	public static SqlDecimal op_Implicit(long x) { }

	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	public static SqlDecimal op_Implicit(SqlByte x) { }

	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	public static SqlDecimal op_Implicit(SqlMoney x) { }

	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	private bool FZero() { }

	private bool FGt10_38() { }

	private bool FGt10_38(uint[] rglData) { }

	private static byte BGetPrecUI4(uint value) { }

	private static byte BGetPrecUI8(ulong dwlVal) { }

	private void AddULong(uint ulAdd) { }

	private void MultByULong(uint uiMultiplier) { }

	private uint DivByULong(uint iDivisor) { }

	internal void AdjustScale(int digits, bool fRound) { }

	private int LAbsCmp(SqlDecimal snumOp) { }

	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	internal static ulong DWL(uint lo, uint hi) { }

	private static uint HI(ulong x) { }

	private static uint LO(ulong x) { }

	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	private EComparison CompareNm(SqlDecimal snumOp) { }

	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	public SqlDouble ToSqlDouble() { }

	public SqlInt64 ToSqlInt64() { }

	public SqlMoney ToSqlMoney() { }

	private static char ChFromDigit(uint uiDigit) { }

	private void StoreFromWorkingArray(uint[] rguiData) { }

	private void SetToZero() { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlDecimal value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

