public static class BitConverter // TypeDefIndex: 178
{	// Fields
	public static readonly bool IsLittleEndian; // 0x12EB3

	// Methods

	// RVA: 0x158BAF0 Offset: 0x158AEF0 VA: 0x18158BAF0
	private static bool AmILittleEndian() { }

	// RVA: 0x158BEF0 Offset: 0x158B2F0 VA: 0x18158BEF0
	public static byte[] GetBytes(bool value) { }

	// RVA: 0x158BD40 Offset: 0x158B140 VA: 0x18158BD40
	public static byte[] GetBytes(char value) { }

	// RVA: 0x158BF50 Offset: 0x158B350 VA: 0x18158BF50
	public static byte[] GetBytes(short value) { }

	// RVA: 0x158BE90 Offset: 0x158B290 VA: 0x18158BE90
	public static byte[] GetBytes(int value) { }

	// RVA: 0x158BB10 Offset: 0x158AF10 VA: 0x18158BB10
	public static byte[] GetBytes(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x158BCA0 Offset: 0x158B0A0 VA: 0x18158BCA0
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x158BB70 Offset: 0x158AF70 VA: 0x18158BB70
	public static byte[] GetBytes(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x158BFB0 Offset: 0x158B3B0 VA: 0x18158BFB0
	public static byte[] GetBytes(ulong value) { }

	// RVA: 0x158BC00 Offset: 0x158B000 VA: 0x18158BC00
	public static byte[] GetBytes(float value) { }

	// RVA: 0x158BDE0 Offset: 0x158B1E0 VA: 0x18158BDE0
	public static byte[] GetBytes(double value) { }

	// RVA: 0x158C070 Offset: 0x158B470 VA: 0x18158C070
	public static short ToInt16(byte[] value, int startIndex) { }

	// RVA: 0x158C180 Offset: 0x158B580 VA: 0x18158C180
	public static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x158C2C0 Offset: 0x158B6C0 VA: 0x18158C2C0
	public static long ToInt64(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x158C8A0 Offset: 0x158BCA0 VA: 0x18158C8A0
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x158CA40 Offset: 0x158BE40 VA: 0x18158CA40
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x158CC10 Offset: 0x158C010 VA: 0x18158CC10
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	// RVA: 0x158C050 Offset: 0x158B450 VA: 0x18158C050
	private static char GetHexValue(int i) { }

	// RVA: 0x158C4F0 Offset: 0x158B8F0 VA: 0x18158C4F0
	public static string ToString(byte[] value, int startIndex, int length) { }

	// RVA: 0x158C460 Offset: 0x158B860 VA: 0x18158C460
	public static string ToString(byte[] value) { }

	// RVA: 0xE569D0 Offset: 0xE55DD0 VA: 0x180E569D0
	public static long DoubleToInt64Bits(double value) { }

	// RVA: 0x158C060 Offset: 0x158B460 VA: 0x18158C060
	public static double Int64BitsToDouble(long value) { }

	// RVA: 0x158CCB0 Offset: 0x158C0B0 VA: 0x18158CCB0
	private static void .cctor() { }

}

