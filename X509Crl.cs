public class X509Crl // TypeDefIndex: 1714
{	// Fields
	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0x227BD70 Offset: 0x227B170 VA: 0x18227BD70
	public void .ctor(byte[] crl) { }

	// RVA: 0x227B120 Offset: 0x227A520 VA: 0x18227B120
	private void Parse(byte[] crl) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x227BE50 Offset: 0x227B250 VA: 0x18227BE50
	public byte[] get_Hash() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_IssuerName() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public DateTime get_NextUpdate() { }

	// RVA: 0x227AE00 Offset: 0x227A200 VA: 0x18227AE00
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x227AE80 Offset: 0x227A280 VA: 0x18227AE80
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x227AF10 Offset: 0x227A310 VA: 0x18227AF10
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x227B780 Offset: 0x227AB80 VA: 0x18227B780
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x227BA20 Offset: 0x227AE20 VA: 0x18227BA20
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x227BB00 Offset: 0x227AF00 VA: 0x18227BB00
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

}

public class X509Crl.X509CrlEntry // TypeDefIndex: 1715
{	// Fields
	private byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Properties
	public byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }

	// Methods

	// RVA: 0x227AC80 Offset: 0x227A080 VA: 0x18227AC80
	internal void .ctor(ASN1 entry) { }

	// RVA: 0x227AD80 Offset: 0x227A180 VA: 0x18227AD80
	public byte[] get_SerialNumber() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public DateTime get_RevocationDate() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public X509ExtensionCollection get_Extensions() { }

}

