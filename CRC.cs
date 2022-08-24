public class CRC // TypeDefIndex: 6564
{
	private static byte[] byteBuffer; 
	private static readonly uint[] crc32_tab; 
	private static readonly ulong[] crc64_tab; 


public static uint Compute32(uint crc, int i) { }

public static uint Compute32(uint crc, uint u) { }

public static uint Compute32(uint crc, float f) { }

public static uint Compute32(uint crc, long i) { }

public static uint Compute32(uint crc, ulong u) { }

public static uint Compute32(uint crc, double f) { }

public static uint Compute32(uint crc, string str) { }

public static uint Compute32(string[] strs) { }

public static ulong Compute64(ulong crc, int i) { }

public static ulong Compute64(ulong crc, uint u) { }

public static ulong Compute64(ulong crc, float f) { }

public static ulong Compute64(ulong crc, long i) { }

public static ulong Compute64(ulong crc, ulong u) { }

public static ulong Compute64(ulong crc, double f) { }

public static ulong Compute64(ulong crc, string str) { }

public static ulong Compute64(string[] strs) { }

private static int GrowByteBuffer(int count) { }

private static uint CRC32(uint value, byte[] buf, ulong size) { }

private static ulong CRC64(ulong value, byte[] buf, ulong size) { }

public void .ctor() { }

private static void .cctor() { }

}

