public static class Buffer // TypeDefIndex: 180
{	// Methods

	// RVA: 0x158D950 Offset: 0x158CD50 VA: 0x18158D950
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	// RVA: 0x158D890 Offset: 0x158CC90 VA: 0x18158D890
	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	// RVA: 0x158DD00 Offset: 0x158D100 VA: 0x18158DD00
	private static int _ByteLength(Array array) { }

	// RVA: 0x158DCE0 Offset: 0x158D0E0 VA: 0x18158DCE0
	internal static void ZeroMemory(byte* src, long len) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x158DB40 Offset: 0x158CF40 VA: 0x18158DB40
	internal static void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x158D960 Offset: 0x158CD60 VA: 0x18158D960
	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	// RVA: 0x158D7D0 Offset: 0x158CBD0 VA: 0x18158D7D0
	public static int ByteLength(Array array) { }

	// RVA: 0x158D5A0 Offset: 0x158C9A0 VA: 0x18158D5A0
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x158DB80 Offset: 0x158CF80 VA: 0x18158DB80
	public static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	// RVA: 0x158DE40 Offset: 0x158D240 VA: 0x18158DE40
	internal static void memcpy4(byte* dest, byte* src, int size) { }

	// RVA: 0x158DDC0 Offset: 0x158D1C0 VA: 0x18158DDC0
	internal static void memcpy2(byte* dest, byte* src, int size) { }

	// RVA: 0x158DD10 Offset: 0x158D110 VA: 0x18158DD10
	private static void memcpy1(byte* dest, byte* src, int size) { }

	// RVA: 0x158D9A0 Offset: 0x158CDA0 VA: 0x18158D9A0
	internal static void Memcpy(byte* dest, byte* src, int size) { }

}

