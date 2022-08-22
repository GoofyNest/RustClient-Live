internal class X509Certificate2ImplMono : X509Certificate2Impl // TypeDefIndex: 2818
{	private bool _archived; // 0x18
	private X509ExtensionCollection _extensions; // 0x20
	private PublicKey _publicKey; // 0x28
	private X500DistinguishedName issuer_name; // 0x30
	private X500DistinguishedName subject_name; // 0x38
	private Oid signature_algorithm; // 0x40
	private X509CertificateImplCollection intermediateCerts; // 0x48
	private X509Certificate _cert; // 0x50
	private static string empty_error; // 0x0
	private static byte[] commonName; // 0x8
	private static byte[] email; // 0x10
	private static byte[] signedData; // 0x18

	public override bool IsValid { get; }
	public override X509ExtensionCollection Extensions { get; }
	public override X500DistinguishedName IssuerName { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }
	public override PublicKey PublicKey { get; }
	public override Oid SignatureAlgorithm { get; }
	public override X500DistinguishedName SubjectName { get; }
	public override int Version { get; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	internal X509Certificate MonoCertificate { get; }
	internal override X509Certificate2Impl FallbackImpl { get; }


	public override bool get_IsValid() { }

	private void .ctor(X509Certificate cert) { }

	private void .ctor(X509Certificate2ImplMono other) { }

	public override X509CertificateImpl Clone() { }

	public override string GetIssuerName(bool legacyV1Mode) { }

	public override string GetSubjectName(bool legacyV1Mode) { }

	public override byte[] GetRawCertData() { }

	protected override byte[] GetCertHash(bool lazy) { }

	public override DateTime GetValidFrom() { }

	public override DateTime GetValidUntil() { }

	public override bool Equals(X509CertificateImpl other, out bool result) { }

	public override byte[] GetSerialNumber() { }

	public void .ctor() { }

	public override X509ExtensionCollection get_Extensions() { }

	public override X500DistinguishedName get_IssuerName() { }

	public override AsymmetricAlgorithm get_PrivateKey() { }

	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	public override PublicKey get_PublicKey() { }

	public override Oid get_SignatureAlgorithm() { }

	public override X500DistinguishedName get_SubjectName() { }

	public override int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAFBD0 Offset: 0xAEFD0 VA: 0x1800AFBD0
	public override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	private ASN1 Find(byte[] oid, ASN1 dn) { }

	private string GetValueAsString(ASN1 pair) { }

	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODOAttribute] // RVA: 0xAFC70 Offset: 0xAF070 VA: 0x1800AFC70
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	public override void Reset() { }

	public override string ToString() { }

	public override string ToString(bool verbose) { }

	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFDB0 Offset: 0xAF1B0 VA: 0x1800AFDB0
	public override bool Verify(X509Certificate2 thisCertificate) { }

	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	internal X509Certificate get_MonoCertificate() { }

	internal override X509Certificate2Impl get_FallbackImpl() { }

	private static void .cctor() { }

}

