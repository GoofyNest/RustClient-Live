internal static class CertHelper // TypeDefIndex: 2455
{	// Methods

	// RVA: 0x1210490 Offset: 0x120F890 VA: 0x181210490
	public static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x12102D0 Offset: 0x120F6D0 VA: 0x1812102D0
	public static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x12105C0 Offset: 0x120F9C0 VA: 0x1812105C0
	public static X509CertificateCollection NativeChainToManagedCollection(UnityTls.unitytls_x509list_ref nativeCertificateChain, UnityTls.unitytls_errorstate* errorState) { }

}

