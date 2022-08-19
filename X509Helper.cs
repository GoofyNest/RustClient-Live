internal static class X509Helper // TypeDefIndex: 1020
{	// Fields
	private static INativeCertificateHelper nativeHelper; // 0x13159

	// Methods

	// RVA: 0x17C7A30 Offset: 0x17C6E30 VA: 0x1817C7A30
	internal static void InstallNativeHelper(INativeCertificateHelper helper) { }

	// RVA: 0x17C7700 Offset: 0x17C6B00 VA: 0x1817C7700
	private static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x17C7900 Offset: 0x17C6D00 VA: 0x1817C7900
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x17C77F0 Offset: 0x17C6BF0 VA: 0x1817C77F0
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x14DDFD0 Offset: 0x14DD3D0 VA: 0x1814DDFD0
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x17C7B90 Offset: 0x17C6F90 VA: 0x1817C7B90
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x17C71E0 Offset: 0x17C65E0 VA: 0x1817C71E0
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x17C7340 Offset: 0x17C6740 VA: 0x1817C7340
	internal static X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	// RVA: 0x17C7A80 Offset: 0x17C6E80 VA: 0x1817C7A80
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x17C7030 Offset: 0x17C6430 VA: 0x1817C7030
	private static byte[] ConvertData(byte[] data) { }

	// RVA: 0x17C7250 Offset: 0x17C6650 VA: 0x1817C7250
	private static X509CertificateImpl ImportCore(byte[] rawData) { }

	// RVA: 0x17C7710 Offset: 0x17C6B10 VA: 0x1817C7710
	public static X509CertificateImpl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x17C7BF0 Offset: 0x17C6FF0 VA: 0x1817C7BF0
	public static string ToHexString(byte[] data) { }

}

