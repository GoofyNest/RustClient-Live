public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<Decimal>, IEquatable<Decimal> // TypeDefIndex: 202
{	// Fields
	private const int SignMask = -2147483648;
	private const byte DECIMAL_NEG = 128;
	private const byte DECIMAL_ADD = 0;
	private const int ScaleMask = 16711680;
	private const int ScaleShift = 16;
	private const int MaxInt32Scale = 9;
	private static uint[] Powers10; // 0x0
	[DecimalConstantAttribute] // RVA: 0x761E0 Offset: 0x755E0 VA: 0x1800761E0
	public static readonly Decimal Zero; // 0x8
	[DecimalConstantAttribute] // RVA: 0x76240 Offset: 0x75640 VA: 0x180076240
	public static readonly Decimal One; // 0x18
	[DecimalConstantAttribute] // RVA: 0x763A0 Offset: 0x757A0 VA: 0x1800763A0
	public static readonly Decimal MinusOne; // 0x28
	[DecimalConstantAttribute] // RVA: 0x764D0 Offset: 0x758D0 VA: 0x1800764D0
	public static readonly Decimal MaxValue; // 0x38
	[DecimalConstantAttribute] // RVA: 0x76580 Offset: 0x75980 VA: 0x180076580
	public static readonly Decimal MinValue; // 0x48
	[DecimalConstantAttribute] // RVA: 0x766B0 Offset: 0x75AB0 VA: 0x1800766B0
	private static readonly Decimal NearNegativeZero; // 0x58
	[DecimalConstantAttribute] // RVA: 0x76850 Offset: 0x75C50 VA: 0x180076850
	private static readonly Decimal NearPositiveZero; // 0x68
	private int flags; // 0x0
	private int hi; // 0x4
	private int lo; // 0x8
	private int mid; // 0xC

	// Methods

	// RVA: 0x20DC10 Offset: 0x20D010 VA: 0x18020DC10
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x20DC00 Offset: 0x20D000 VA: 0x18020DC00
	public void .ctor(uint value) { }

	// RVA: 0x20DC90 Offset: 0x20D090 VA: 0x18020DC90
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x20DBE0 Offset: 0x20CFE0 VA: 0x18020DBE0
	public void .ctor(ulong value) { }

	// RVA: 0x20DC80 Offset: 0x20D080 VA: 0x18020DC80
	public void .ctor(float value) { }

	// RVA: 0x20DC40 Offset: 0x20D040 VA: 0x18020DC40
	public void .ctor(double value) { }

	// RVA: 0x20DAC0 Offset: 0x20CEC0 VA: 0x18020DAC0
	public void .ctor(int[] bits) { }

	// RVA: 0x20D460 Offset: 0x20C860 VA: 0x18020D460
	private void SetBits(int[] bits) { }

	// RVA: 0x20DC50 Offset: 0x20D050 VA: 0x18020DC50
	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x20D440 Offset: 0x20C840 VA: 0x18020D440
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x20D9F0 Offset: 0x20CDF0 VA: 0x18020D9F0 Slot: 23
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x20DC70 Offset: 0x20D070 VA: 0x18020DC70
	private void .ctor(int lo, int mid, int hi, int flags) { }

	// RVA: 0x17A2D90 Offset: 0x17A2190 VA: 0x1817A2D90
	public static Decimal Add(Decimal d1, Decimal d2) { }

	// RVA: 0x17A3160 Offset: 0x17A2560 VA: 0x1817A3160
	private static void FCallAddSub(ref Decimal d1, ref Decimal d2, byte bSign) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x17A2F60 Offset: 0x17A2360 VA: 0x1817A2F60
	public static int Compare(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x17A3170 Offset: 0x17A2570 VA: 0x1817A3170
	private static int FCallCompare(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x20D1A0 Offset: 0x20C5A0 VA: 0x18020D1A0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20D290 Offset: 0x20C690 VA: 0x18020D290 Slot: 24
	public int CompareTo(Decimal value) { }

	// RVA: 0x17A2FC0 Offset: 0x17A23C0 VA: 0x1817A2FC0
	public static Decimal Divide(Decimal d1, Decimal d2) { }

	// RVA: 0x17A3180 Offset: 0x17A2580 VA: 0x1817A3180
	private static void FCallDivide(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x20D360 Offset: 0x20C760 VA: 0x18020D360 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20D2F0 Offset: 0x20C6F0 VA: 0x18020D2F0 Slot: 25
	public bool Equals(Decimal value) { }

	// RVA: 0x20D420 Offset: 0x20C820 VA: 0x18020D420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20DA00 Offset: 0x20CE00 VA: 0x18020DA00 Slot: 3
	public override string ToString() { }

	// RVA: 0x20DA40 Offset: 0x20CE40 VA: 0x18020DA40 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x20DA80 Offset: 0x20CE80 VA: 0x18020DA80 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x17A35A0 Offset: 0x17A29A0 VA: 0x1817A35A0
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x17A35F0 Offset: 0x17A29F0 VA: 0x1817A35F0
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x17A46E0 Offset: 0x17A3AE0 VA: 0x1817A46E0
	public static bool TryParse(string s, out Decimal result) { }

	// RVA: 0x17A4680 Offset: 0x17A3A80 VA: 0x1817A4680
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x17A31E0 Offset: 0x17A25E0 VA: 0x1817A31E0
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x17A3B90 Offset: 0x17A2F90 VA: 0x1817A3B90
	internal static Decimal ToDecimal(byte[] buffer) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x17A32C0 Offset: 0x17A26C0 VA: 0x1817A32C0
	internal static Decimal Max(Decimal d1, Decimal d2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x17A3350 Offset: 0x17A2750 VA: 0x1817A3350
	internal static Decimal Min(Decimal d1, Decimal d2) { }

	// RVA: 0x17A33E0 Offset: 0x17A27E0 VA: 0x1817A33E0
	public static Decimal Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x17A3190 Offset: 0x17A2590 VA: 0x1817A3190
	private static void FCallMultiply(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x17A3460 Offset: 0x17A2860 VA: 0x1817A3460
	public static Decimal Negate(Decimal d) { }

	// RVA: 0x17A3660 Offset: 0x17A2A60 VA: 0x1817A3660
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x17A31A0 Offset: 0x17A25A0 VA: 0x1817A31A0
	private static void FCallRound(ref Decimal d, int decimals) { }

	// RVA: 0x17A3A80 Offset: 0x17A2E80 VA: 0x1817A3A80
	public static byte ToByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A4150 Offset: 0x17A3550 VA: 0x1817A4150
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x17A3E70 Offset: 0x17A3270 VA: 0x1817A3E70
	public static short ToInt16(Decimal value) { }

	// RVA: 0x17A3E50 Offset: 0x17A3250 VA: 0x1817A3E50
	public static double ToDouble(Decimal d) { }

	// RVA: 0x17A31B0 Offset: 0x17A25B0 VA: 0x1817A31B0
	internal static int FCallToInt32(Decimal d) { }

	// RVA: 0x17A3F80 Offset: 0x17A3380 VA: 0x1817A3F80
	public static int ToInt32(Decimal d) { }

	// RVA: 0x17A4060 Offset: 0x17A3460 VA: 0x1817A4060
	public static long ToInt64(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A4340 Offset: 0x17A3740 VA: 0x1817A4340
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A4450 Offset: 0x17A3850 VA: 0x1817A4450
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A4530 Offset: 0x17A3930 VA: 0x1817A4530
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x17A4260 Offset: 0x17A3660 VA: 0x1817A4260
	public static float ToSingle(Decimal d) { }

	// RVA: 0x17A4610 Offset: 0x17A3A10 VA: 0x1817A4610
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x17A31D0 Offset: 0x17A25D0 VA: 0x1817A31D0
	private static void FCallTruncate(ref Decimal d) { }

	// RVA: 0x17A5270 Offset: 0x17A4670 VA: 0x1817A5270
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A52E0 Offset: 0x17A46E0 VA: 0x1817A52E0
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x17A5310 Offset: 0x17A4710 VA: 0x1817A5310
	public static Decimal op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A5290 Offset: 0x17A4690 VA: 0x1817A5290
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x17A5290 Offset: 0x17A4690 VA: 0x1817A5290
	public static Decimal op_Implicit(char value) { }

	// RVA: 0x17A52B0 Offset: 0x17A46B0 VA: 0x1817A52B0
	public static Decimal op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A5240 Offset: 0x17A4640 VA: 0x1817A5240
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x17A5340 Offset: 0x17A4740 VA: 0x1817A5340
	public static Decimal op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A5250 Offset: 0x17A4650 VA: 0x1817A5250
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x17A4DD0 Offset: 0x17A41D0 VA: 0x1817A4DD0
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x17A4DB0 Offset: 0x17A41B0 VA: 0x1817A4DB0
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x17A4FE0 Offset: 0x17A43E0 VA: 0x1817A4FE0
	public static int op_Explicit(Decimal value) { }

	// RVA: 0x17A4EB0 Offset: 0x17A42B0 VA: 0x1817A4EB0
	public static long op_Explicit(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x17A5040 Offset: 0x17A4440 VA: 0x1817A5040
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x17A4E50 Offset: 0x17A4250 VA: 0x1817A4E50
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x17A4DF0 Offset: 0x17A41F0 VA: 0x1817A4DF0
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x17A56A0 Offset: 0x17A4AA0 VA: 0x1817A56A0
	public static Decimal op_UnaryNegation(Decimal d) { }

	// RVA: 0x17A5380 Offset: 0x17A4780 VA: 0x1817A5380
	public static Decimal op_Increment(Decimal d) { }

	// RVA: 0x17A4C40 Offset: 0x17A4040 VA: 0x1817A4C40
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x17A5620 Offset: 0x17A4A20 VA: 0x1817A5620
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x17A55A0 Offset: 0x17A49A0 VA: 0x1817A55A0
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x17A4CC0 Offset: 0x17A40C0 VA: 0x1817A4CC0
	public static Decimal op_Division(Decimal d1, Decimal d2) { }

	// RVA: 0x17A4D40 Offset: 0x17A4140 VA: 0x1817A4D40
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x17A5450 Offset: 0x17A4850 VA: 0x1817A5450
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x17A5530 Offset: 0x17A4930 VA: 0x1817A5530
	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	// RVA: 0x17A54C0 Offset: 0x17A48C0 VA: 0x1817A54C0
	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x17A51D0 Offset: 0x17A45D0 VA: 0x1817A51D0
	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	// RVA: 0x17A5160 Offset: 0x17A4560 VA: 0x1817A5160
	public static bool op_GreaterThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x20D430 Offset: 0x20C830 VA: 0x18020D430 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x20D470 Offset: 0x20C870 VA: 0x18020D470 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x20D550 Offset: 0x20C950 VA: 0x18020D550 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x20D730 Offset: 0x20CB30 VA: 0x18020D730 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x20D4E0 Offset: 0x20C8E0 VA: 0x18020D4E0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x20D5E0 Offset: 0x20C9E0 VA: 0x18020D5E0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x20D8A0 Offset: 0x20CCA0 VA: 0x18020D8A0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x20D650 Offset: 0x20CA50 VA: 0x18020D650 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x20D910 Offset: 0x20CD10 VA: 0x18020D910 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x20D6C0 Offset: 0x20CAC0 VA: 0x18020D6C0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x20D980 Offset: 0x20CD80 VA: 0x18020D980 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x20D7A0 Offset: 0x20CBA0 VA: 0x18020D7A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x20D570 Offset: 0x20C970 VA: 0x18020D570 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x20D560 Offset: 0x20C960 VA: 0x18020D560 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x20D810 Offset: 0x20CC10 VA: 0x18020D810 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17A4720 Offset: 0x17A3B20 VA: 0x1817A4720
	private static void .cctor() { }

}

