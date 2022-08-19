internal class BigInteger // TypeDefIndex: 80
{	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x16365E0 Offset: 0x16359E0 VA: 0x1816365E0
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1636520 Offset: 0x1635920 VA: 0x181636520
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1636030 Offset: 0x1635430 VA: 0x181636030
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x16361A0 Offset: 0x16355A0 VA: 0x1816361A0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1636110 Offset: 0x1635510 VA: 0x181636110
	public void .ctor(uint ui) { }

	// RVA: 0x1636930 Offset: 0x1635D30 VA: 0x181636930
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1636990 Offset: 0x1635D90 VA: 0x181636990
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x16370A0 Offset: 0x16364A0 VA: 0x1816370A0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636BE0 Offset: 0x1635FE0 VA: 0x181636BE0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1636C50 Offset: 0x1636050 VA: 0x181636C50
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636740 Offset: 0x1635B40 VA: 0x181636740
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636C90 Offset: 0x1636090 VA: 0x181636C90
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636F70 Offset: 0x1636370 VA: 0x181636F70
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x1636B90 Offset: 0x1635F90 VA: 0x181636B90
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1637090 Offset: 0x1636490 VA: 0x181637090
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1636650 Offset: 0x1635A50 VA: 0x181636650
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1634CA0 Offset: 0x16340A0 VA: 0x181634CA0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1634ED0 Offset: 0x16342D0 VA: 0x181634ED0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1635720 Offset: 0x1634B20 VA: 0x181635720
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x16359B0 Offset: 0x1634DB0 VA: 0x1816359B0
	public void Randomize() { }

	// RVA: 0x16347A0 Offset: 0x1633BA0 VA: 0x1816347A0
	public int BitCount() { }

	// RVA: 0x1635AE0 Offset: 0x1634EE0 VA: 0x181635AE0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x1635B30 Offset: 0x1634F30 VA: 0x181635B30
	public bool TestBit(int bitNum) { }

	// RVA: 0x1635A90 Offset: 0x1634E90 VA: 0x181635A90
	public void SetBit(uint bitNum) { }

	// RVA: 0x1635A10 Offset: 0x1634E10 VA: 0x181635A10
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x16354F0 Offset: 0x16348F0 VA: 0x1816354F0
	public int LowestSetBit() { }

	// RVA: 0x1634F30 Offset: 0x1634330 VA: 0x181634F30
	public byte[] GetBytes() { }

	// RVA: 0x1636780 Offset: 0x1635B80 VA: 0x181636780
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x1636AF0 Offset: 0x1635EF0 VA: 0x181636AF0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1636820 Offset: 0x1635C20 VA: 0x181636820
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636A20 Offset: 0x1635E20 VA: 0x181636A20
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636910 Offset: 0x1635D10 VA: 0x181636910
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636BC0 Offset: 0x1635FC0 VA: 0x181636BC0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x16368F0 Offset: 0x1635CF0 VA: 0x1816368F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636BA0 Offset: 0x1635FA0 VA: 0x181636BA0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1635F30 Offset: 0x1635330 VA: 0x181635F30
	public string ToString(uint radix) { }

	// RVA: 0x1635BE0 Offset: 0x1634FE0 VA: 0x181635BE0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x16356C0 Offset: 0x1634AC0 VA: 0x1816356C0
	private void Normalize() { }

	// RVA: 0x1634870 Offset: 0x1633C70 VA: 0x181634870
	public void Clear() { }

	// RVA: 0x1635100 Offset: 0x1634500 VA: 0x181635100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1635F80 Offset: 0x1635380 VA: 0x181635F80 Slot: 3
	public override string ToString() { }

	// RVA: 0x16348D0 Offset: 0x1633CD0 VA: 0x1816348D0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1635620 Offset: 0x1634A20 VA: 0x181635620
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1635630 Offset: 0x1634A30 VA: 0x181635630
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x1635260 Offset: 0x1634660 VA: 0x181635260
	public bool IsProbablePrime() { }

	// RVA: 0x1634C30 Offset: 0x1634030 VA: 0x181634C30
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1635150 Offset: 0x1634550 VA: 0x181635150
	public void Incr2() { }

	// RVA: 0x1635FC0 Offset: 0x16353C0 VA: 0x181635FC0
	private static void .cctor() { }

}

