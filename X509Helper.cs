internal static class X509Helper // TypeDefIndex: 1020
{
	private static INativeCertificateHelper nativeHelper;


	internal static void InstallNativeHelper(INativeCertificateHelper helper) { }

	private static X509CertificateImpl Import(byte[] rawData) { }

	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	public static bool IsValid(X509CertificateImpl impl) { }

	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	internal static Exception GetInvalidContextException() { }

	internal static X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	private static byte[] PEM(string type, byte[] data) { }

	private static byte[] ConvertData(byte[] data) { }

	private static X509CertificateImpl ImportCore(byte[] rawData) { }

	public static X509CertificateImpl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	public static string ToHexString(byte[] data) { }

}

