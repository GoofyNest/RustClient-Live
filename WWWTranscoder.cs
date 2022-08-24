internal class WWWTranscoder // TypeDefIndex: 4126
{
	private static byte[] ucHexChars; 
	private static byte[] lcHexChars; 
	private static byte urlEscapeChar; 
	private static byte[] urlSpace; 
	private static byte[] dataSpace; 
	private static byte[] urlForbidden; 
	private static byte qpEscapeChar; 
	private static byte[] qpSpace; 
	private static byte[] qpForbidden; 


	private static byte Hex2Byte(byte[] b, int offset) { }

	private static byte[] Byte2Hex(byte b, byte[] hexChars) { }

	public static byte[] URLEncode(byte[] toEncode) { }

	public static byte[] DataEncode(byte[] toEncode) { }

	public static string QPEncode(string toEncode, Encoding e) { }

	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	private static bool ByteArrayContains(byte[] array, byte b) { }

	public static byte[] URLDecode(byte[] toEncode) { }

	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	public static bool SevenBitClean(string s, Encoding e) { }

	public static bool SevenBitClean(byte[] input) { }

	private static void .cctor() { }

}

