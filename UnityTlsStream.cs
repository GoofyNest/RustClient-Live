internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 2512
{	// Methods

	// RVA: 0x15B3000 Offset: 0x15B2400 VA: 0x1815B3000
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	// RVA: 0x15B2F40 Offset: 0x15B2340 VA: 0x1815B2F40 Slot: 52
	protected override MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

}

