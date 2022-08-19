internal sealed class BitConverterLE // TypeDefIndex: 47
{	// Methods

	// RVA: 0x173FB20 Offset: 0x173EF20 VA: 0x18173FB20
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x173FC90 Offset: 0x173F090 VA: 0x18173FC90
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x173FAE0 Offset: 0x173EEE0 VA: 0x18173FAE0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x173FB00 Offset: 0x173EF00 VA: 0x18173FB00
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x173FAC0 Offset: 0x173EEC0 VA: 0x18173FAC0
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x1740060 Offset: 0x173F460 VA: 0x181740060
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1740220 Offset: 0x173F620 VA: 0x181740220
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1740030 Offset: 0x173F430 VA: 0x181740030
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x173FF30 Offset: 0x173F330 VA: 0x18173FF30
	internal static double ToDouble(byte[] value, int startIndex) { }

}

internal sealed class BitConverterLE // TypeDefIndex: 1706
{	// Methods

	// RVA: 0x1AAB9B0 Offset: 0x1AAADB0 VA: 0x181AAB9B0
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1AABB20 Offset: 0x1AAAF20 VA: 0x181AABB20
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1AAB970 Offset: 0x1AAAD70 VA: 0x181AAB970
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1AAB990 Offset: 0x1AAAD90 VA: 0x181AAB990
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x1AAC0C0 Offset: 0x1AAB4C0 VA: 0x181AAC0C0
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1AABF00 Offset: 0x1AAB300 VA: 0x181AABF00
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1AABDC0 Offset: 0x1AAB1C0 VA: 0x181AABDC0
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x1AABED0 Offset: 0x1AAB2D0 VA: 0x181AABED0
	internal static uint ToUInt32(byte[] value, int startIndex) { }

}

