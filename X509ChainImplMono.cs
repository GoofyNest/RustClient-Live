internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 2827
{	private StoreLocation location; // 0x10
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


	public void .ctor(bool useMachineContext) { }

	public override bool get_IsValid() { }

	public override X509ChainPolicy get_ChainPolicy() { }

	public override void set_ChainPolicy(X509ChainPolicy value) { }

	public override X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB0590 Offset: 0xAF990 VA: 0x1800B0590
	public override bool Build(X509Certificate2 certificate) { }

	public override void Reset() { }

	private X509Certificate2Collection get_Roots() { }

	private X509Certificate2Collection get_CertificateAuthorities() { }

	private X509Store get_LMRootStore() { }

	private X509Store get_UserRootStore() { }

	private X509Store get_LMCAStore() { }

	private X509Store get_UserCAStore() { }

	private X509Certificate2Collection get_CertificateCollection() { }

	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	private bool IsChainComplete(X509Certificate2 certificate) { }

	private bool IsSelfIssued(X509Certificate2 certificate) { }

	private void ValidateChain(X509ChainStatusFlags flag) { }

	private void Process(int n) { }

	private void PrepareForNextCertificate(int n) { }

	private void WrapUp() { }

	private void ProcessCertificateExtensions(X509ChainElement element) { }

	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	private bool ProcessCrlExtensions(X509Crl crl) { }

	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	private static void .cctor() { }

}