public enum BigInteger.Sign // TypeDefIndex: 81
{	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;

}

internal sealed class BigInteger.ModulusRing // TypeDefIndex: 82
{	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1641EE0 Offset: 0x16412E0 VA: 0x181641EE0
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1641210 Offset: 0x1640610 VA: 0x181641210
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1641980 Offset: 0x1640D80 VA: 0x181641980
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1641730 Offset: 0x1640B30 VA: 0x181641730
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1641D10 Offset: 0x1641110 VA: 0x181641D10
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x1641C90 Offset: 0x1641090 VA: 0x181641C90
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 83
{	// Methods

	// RVA: 0x1639170 Offset: 0x1638570 VA: 0x181639170
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x1638660 Offset: 0x1637A60 VA: 0x181638660
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x1638BD0 Offset: 0x1637FD0 VA: 0x181638BD0
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1637EA0 Offset: 0x16372A0 VA: 0x181637EA0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x16390A0 Offset: 0x16384A0 VA: 0x1816390A0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1636BE0 Offset: 0x1635FE0 VA: 0x181636BE0
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x1638020 Offset: 0x1637420 VA: 0x181638020
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x163A020 Offset: 0x1639420 VA: 0x18163A020
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1638340 Offset: 0x1637740 VA: 0x181638340
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1638E30 Offset: 0x1638230 VA: 0x181638E30
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x16387F0 Offset: 0x1637BF0 VA: 0x1816387F0
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x1638AC0 Offset: 0x1637EC0 VA: 0x181638AC0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x16389A0 Offset: 0x1637DA0 VA: 0x1816389A0
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1639430 Offset: 0x1638830 VA: 0x181639430
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1639560 Offset: 0x1638960 VA: 0x181639560
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

}

public class BigInteger // TypeDefIndex: 1763
{	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1AAAF70 Offset: 0x1AAA370 VA: 0x181AAAF70
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1AAAE20 Offset: 0x1AAA220 VA: 0x181AAAE20
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1AAAD40 Offset: 0x1AAA140 VA: 0x181AAAD40
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1AAA9C0 Offset: 0x1AA9DC0 VA: 0x181AAA9C0
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1AAAEE0 Offset: 0x1AAA2E0 VA: 0x181AAAEE0
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1AAB1E0 Offset: 0x1AAA5E0 VA: 0x181AAB1E0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1AAB240 Offset: 0x1AAA640 VA: 0x181AAB240
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1AAB6E0 Offset: 0x1AAAAE0 VA: 0x181AAB6E0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1636BE0 Offset: 0x1635FE0 VA: 0x181636BE0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1AAB3B0 Offset: 0x1AAA7B0 VA: 0x181AAB3B0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AAB0D0 Offset: 0x1AAA4D0 VA: 0x181AAB0D0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AAB3F0 Offset: 0x1AAA7F0 VA: 0x181AAB3F0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AAB3A0 Offset: 0x1AAA7A0 VA: 0x181AAB3A0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AAB6D0 Offset: 0x1AAAAD0 VA: 0x181AAB6D0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AAAFE0 Offset: 0x1AAA3E0 VA: 0x181AAAFE0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1AA9F80 Offset: 0x1AA9380 VA: 0x181AA9F80
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1AA9E50 Offset: 0x1AA9250 VA: 0x181AA9E50
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x16347A0 Offset: 0x1633BA0 VA: 0x1816347A0
	public int BitCount() { }

	// RVA: 0x1AAA4C0 Offset: 0x1AA98C0 VA: 0x181AAA4C0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1635A90 Offset: 0x1634E90 VA: 0x181635A90
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1635A10 Offset: 0x1634E10 VA: 0x181635A10
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1AAA380 Offset: 0x1AA9780 VA: 0x181AAA380
	public int LowestSetBit() { }

