public class X509Certificate2 : X509Certificate // TypeDefIndex: 2814
{	// Fields
	private string friendlyName; // 0x30
	private static byte[] signedData; // 0x0

	// Properties
	internal X509Certificate2Impl Impl { get; }
	public X509ExtensionCollection Extensions { get; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public AsymmetricAlgorithm PrivateKey { get; set; }
	public PublicKey PublicKey { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public string Thumbprint { get; }
	public int Version { get; }
	[MonoTODOAttribute] // RVA: 0xAFE90 Offset: 0xAF290 VA: 0x1800AFE90
	internal X509Certificate MonoCertificate { get; }

	// Methods

	// RVA: 0x118DF90 Offset: 0x118D390 VA: 0x18118DF90
	internal X509Certificate2Impl get_Impl() { }

	// RVA: 0x118DE80 Offset: 0x118D280 VA: 0x18118DE80
	public void .ctor() { }

	// RVA: 0x118DD10 Offset: 0x118D110 VA: 0x18118DD10
	public void .ctor(byte[] rawData) { }

	// RVA: 0x118DED0 Offset: 0x118D2D0 VA: 0x18118DED0
	public void .ctor(string fileName, string password) { }

	// RVA: 0x118DE10 Offset: 0x118D210 VA: 0x18118DE10
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x118DD90 Offset: 0x118D190 VA: 0x18118DD90
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x118DF60 Offset: 0x118D360 VA: 0x18118DF60
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x118E020 Offset: 0x118D420 VA: 0x18118E020
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x118E060 Offset: 0x118D460 VA: 0x18118E060
	public DateTime get_NotAfter() { }

	// RVA: 0x118E0A0 Offset: 0x118D4A0 VA: 0x18118E0A0
	public DateTime get_NotBefore() { }

	// RVA: 0x118E0E0 Offset: 0x118D4E0 VA: 0x18118E0E0
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x118E1D0 Offset: 0x118D5D0 VA: 0x18118E1D0
	public void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x118E110 Offset: 0x118D510 VA: 0x18118E110
	public PublicKey get_PublicKey() { }

	// RVA: 0xFC7FF0 Offset: 0xFC73F0 VA: 0x180FC7FF0
	public string get_SerialNumber() { }

	// RVA: 0x118E140 Offset: 0x118D540 VA: 0x18118E140
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x118E170 Offset: 0x118D570 VA: 0x18118E170
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x4BF560 Offset: 0x4BE960 VA: 0x1804BF560
	public string get_Thumbprint() { }

	// RVA: 0x118E1A0 Offset: 0x118D5A0 VA: 0x18118E1A0
	public int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAFBD0 Offset: 0xAEFD0 VA: 0x1800AFBD0
	// RVA: 0x118D410 Offset: 0x118C810 VA: 0x18118D410
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[MonoTODOAttribute] // RVA: 0xAFC70 Offset: 0xAF070 VA: 0x1800AFC70
	// RVA: 0x118D460 Offset: 0x118C860 VA: 0x18118D460 Slot: 14
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xAFC70 Offset: 0xAF070 VA: 0x1800AFC70
	// RVA: 0x118D4A0 Offset: 0x118C8A0 VA: 0x18118D4A0 Slot: 15
	public override void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x118D500 Offset: 0x118C900 VA: 0x18118D500 Slot: 17
	public override void Reset() { }

	// RVA: 0x118DC00 Offset: 0x118D000 VA: 0x18118DC00 Slot: 3
	public override string ToString() { }

	// RVA: 0x118D550 Offset: 0x118C950 VA: 0x18118D550 Slot: 13
	public override string ToString(bool verbose) { }

	// RVA: 0x118D350 Offset: 0x118C750 VA: 0x18118D350
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFDB0 Offset: 0xAF1B0 VA: 0x1800AFDB0
	// RVA: 0x118DC60 Offset: 0x118D060 VA: 0x18118DC60
	public bool Verify() { }

	// RVA: 0x118E050 Offset: 0x118D450 VA: 0x18118E050
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x118DCA0 Offset: 0x118D0A0 VA: 0x18118DCA0
	private static void .cctor() { }

}

