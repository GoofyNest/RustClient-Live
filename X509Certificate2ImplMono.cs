internal class X509Certificate2ImplMono : X509Certificate2Impl // TypeDefIndex: 2818
{	// Fields
	private bool _archived; // 0x18
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

	// Properties
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

	// Methods

	// RVA: 0xE661B0 Offset: 0xE655B0 VA: 0x180E661B0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0xEE9AA0 Offset: 0xEE8EA0 VA: 0x180EE9AA0
	private void .ctor(X509Certificate cert) { }

	// RVA: 0x14D39B0 Offset: 0x14D2DB0 VA: 0x1814D39B0
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x14D1C50 Offset: 0x14D1050 VA: 0x1814D1C50 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x14D1E90 Offset: 0x14D1290 VA: 0x1814D1E90 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x14D2270 Offset: 0x14D1670 VA: 0x1814D2270 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x14D21F0 Offset: 0x14D15F0 VA: 0x1814D21F0 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x14D1E30 Offset: 0x14D1230 VA: 0x1814D1E30 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x14D2330 Offset: 0x14D1730 VA: 0x1814D2330 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x14D2370 Offset: 0x14D1770 VA: 0x1814D2370 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x14D1D20 Offset: 0x14D1120 VA: 0x1814D1D20 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x14D2230 Offset: 0x14D1630 VA: 0x1814D2230 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x14D3980 Offset: 0x14D2D80 VA: 0x1814D3980
	public void .ctor() { }

	// RVA: 0x14D3A50 Offset: 0x14D2E50 VA: 0x1814D3A50 Slot: 17
	public override X509ExtensionCollection get_Extensions() { }

	// RVA: 0x14D3B40 Offset: 0x14D2F40 VA: 0x1814D3B40 Slot: 18
	public override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x14D3C50 Offset: 0x14D3050 VA: 0x1814D3C50 Slot: 19
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x14D4360 Offset: 0x14D3760 VA: 0x1814D4360 Slot: 20
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x14D3F60 Offset: 0x14D3360 VA: 0x1814D3F60 Slot: 21
	public override PublicKey get_PublicKey() { }

	// RVA: 0x14D40A0 Offset: 0x14D34A0 VA: 0x1814D40A0 Slot: 22
	public override Oid get_SignatureAlgorithm() { }

	// RVA: 0x14D41A0 Offset: 0x14D35A0 VA: 0x1814D41A0 Slot: 23
	public override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x14D42B0 Offset: 0x14D36B0 VA: 0x1814D42B0 Slot: 24
	public override int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAFBD0 Offset: 0xAEFD0 VA: 0x1800AFBD0
	// RVA: 0x14D1F50 Offset: 0x14D1350 VA: 0x1814D1F50 Slot: 27
	public override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x14D1D30 Offset: 0x14D1130 VA: 0x1814D1D30
	private ASN1 Find(byte[] oid, ASN1 dn) { }

	// RVA: 0x14D23B0 Offset: 0x14D17B0 VA: 0x1814D23B0
	private string GetValueAsString(ASN1 pair) { }

	// RVA: 0x14D2540 Offset: 0x14D1940 VA: 0x1814D2540
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODOAttribute] // RVA: 0xAFC70 Offset: 0xAF070 VA: 0x1800AFC70
	// RVA: 0x14D2BF0 Offset: 0x14D1FF0 VA: 0x1814D2BF0 Slot: 28
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x14D2D20 Offset: 0x14D2120 VA: 0x1814D2D20 Slot: 30
	public override void Reset() { }

	// RVA: 0x14D3570 Offset: 0x14D2970 VA: 0x1814D3570 Slot: 3
	public override string ToString() { }

	// RVA: 0x14D2E10 Offset: 0x14D2210 VA: 0x1814D2E10 Slot: 15
	public override string ToString(bool verbose) { }

	// RVA: 0x14D1B90 Offset: 0x14D0F90 VA: 0x1814D1B90
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFDB0 Offset: 0xAF1B0 VA: 0x1800AFDB0
	// RVA: 0x14D35D0 Offset: 0x14D29D0 VA: 0x1814D35D0 Slot: 29
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 25
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 26
	internal override X509Certificate2Impl get_FallbackImpl() { }

	// RVA: 0x14D3860 Offset: 0x14D2C60 VA: 0x1814D3860
	private static void .cctor() { }

}