	// RVA: 0x1AAA1B0 Offset: 0x1AA95B0 VA: 0x181AAA1B0
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1636780 Offset: 0x1635B80 VA: 0x181636780
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1636AF0 Offset: 0x1635EF0 VA: 0x181636AF0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1AAB110 Offset: 0x1AAA510 VA: 0x181AAB110
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AAB2D0 Offset: 0x1AAA6D0 VA: 0x181AAB2D0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636910 Offset: 0x1635D10 VA: 0x181636910
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636BC0 Offset: 0x1635FC0 VA: 0x181636BC0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x16368F0 Offset: 0x1635CF0 VA: 0x1816368F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1636BA0 Offset: 0x1635FA0 VA: 0x181636BA0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1AAA570 Offset: 0x1AA9970 VA: 0x181AAA570
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1AAA600 Offset: 0x1AA9A00 VA: 0x181AAA600
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x16356C0 Offset: 0x1634AC0 VA: 0x1816356C0
	private void Normalize() { }

	// RVA: 0x1635100 Offset: 0x1634500 VA: 0x181635100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AAA5C0 Offset: 0x1AA99C0 VA: 0x181AAA5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AA9A80 Offset: 0x1AA8E80 VA: 0x181AA9A80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1AAA4B0 Offset: 0x1AA98B0 VA: 0x181AAA4B0
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1AA9DE0 Offset: 0x1AA91E0 VA: 0x181AA9DE0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1635150 Offset: 0x1634550 VA: 0x181635150
	public void Incr2() { }

