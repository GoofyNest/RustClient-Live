internal static class SystemCertificateValidator // TypeDefIndex: 2555
{	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0x1216770 Offset: 0x1215B70 VA: 0x181216770
	private static void .cctor() { }

	// RVA: 0x1216690 Offset: 0x1215A90 VA: 0x181216690
	public static X509Chain CreateX509Chain(X509CertificateCollection certs) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

