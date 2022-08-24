internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 2827
{
	private StoreLocation location; 
	private X509ChainElementCollection elements; 
	private X509ChainPolicy policy; 
	private X509ChainStatus[] status; 
	private static X509ChainStatus[] Empty; 
	private int max_path_length; 
	private X500DistinguishedName working_issuer_name; 
	private AsymmetricAlgorithm working_public_key; 
	private X509ChainElement bce_restriction; 
	private X509Certificate2Collection roots; 
	private X509Certificate2Collection cas; 
	private X509Store root_store; 
	private X509Store ca_store; 
	private X509Store user_root_store; 
	private X509Store user_ca_store; 
	private X509Certificate2Collection collection; 

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

	[MonoTODOAttribute] 
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

