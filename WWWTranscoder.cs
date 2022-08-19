internal class WWWTranscoder // TypeDefIndex: 4126
{	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x229E930 Offset: 0x229DD30 VA: 0x18229E930
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x229E070 Offset: 0x229D470 VA: 0x18229E070
	private static byte[] Byte2Hex(byte b, byte[] hexChars) { }

	// RVA: 0x229EC50 Offset: 0x229E050 VA: 0x18229EC50
	public static byte[] URLEncode(byte[] toEncode) { }

	// RVA: 0x229E230 Offset: 0x229D630 VA: 0x18229E230
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x229E9C0 Offset: 0x229DDC0 VA: 0x18229E9C0
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x229E5B0 Offset: 0x229D9B0 VA: 0x18229E5B0
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x229E140 Offset: 0x229D540 VA: 0x18229E140
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x229EBE0 Offset: 0x229DFE0 VA: 0x18229EBE0
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x229E190 Offset: 0x229D590 VA: 0x18229E190
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x229E2B0 Offset: 0x229D6B0 VA: 0x18229E2B0
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x229EAB0 Offset: 0x229DEB0 VA: 0x18229EAB0
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x229EB80 Offset: 0x229DF80 VA: 0x18229EB80
	public static bool SevenBitClean(byte[] input) { }

	// RVA: 0x229ECD0 Offset: 0x229E0D0 VA: 0x18229ECD0
	private static void .cctor() { }

}

