public static class BitConverter // TypeDefIndex: 178
{
	public static readonly bool IsLittleEndian; 


	private static bool AmILittleEndian() { }

	public static byte[] GetBytes(bool value) { }

	public static byte[] GetBytes(char value) { }

	public static byte[] GetBytes(short value) { }

	public static byte[] GetBytes(int value) { }

	public static byte[] GetBytes(long value) { }

	[CLSCompliantAttribute] 
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliantAttribute] 
	public static byte[] GetBytes(uint value) { }

	[CLSCompliantAttribute] 
	public static byte[] GetBytes(ulong value) { }

	public static byte[] GetBytes(float value) { }

	public static byte[] GetBytes(double value) { }

	public static short ToInt16(byte[] value, int startIndex) { }

	public static int ToInt32(byte[] value, int startIndex) { }

	public static long ToInt64(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] 
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] 
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] 
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	private static char GetHexValue(int i) { }

	public static string ToString(byte[] value, int startIndex, int length) { }

	public static string ToString(byte[] value) { }

	public static long DoubleToInt64Bits(double value) { }

	public static double Int64BitsToDouble(long value) { }

	private static void .cctor() { }

}

