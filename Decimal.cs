public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<Decimal>, IEquatable<Decimal> // TypeDefIndex: 202
{
	private const int SignMask = -2147483648;
	private const byte DECIMAL_NEG = 128;
	private const byte DECIMAL_ADD = 0;
	private const int ScaleMask = 16711680;
	private const int ScaleShift = 16;
	private const int MaxInt32Scale = 9;
	private static uint[] Powers10; 
	[DecimalConstantAttribute] 
	public static readonly Decimal Zero; 
	[DecimalConstantAttribute] 
	public static readonly Decimal One; 
	[DecimalConstantAttribute] 
	public static readonly Decimal MinusOne; 
	[DecimalConstantAttribute] 
	public static readonly Decimal MaxValue; 
	[DecimalConstantAttribute] 
	public static readonly Decimal MinValue; 
	[DecimalConstantAttribute] 
	private static readonly Decimal NearNegativeZero; 
	[DecimalConstantAttribute] 
	private static readonly Decimal NearPositiveZero; 
	private int flags; 
	private int hi; 
	private int lo; 
	private int mid; 


	public void .ctor(int value) { }

	[CLSCompliantAttribute] 
	public void .ctor(uint value) { }

	public void .ctor(long value) { }

	[CLSCompliantAttribute] 
	public void .ctor(ulong value) { }

	public void .ctor(float value) { }

	public void .ctor(double value) { }

	public void .ctor(int[] bits) { }

	private void SetBits(int[] bits) { }

	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[OnSerializingAttribute] 
	private void OnSerializing(StreamingContext ctx) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void .ctor(int lo, int mid, int hi, int flags) { }

	public static Decimal Add(Decimal d1, Decimal d2) { }

	private static void FCallAddSub(ref Decimal d1, ref Decimal d2, byte bSign) { }

	[ReliabilityContractAttribute] 
	public static int Compare(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] 
	private static int FCallCompare(ref Decimal d1, ref Decimal d2) { }

	public int CompareTo(object value) { }

	public int CompareTo(Decimal value) { }

	public static Decimal Divide(Decimal d1, Decimal d2) { }

	private static void FCallDivide(ref Decimal d1, ref Decimal d2) { }

	public override bool Equals(object value) { }

	public bool Equals(Decimal value) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format, IFormatProvider provider) { }

	public static Decimal Parse(string s, IFormatProvider provider) { }

	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	public static bool TryParse(string s, out Decimal result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	public static int[] GetBits(Decimal d) { }

	internal static Decimal ToDecimal(byte[] buffer) { }

	[ReliabilityContractAttribute] 
	internal static Decimal Max(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] 
	internal static Decimal Min(Decimal d1, Decimal d2) { }

	public static Decimal Multiply(Decimal d1, Decimal d2) { }

	private static void FCallMultiply(ref Decimal d1, ref Decimal d2) { }

	public static Decimal Negate(Decimal d) { }

	public static Decimal Round(Decimal d, int decimals) { }

	private static void FCallRound(ref Decimal d, int decimals) { }

	public static byte ToByte(Decimal value) { }

	[CLSCompliantAttribute] 
	public static sbyte ToSByte(Decimal value) { }

	public static short ToInt16(Decimal value) { }

	public static double ToDouble(Decimal d) { }

	internal static int FCallToInt32(Decimal d) { }

	public static int ToInt32(Decimal d) { }

	public static long ToInt64(Decimal d) { }

	[CLSCompliantAttribute] 
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] 
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliantAttribute] 
	public static ulong ToUInt64(Decimal d) { }

	public static float ToSingle(Decimal d) { }

	public static Decimal Truncate(Decimal d) { }

	private static void FCallTruncate(ref Decimal d) { }

	public static Decimal op_Implicit(byte value) { }

	[CLSCompliantAttribute] 
	public static Decimal op_Implicit(sbyte value) { }

	public static Decimal op_Implicit(short value) { }

	[CLSCompliantAttribute] 
	public static Decimal op_Implicit(ushort value) { }

	public static Decimal op_Implicit(char value) { }

	public static Decimal op_Implicit(int value) { }

	[CLSCompliantAttribute] 
	public static Decimal op_Implicit(uint value) { }

	public static Decimal op_Implicit(long value) { }

	[CLSCompliantAttribute] 
	public static Decimal op_Implicit(ulong value) { }

	public static Decimal op_Explicit(float value) { }

	public static Decimal op_Explicit(double value) { }

	public static int op_Explicit(Decimal value) { }

	public static long op_Explicit(Decimal value) { }

	[CLSCompliantAttribute] 
	public static ulong op_Explicit(Decimal value) { }

	public static float op_Explicit(Decimal value) { }

	public static double op_Explicit(Decimal value) { }

	public static Decimal op_UnaryNegation(Decimal d) { }

	public static Decimal op_Increment(Decimal d) { }

	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	public static Decimal op_Division(Decimal d1, Decimal d2) { }

	public static bool op_Equality(Decimal d1, Decimal d2) { }

	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	public static bool op_GreaterThanOrEqual(Decimal d1, Decimal d2) { }

	public TypeCode GetTypeCode() { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	private static void .cctor() { }

}

