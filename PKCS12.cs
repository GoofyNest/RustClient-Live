internal class PKCS12 : ICloneable // TypeDefIndex: 55
{
	private byte[] _password;
	private ArrayList _keyBags;
	private ArrayList _secretBags;
	private X509CertificateCollection _certs;
	private bool _keyBagsChanged;
	private bool _secretBagsChanged;
	private bool _certsChanged;
	private int _iterations;
	private ArrayList _safeBags;
	private RandomNumberGenerator _rng;
	private static int password_max_length;

	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }


	public void .ctor() { }

	public void .ctor(byte[] data) { }

	public void .ctor(byte[] data, string password) { }

	private void Decode(byte[] data) { }

	protected override void Finalize() { }

	public void set_Password(string value) { }

	public int get_IterationCount() { }

	public void set_IterationCount(int value) { }

	public ArrayList get_Keys() { }

	public X509CertificateCollection get_Certificates() { }

	internal RandomNumberGenerator get_RNG() { }

	private bool Compare(byte[] expected, byte[] actual) { }

	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	private DSAParameters GetExistingParameters(out bool found) { }

	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	private void ReadSafeBag(ASN1 safeBag) { }

	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	public byte[] GetBytes() { }

	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	public void AddCertificate(X509Certificate cert) { }

	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	public void RemoveCertificate(X509Certificate cert) { }

	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	public object Clone() { }

	public static int get_MaximumPasswordLength() { }

	private static void .cctor() { }

}

public class PKCS12.DeriveBytes // TypeDefIndex: 56
{
	private static byte[] keyDiversifier;
	private static byte[] ivDiversifier;
	private static byte[] macDiversifier;
	private string _hashName;
	private int _iterations;
	private byte[] _password;
	private byte[] _salt;

	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }


	public void .ctor() { }

	public void set_HashName(string value) { }

	public void set_IterationCount(int value) { }

	public void set_Password(byte[] value) { }

	public void set_Salt(byte[] value) { }

	private void Adjust(byte[] a, int aOff, byte[] b) { }

	private byte[] Derive(byte[] diversifier, int n) { }

	public byte[] DeriveKey(int size) { }

	public byte[] DeriveIV(int size) { }

	public byte[] DeriveMAC(int size) { }

	private static void .cctor() { }

}

public class PKCS12 : ICloneable // TypeDefIndex: 1711
{
	private byte[] _password;
	private ArrayList _keyBags;
	private ArrayList _secretBags;
	private X509CertificateCollection _certs;
	private bool _keyBagsChanged;
	private bool _secretBagsChanged;
	private bool _certsChanged;
	private int _iterations;
	private ArrayList _safeBags;
	private RandomNumberGenerator _rng;
	private static int password_max_length;

	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }


	public void .ctor() { }

	public void .ctor(byte[] data) { }

	public void .ctor(byte[] data, string password) { }

	private void Decode(byte[] data) { }

	protected override void Finalize() { }

	public void set_Password(string value) { }

	public int get_IterationCount() { }

	public void set_IterationCount(int value) { }

	public ArrayList get_Keys() { }

	public X509CertificateCollection get_Certificates() { }

	internal RandomNumberGenerator get_RNG() { }

	private bool Compare(byte[] expected, byte[] actual) { }

	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	private DSAParameters GetExistingParameters(out bool found) { }

	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	private void ReadSafeBag(ASN1 safeBag) { }

	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	public byte[] GetBytes() { }

	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	public void AddCertificate(X509Certificate cert) { }

	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	public void RemoveCertificate(X509Certificate cert) { }

	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	public object Clone() { }

	public static int get_MaximumPasswordLength() { }

	private static void .cctor() { }

}

public class PKCS12.DeriveBytes // TypeDefIndex: 1712
{
	private static byte[] keyDiversifier;
	private static byte[] ivDiversifier;
	private static byte[] macDiversifier;
	private string _hashName;
	private int _iterations;
	private byte[] _password;
	private byte[] _salt;

	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }


	public void .ctor() { }

	public void set_HashName(string value) { }

	public void set_IterationCount(int value) { }

	public void set_Password(byte[] value) { }

	public void set_Salt(byte[] value) { }

	private void Adjust(byte[] a, int aOff, byte[] b) { }

	private byte[] Derive(byte[] diversifier, int n) { }

	public byte[] DeriveKey(int size) { }

	public byte[] DeriveIV(int size) { }

	public byte[] DeriveMAC(int size) { }

	private static void .cctor() { }

}

