internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 2827
{	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private int max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Properties
	public override bool IsValid { get; }
	public override X509ChainPolicy ChainPolicy { get; set; }
	public override X509ChainStatus[] ChainStatus { get; }
	private X509Certificate2Collection Roots { get; }
	private X509Certificate2Collection CertificateAuthorities { get; }
	private X509Store LMRootStore { get; }
	private X509Store UserRootStore { get; }
	private X509Store LMCAStore { get; }
	private X509Store UserCAStore { get; }
	private X509Certificate2Collection CertificateCollection { get; }

	// Methods

	// RVA: 0x14DAEA0 Offset: 0x14DA2A0 VA: 0x1814DAEA0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 6
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30 Slot: 7
	public override void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x14DB250 Offset: 0x14DA650 VA: 0x1814DB250 Slot: 8
	public override X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB0590 Offset: 0xAF990 VA: 0x1800B0590
	// RVA: 0x14D8210 Offset: 0x14D7610 VA: 0x1814D8210 Slot: 9
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x14DA690 Offset: 0x14D9A90 VA: 0x1814DA690 Slot: 10
	public override void Reset() { }

	// RVA: 0x14DB440 Offset: 0x14DA840 VA: 0x1814DB440
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x14DAFA0 Offset: 0x14DA3A0 VA: 0x1814DAFA0
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x14DB380 Offset: 0x14DA780 VA: 0x1814DB380
	private X509Store get_LMRootStore() { }

	// RVA: 0x14DB5F0 Offset: 0x14DA9F0 VA: 0x1814DB5F0
	private X509Store get_UserRootStore() { }

	// RVA: 0x14DB2C0 Offset: 0x14DA6C0 VA: 0x1814DB2C0
	private X509Store get_LMCAStore() { }

	// RVA: 0x14DB530 Offset: 0x14DA930 VA: 0x1814DB530
	private X509Store get_UserCAStore() { }

	// RVA: 0x14DB090 Offset: 0x14DA490 VA: 0x1814DB090
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x14D8030 Offset: 0x14D7430 VA: 0x1814D8030
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x14DA860 Offset: 0x14D9C60 VA: 0x1814DA860
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x14D9370 Offset: 0x14D8770 VA: 0x1814D9370
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x14D98B0 Offset: 0x14D8CB0 VA: 0x1814D98B0
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x14D99D0 Offset: 0x14D8DD0 VA: 0x1814D99D0
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x14DAAC0 Offset: 0x14D9EC0 VA: 0x1814DAAC0
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x14DA2E0 Offset: 0x14D96E0 VA: 0x1814DA2E0
	private void Process(int n) { }

	// RVA: 0x14D9A70 Offset: 0x14D8E70 VA: 0x1814D9A70
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x14DAD60 Offset: 0x14DA160 VA: 0x1814DAD60
	private void WrapUp() { }

	// RVA: 0x14D9CE0 Offset: 0x14D90E0 VA: 0x1814D9CE0
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x14D9A20 Offset: 0x14D8E20 VA: 0x1814D9A20
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x14D97A0 Offset: 0x14D8BA0 VA: 0x1814D97A0
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x14D9530 Offset: 0x14D8930 VA: 0x1814D9530
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x14D95C0 Offset: 0x14D89C0 VA: 0x1814D95C0
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x14D9640 Offset: 0x14D8A40 VA: 0x1814D9640
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x14D8B90 Offset: 0x14D7F90 VA: 0x1814D8B90
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x14D9060 Offset: 0x14D8460 VA: 0x1814D9060
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x14D8DF0 Offset: 0x14D81F0 VA: 0x1814D8DF0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x14D88D0 Offset: 0x14D7CD0 VA: 0x1814D88D0
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x14D91A0 Offset: 0x14D85A0 VA: 0x1814D91A0
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x14DA0D0 Offset: 0x14D94D0 VA: 0x1814DA0D0
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x14D9EE0 Offset: 0x14D92E0 VA: 0x1814D9EE0
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x14DAE50 Offset: 0x14DA250 VA: 0x1814DAE50
	private static void .cctor() { }

}

