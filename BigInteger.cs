internal class BigInteger // TypeDefIndex: 80
{	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	private static RandomNumberGenerator Rng { get; }


	public void .ctor(BigInteger.Sign sign, uint len) { }

	public void .ctor(BigInteger bi) { }

	public void .ctor(BigInteger bi, uint len) { }

	public void .ctor(byte[] inData) { }

	public void .ctor(uint ui) { }

	public static BigInteger op_Implicit(uint value) { }

	public static BigInteger op_Implicit(int value) { }

	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	public static uint op_Modulus(BigInteger bi, uint ui) { }

	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	private static RandomNumberGenerator get_Rng() { }

	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	public static BigInteger GenerateRandom(int bits) { }

	public void Randomize(RandomNumberGenerator rng) { }

	public void Randomize() { }

	public int BitCount() { }

	public bool TestBit(uint bitNum) { }

	public bool TestBit(int bitNum) { }

	public void SetBit(uint bitNum) { }

	public void SetBit(uint bitNum, bool value) { }

	public int LowestSetBit() { }

	public byte[] GetBytes() { }

	public static bool op_Equality(BigInteger bi1, uint ui) { }

	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	public string ToString(uint radix) { }

	public string ToString(uint radix, string characterSet) { }

	private void Normalize() { }

	public void Clear() { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public override bool Equals(object o) { }

	public BigInteger ModInverse(BigInteger modulus) { }

	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	public bool IsProbablePrime() { }

	public static BigInteger GeneratePseudoPrime(int bits) { }

	public void Incr2() { }

	private static void .cctor() { }

}

public enum BigInteger.Sign // TypeDefIndex: 81
{	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;

}

internal sealed class BigInteger.ModulusRing // TypeDefIndex: 82
{	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18


	public void .ctor(BigInteger modulus) { }

	public void BarrettReduction(BigInteger x) { }

	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	public BigInteger Difference(BigInteger a, BigInteger b) { }

	public BigInteger Pow(BigInteger a, BigInteger k) { }

	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 83
{
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	public static void MinusEq(BigInteger big, BigInteger small) { }

	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	public static uint DwordMod(BigInteger n, uint d) { }

	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger LeftShift(BigInteger bi, int n) { }

	public static BigInteger RightShift(BigInteger bi, int n) { }

	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	public static uint modInverse(BigInteger bi, uint modulus) { }

	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

}

public class BigInteger // TypeDefIndex: 1763
{	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	private static RandomNumberGenerator Rng { get; }


	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(BigInteger.Sign sign, uint len) { }

	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(BigInteger bi, uint len) { }

	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static BigInteger op_Implicit(uint value) { }

	public static BigInteger op_Implicit(int value) { }

	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	private static RandomNumberGenerator get_Rng() { }

	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	public static BigInteger GenerateRandom(int bits) { }

	public int BitCount() { }

	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void SetBit(uint bitNum, bool value) { }

	public int LowestSetBit() { }

	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public string ToString(uint radix, string characterSet) { }

	private void Normalize() { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public override bool Equals(object o) { }

	public BigInteger ModInverse(BigInteger modulus) { }

	public static BigInteger GeneratePseudoPrime(int bits) { }

	public void Incr2() { }

	private static void .cctor() { }

}

public enum BigInteger.Sign // TypeDefIndex: 1764
{	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;

}

public sealed class BigInteger.ModulusRing // TypeDefIndex: 1765
{	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18


	public void .ctor(BigInteger modulus) { }

	public void BarrettReduction(BigInteger x) { }

	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	public BigInteger Difference(BigInteger a, BigInteger b) { }

	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 1766
{
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	public static void MinusEq(BigInteger big, BigInteger small) { }

	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	public static uint DwordMod(BigInteger n, uint d) { }

	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	public static BigInteger LeftShift(BigInteger bi, int n) { }

	public static BigInteger RightShift(BigInteger bi, int n) { }

	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	public static uint modInverse(BigInteger bi, uint modulus) { }

	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

}

public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3963
{	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	public static BigInteger Zero { get; }
	public bool IsZero { get; }


	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(uint value) { }

	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(byte[] value) { }

	public void .ctor(ReadOnlySpan<byte> value) { }

	internal void .ctor(int n, uint[] rgu) { }

	internal void .ctor(uint[] value, bool negative) { }

	public static BigInteger get_Zero() { }

	public bool get_IsZero() { }

	public static BigInteger Parse(string value, IFormatProvider provider) { }

	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(long other) { }

	public bool Equals(BigInteger other) { }

	public int CompareTo(long other) { }

	public int CompareTo(BigInteger other) { }

	public int CompareTo(object obj) { }

	public byte[] ToByteArray() { }

	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider provider) { }

	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static BigInteger op_Implicit(sbyte value) { }

	public static BigInteger op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static BigInteger op_Implicit(ushort value) { }

	public static BigInteger op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static BigInteger op_Implicit(uint value) { }

	public static BigInteger op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static BigInteger op_Implicit(ulong value) { }

	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static sbyte op_Explicit(BigInteger value) { }

	public static short op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static ushort op_Explicit(BigInteger value) { }

	public static int op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static uint op_Explicit(BigInteger value) { }

	public static long op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static ulong op_Explicit(BigInteger value) { }

	public static float op_Explicit(BigInteger value) { }

	public static double op_Explicit(BigInteger value) { }

	public static Decimal op_Explicit(BigInteger value) { }

	public static BigInteger op_UnaryNegation(BigInteger value) { }

	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	public static bool op_LessThan(BigInteger left, long right) { }

	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	public static bool op_Equality(BigInteger left, long right) { }

	public static bool op_Inequality(BigInteger left, long right) { }

	public static bool op_LessThan(long left, BigInteger right) { }

	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	private static void .cctor() { }

}

private enum BigInteger.GetBytesMode // TypeDefIndex: 3964
{	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;

}

