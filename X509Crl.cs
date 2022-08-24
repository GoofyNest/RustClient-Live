public class X509Crl // TypeDefIndex: 1714
{
	private string issuer; 
	private byte version; 
	private DateTime thisUpdate; 
	private DateTime nextUpdate; 
	private ArrayList entries; 
	private string signatureOID; 
	private byte[] signature; 
	private X509ExtensionCollection extensions; 
	private byte[] encoded; 
	private byte[] hash_value; 

	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }


	public void .ctor(byte[] crl) { }

	private void Parse(byte[] crl) { }

	public X509ExtensionCollection get_Extensions() { }

	public byte[] get_Hash() { }

	public string get_IssuerName() { }

	public DateTime get_NextUpdate() { }

	private bool Compare(byte[] array1, byte[] array2) { }

	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	internal bool VerifySignature(DSA dsa) { }

	internal bool VerifySignature(RSA rsa) { }

	public bool VerifySignature(AsymmetricAlgorithm aa) { }

}

public class X509Crl.X509CrlEntry // TypeDefIndex: 1715
{
	private byte[] sn; 
	private DateTime revocationDate; 
	private X509ExtensionCollection extensions; 

	public byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }


	internal void .ctor(ASN1 entry) { }

	public byte[] get_SerialNumber() { }

	public DateTime get_RevocationDate() { }

	public X509ExtensionCollection get_Extensions() { }

}

