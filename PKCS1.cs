internal sealed class PKCS1 // TypeDefIndex: 70
{
	private static byte[] emptySHA1;
	private static byte[] emptySHA256;
	private static byte[] emptySHA384;
	private static byte[] emptySHA512;


	private static bool Compare(byte[] array1, byte[] array2) { }

	public static byte[] I2OSP(byte[] x, int size) { }

	public static byte[] OS2IP(byte[] x) { }

	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	internal static HashAlgorithm CreateFromName(string name) { }

	private static void .cctor() { }

}

public sealed class PKCS1 // TypeDefIndex: 1757
{
	private static byte[] emptySHA1;
	private static byte[] emptySHA256;
	private static byte[] emptySHA384;
	private static byte[] emptySHA512;


	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	internal static HashAlgorithm CreateFromOid(string oid) { }

	internal static HashAlgorithm CreateFromName(string name) { }

	private static void .cctor() { }

}

