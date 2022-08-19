public sealed class X509ChainPolicy // TypeDefIndex: 2828
{	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public X509Certificate2Collection ExtraStore { get; }
	public X509RevocationFlag RevocationFlag { get; set; }
	public X509RevocationMode RevocationMode { get; set; }
	public TimeSpan UrlRetrievalTimeout { set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }

	// Methods

	// RVA: 0x14DB910 Offset: 0x14DAD10 VA: 0x1814DB910
	public void .ctor() { }

	// RVA: 0x14DB8D0 Offset: 0x14DACD0 VA: 0x1814DB8D0
	internal void .ctor(X509CertificateCollection store) { }

	// RVA: 0x14DB930 Offset: 0x14DAD30 VA: 0x1814DB930
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x14DBBF0 Offset: 0x14DAFF0 VA: 0x1814DBBF0
	public void set_RevocationFlag(X509RevocationFlag value) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x14DBC60 Offset: 0x14DB060 VA: 0x1814DBC60
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0xC107D0 Offset: 0xC0FBD0 VA: 0x180C107D0
	public void set_UrlRetrievalTimeout(TimeSpan value) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x14DBCD0 Offset: 0x14DB0D0 VA: 0x1814DBCD0
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public DateTime get_VerificationTime() { }

	// RVA: 0x14DB7C0 Offset: 0x14DABC0 VA: 0x1814DB7C0
	public void Reset() { }

}

