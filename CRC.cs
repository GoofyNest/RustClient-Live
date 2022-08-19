public class CRC // TypeDefIndex: 6564
{	// Fields
	private static byte[] byteBuffer; // 0x0
	private static readonly uint[] crc32_tab; // 0x8
	private static readonly ulong[] crc64_tab; // 0x10

	// Methods

	// RVA: 0x1B9A500 Offset: 0x1B99900 VA: 0x181B9A500
	public static uint Compute32(uint crc, int i) { }

	// RVA: 0x1B998E0 Offset: 0x1B98CE0 VA: 0x181B998E0
	public static uint Compute32(uint crc, uint u) { }

	// RVA: 0x1B99350 Offset: 0x1B98750 VA: 0x181B99350
	public static uint Compute32(uint crc, float f) { }

	// RVA: 0x1B9A1D0 Offset: 0x1B995D0 VA: 0x181B9A1D0
	public static uint Compute32(uint crc, long i) { }

	// RVA: 0x1B995B0 Offset: 0x1B989B0 VA: 0x181B995B0
	public static uint Compute32(uint crc, ulong u) { }

	// RVA: 0x1B99B10 Offset: 0x1B98F10 VA: 0x181B99B10
	public static uint Compute32(uint crc, double f) { }

	// RVA: 0x1B99FF0 Offset: 0x1B993F0 VA: 0x181B99FF0
	public static uint Compute32(uint crc, string str) { }

	// RVA: 0x1B99E60 Offset: 0x1B99260 VA: 0x181B99E60
	public static uint Compute32(string[] strs) { }

	// RVA: 0x1B9ADB0 Offset: 0x1B9A1B0 VA: 0x181B9ADB0
	public static ulong Compute64(ulong crc, int i) { }

	// RVA: 0x1B9B710 Offset: 0x1B9AB10 VA: 0x181B9B710
	public static ulong Compute64(ulong crc, uint u) { }

	// RVA: 0x1B9B320 Offset: 0x1B9A720 VA: 0x181B9B320
	public static ulong Compute64(ulong crc, float f) { }

	// RVA: 0x1B9AFF0 Offset: 0x1B9A3F0 VA: 0x181B9AFF0
	public static ulong Compute64(ulong crc, long i) { }

	// RVA: 0x1B9AA80 Offset: 0x1B99E80 VA: 0x181B9AA80
	public static ulong Compute64(ulong crc, ulong u) { }

	// RVA: 0x1B9A730 Offset: 0x1B99B30 VA: 0x181B9A730
	public static ulong Compute64(ulong crc, double f) { }

	// RVA: 0x1B9B950 Offset: 0x1B9AD50 VA: 0x181B9B950
	public static ulong Compute64(ulong crc, string str) { }

	// RVA: 0x1B9B580 Offset: 0x1B9A980 VA: 0x181B9B580
	public static ulong Compute64(string[] strs) { }

	// RVA: 0x1B9BB40 Offset: 0x1B9AF40 VA: 0x181B9BB40
	private static int GrowByteBuffer(int count) { }

	// RVA: 0x1B99130 Offset: 0x1B98530 VA: 0x181B99130
	private static uint CRC32(uint value, byte[] buf, ulong size) { }

	// RVA: 0x1B99240 Offset: 0x1B98640 VA: 0x181B99240
	private static ulong CRC64(ulong value, byte[] buf, ulong size) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1B9BC00 Offset: 0x1B9B000 VA: 0x181B9BC00
	private static void .cctor() { }

}

