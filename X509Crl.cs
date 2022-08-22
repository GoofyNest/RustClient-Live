public class X509Crl // TypeDefIndex: 1714
{	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

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
{	private byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	public byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }


	internal void .ctor(ASN1 entry) { }

	public byte[] get_SerialNumber() { }

	public DateTime get_RevocationDate() { }

	public X509ExtensionCollection get_Extensions() { }

}

