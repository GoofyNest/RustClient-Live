public sealed class X509ChainPolicy // TypeDefIndex: 2828
{	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	public X509Certificate2Collection ExtraStore { get; }
	public X509RevocationFlag RevocationFlag { get; set; }
	public X509RevocationMode RevocationMode { get; set; }
	public TimeSpan UrlRetrievalTimeout { set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }


	public void .ctor() { }

	internal void .ctor(X509CertificateCollection store) { }

	public X509Certificate2Collection get_ExtraStore() { }

	public X509RevocationFlag get_RevocationFlag() { }

	public void set_RevocationFlag(X509RevocationFlag value) { }

	public X509RevocationMode get_RevocationMode() { }

	public void set_RevocationMode(X509RevocationMode value) { }

	public void set_UrlRetrievalTimeout(TimeSpan value) { }

	public X509VerificationFlags get_VerificationFlags() { }

	public void set_VerificationFlags(X509VerificationFlags value) { }

	public DateTime get_VerificationTime() { }

	public void Reset() { }

}

