internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 2817
{	// Properties
	public abstract X509ExtensionCollection Extensions { get; }
	public abstract X500DistinguishedName IssuerName { get; }
	public abstract AsymmetricAlgorithm PrivateKey { get; set; }
	public abstract PublicKey PublicKey { get; }
	public abstract Oid SignatureAlgorithm { get; }
	public abstract X500DistinguishedName SubjectName { get; }
	public abstract int Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }
	internal abstract X509Certificate2Impl FallbackImpl { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract X509ExtensionCollection get_Extensions();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract X500DistinguishedName get_IssuerName();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract AsymmetricAlgorithm get_PrivateKey();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void set_PrivateKey(AsymmetricAlgorithm value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract PublicKey get_PublicKey();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Oid get_SignatureAlgorithm();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract X500DistinguishedName get_SubjectName();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 25
	internal abstract X509CertificateImplCollection get_IntermediateCertificates();

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract X509Certificate2Impl get_FallbackImpl();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool Verify(X509Certificate2 thisCertificate);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void Reset();

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

}