	// RVA: 0x1AAA950 Offset: 0x1AA9D50 VA: 0x181AAA950
	private static void .cctor() { }

}

public enum BigInteger.Sign // TypeDefIndex: 1764
{	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;

}

public sealed class BigInteger.ModulusRing // TypeDefIndex: 1765
{	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1AB3EE0 Offset: 0x1AB32E0 VA: 0x181AB3EE0
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1AB3210 Offset: 0x1AB2610 VA: 0x181AB3210
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1AB3980 Offset: 0x1AB2D80 VA: 0x181AB3980
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB3730 Offset: 0x1AB2B30 VA: 0x181AB3730
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB3C90 Offset: 0x1AB3090 VA: 0x181AB3C90
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1AB3E60 Offset: 0x1AB3260 VA: 0x181AB3E60
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 1766
{	// Methods

	// RVA: 0x1AB0910 Offset: 0x1AAFD10 VA: 0x181AB0910
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x1638660 Offset: 0x1637A60 VA: 0x181638660
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x1638BD0 Offset: 0x1637FD0 VA: 0x181638BD0
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1637EA0 Offset: 0x16372A0 VA: 0x181637EA0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x16390A0 Offset: 0x16384A0 VA: 0x1816390A0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1636BE0 Offset: 0x1635FE0 VA: 0x181636BE0
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x1AB0060 Offset: 0x1AAF460 VA: 0x181AB0060
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1AB17C0 Offset: 0x1AB0BC0 VA: 0x181AB17C0
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0380 Offset: 0x1AAF780 VA: 0x181AB0380
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1AB06A0 Offset: 0x1AAFAA0 VA: 0x181AB06A0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x1638AC0 Offset: 0x1637EC0 VA: 0x181638AC0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x16389A0 Offset: 0x1637DA0 VA: 0x1816389A0
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1AB0BD0 Offset: 0x1AAFFD0 VA: 0x181AB0BD0
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1AB0D00 Offset: 0x1AB0100 VA: 0x181AB0D00
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

}

public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3963
{	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Properties
	public static BigInteger Zero { get; }
	public bool IsZero { get; }

	// Methods

	// RVA: 0x237A70 Offset: 0x236E70 VA: 0x180237A70
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x237A80 Offset: 0x236E80 VA: 0x180237A80
	public void .ctor(uint value) { }

	// RVA: 0x237A50 Offset: 0x236E50 VA: 0x180237A50
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x237A60 Offset: 0x236E60 VA: 0x180237A60
	public void .ctor(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x237990 Offset: 0x236D90 VA: 0x180237990
	public void .ctor(byte[] value) { }

	// RVA: 0x237AA0 Offset: 0x236EA0 VA: 0x180237AA0
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0xFC970 Offset: 0xFBD70 VA: 0x1800FC970
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x237A90 Offset: 0x236E90 VA: 0x180237A90
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x222AF30 Offset: 0x222A330 VA: 0x18222AF30
	public static BigInteger get_Zero() { }

	// RVA: 0x237AD0 Offset: 0x236ED0 VA: 0x180237AD0
	public bool get_IsZero() { }

	// RVA: 0x2229850 Offset: 0x2228C50 VA: 0x182229850
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x22298F0 Offset: 0x2228CF0 VA: 0x1822298F0
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x237820 Offset: 0x236C20 VA: 0x180237820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x237780 Offset: 0x236B80 VA: 0x180237780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x237770 Offset: 0x236B70 VA: 0x180237770
	public bool Equals(long other) { }

	// RVA: 0x237750 Offset: 0x236B50 VA: 0x180237750 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x237740 Offset: 0x236B40 VA: 0x180237740
	public int CompareTo(long other) { }

	// RVA: 0x237720 Offset: 0x236B20 VA: 0x180237720 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x237650 Offset: 0x236A50 VA: 0x180237650 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x237880 Offset: 0x236C80 VA: 0x180237880
	public byte[] ToByteArray() { }

	// RVA: 0x237950 Offset: 0x236D50 VA: 0x180237950
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x2378D0 Offset: 0x236CD0 VA: 0x1802378D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x237910 Offset: 0x236D10 VA: 0x180237910 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x22290C0 Offset: 0x22284C0 VA: 0x1822290C0
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x222C3C0 Offset: 0x222B7C0 VA: 0x18222C3C0
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x2229950 Offset: 0x2228D50 VA: 0x182229950
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x222BED0 Offset: 0x222B2D0 VA: 0x18222BED0
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x222BE00 Offset: 0x222B200 VA: 0x18222BE00
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x222BE50 Offset: 0x222B250 VA: 0x18222BE50
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x222BE80 Offset: 0x222B280 VA: 0x18222BE80
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x222BF00 Offset: 0x222B300 VA: 0x18222BF00
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x222BDE0 Offset: 0x222B1E0 VA: 0x18222BDE0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x222BE30 Offset: 0x222B230 VA: 0x18222BE30
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x222BEB0 Offset: 0x222B2B0 VA: 0x18222BEB0
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x222BC10 Offset: 0x222B010 VA: 0x18222BC10
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x222B700 Offset: 0x222AB00 VA: 0x18222B700
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x222B900 Offset: 0x222AD00 VA: 0x18222B900
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x222B680 Offset: 0x222AA80 VA: 0x18222B680
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x222B500 Offset: 0x222A900 VA: 0x18222B500
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x222B980 Offset: 0x222AD80 VA: 0x18222B980
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x222B230 Offset: 0x222A630 VA: 0x18222B230
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x222B3C0 Offset: 0x222A7C0 VA: 0x18222B3C0
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x222B780 Offset: 0x222AB80 VA: 0x18222B780
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x222BC90 Offset: 0x222B090 VA: 0x18222BC90
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x222BA50 Offset: 0x222AE50 VA: 0x18222BA50
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x222C630 Offset: 0x222BA30 VA: 0x18222C630
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x222AFA0 Offset: 0x222A3A0 VA: 0x18222AFA0
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x222C020 Offset: 0x222B420 VA: 0x18222C020
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x222BF70 Offset: 0x222B370 VA: 0x18222BF70
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x222BF40 Offset: 0x222B340 VA: 0x18222BF40
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x222BFE0 Offset: 0x222B3E0 VA: 0x18222BFE0
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x222BFA0 Offset: 0x222B3A0 VA: 0x18222BFA0
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x222B210 Offset: 0x222A610 VA: 0x18222B210
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x222BF20 Offset: 0x222B320 VA: 0x18222BF20
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x222C000 Offset: 0x222B400 VA: 0x18222C000
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x222BFC0 Offset: 0x222B3C0 VA: 0x18222BFC0
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x22297E0 Offset: 0x2228BE0 VA: 0x1822297E0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x222A100 Offset: 0x2229500 VA: 0x18222A100
	private static void .cctor() { }

}

private enum BigInteger.GetBytesMode // TypeDefIndex: 3964
{	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;

}

