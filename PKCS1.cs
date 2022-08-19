internal sealed class PKCS1 // TypeDefIndex: 70
{	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x174D950 Offset: 0x174CD50 VA: 0x18174D950
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x174E1B0 Offset: 0x174D5B0 VA: 0x18174E1B0
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x174E230 Offset: 0x174D630 VA: 0x18174E230
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x174E300 Offset: 0x174D700 VA: 0x18174E300
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x174E700 Offset: 0x174DB00 VA: 0x18174E700
	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	// RVA: 0x174E330 Offset: 0x174D730 VA: 0x18174E330
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x174DEC0 Offset: 0x174D2C0 VA: 0x18174DEC0
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x174D9F0 Offset: 0x174CDF0 VA: 0x18174D9F0
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x174E840 Offset: 0x174DC40 VA: 0x18174E840
	private static void .cctor() { }

}

public sealed class PKCS1 // TypeDefIndex: 1757
{	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1ABBBE0 Offset: 0x1ABAFE0 VA: 0x181ABBBE0
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x1ABBB80 Offset: 0x1ABAF80 VA: 0x181ABBB80
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x1ABB730 Offset: 0x1ABAB30 VA: 0x181ABB730
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1ABBED0 Offset: 0x1ABB2D0 VA: 0x181ABBED0
	private static void .cctor() { }

}

