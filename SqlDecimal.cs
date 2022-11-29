public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4349
{
	internal byte _bStatus; 
	internal byte _bLen; 
	internal byte _bPrec; 
	internal byte _bScale; 
	internal uint _data1; 
	internal uint _data2; 
	internal uint _data3; 
	internal uint _data4; 
	private static readonly byte s_NUMERIC_MAX_PRECISION; 
	public static readonly byte MaxPrecision; 
	public static readonly byte MaxScale; 
	private static readonly byte s_bNullMask; 
	private static readonly byte s_bIsNull; 
	private static readonly byte s_bNotNull; 
	private static readonly byte s_bReverseNullMask; 
	private static readonly byte s_bSignMask; 
	private static readonly byte s_bPositive; 
	private static readonly byte s_bNegative; 
	private static readonly byte s_bReverseSignMask; 
	private static readonly uint s_uiZero; 
	private static readonly int s_cNumeMax; 
	private static readonly long s_lInt32Base; 
	private static readonly ulong s_ulInt32Base; 
	private static readonly ulong s_ulInt32BaseForMod; 
	internal static readonly ulong s_llMax; 
	private static readonly uint s_ulBase10; 
	private static readonly double s_DUINT_BASE; 
	private static readonly double s_DUINT_BASE2; 
	private static readonly double s_DUINT_BASE3; 
	private static readonly double s_DMAX_NUME; 
	private static readonly uint s_DBL_DIG; 
	private static readonly byte s_cNumeDivScaleMin; 
	private static readonly uint[] s_rgulShiftBase; 
	private static readonly uint[] s_decimalHelpersLo; 
	private static readonly uint[] s_decimalHelpersMid; 
	private static readonly uint[] s_decimalHelpersHi; 
	private static readonly uint[] s_decimalHelpersHiHi; 
	private static readonly byte[] s_rgCLenFromPrec; 
	private static readonly uint s_ulT1; 
	private static readonly uint s_ulT2; 
	private static readonly uint s_ulT3; 
	private static readonly uint s_ulT4; 
	private static readonly uint s_ulT5; 
	private static readonly uint s_ulT6; 
	private static readonly uint s_ulT7; 
	private static readonly uint s_ulT8; 
	private static readonly uint s_ulT9; 
	private static readonly ulong s_dwlT10; 
	private static readonly ulong s_dwlT11; 
	private static readonly ulong s_dwlT12; 
	private static readonly ulong s_dwlT13; 
	private static readonly ulong s_dwlT14; 
	private static readonly ulong s_dwlT15; 
	private static readonly ulong s_dwlT16; 
	private static readonly ulong s_dwlT17; 
	private static readonly ulong s_dwlT18; 
	private static readonly ulong s_dwlT19; 
	public static readonly SqlDecimal Null; 
	public static readonly SqlDecimal MinValue; 
	public static readonly SqlDecimal MaxValue; 

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

