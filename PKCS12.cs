internal class PKCS12 : ICloneable // TypeDefIndex: 55
{	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x174CCD0 Offset: 0x174C0D0 VA: 0x18174CCD0
	public void .ctor() { }

	// RVA: 0x174CC00 Offset: 0x174C000 VA: 0x18174CC00
	public void .ctor(byte[] data) { }

	// RVA: 0x174CC80 Offset: 0x174C080 VA: 0x18174CC80
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1748320 Offset: 0x1747720 VA: 0x181748320
	private void Decode(byte[] data) { }

	// RVA: 0x17492F0 Offset: 0x17486F0 VA: 0x1817492F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x174D7D0 Offset: 0x174CBD0 VA: 0x18174D7D0
	public void set_Password(string value) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public int get_IterationCount() { }

	// RVA: 0xD6ED70 Offset: 0xD6E170 VA: 0x180D6ED70
	public void set_IterationCount(int value) { }

	// RVA: 0x174D0F0 Offset: 0x174C4F0 VA: 0x18174D0F0
	public ArrayList get_Keys() { }

	// RVA: 0x174CDC0 Offset: 0x174C1C0 VA: 0x18174CDC0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x174D790 Offset: 0x174CB90 VA: 0x18174D790
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x17482A0 Offset: 0x17476A0 VA: 0x1817482A0
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x174B4C0 Offset: 0x174A8C0 VA: 0x18174B4C0
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1748B30 Offset: 0x1747F30 VA: 0x181748B30
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1748C80 Offset: 0x1748080 VA: 0x181748C80
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1748DB0 Offset: 0x17481B0 VA: 0x181748DB0
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x174B1F0 Offset: 0x174A5F0 VA: 0x18174B1F0
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1747660 Offset: 0x1746A60 VA: 0x181747660
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x174BF50 Offset: 0x174B350 VA: 0x18174BF50
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x17477D0 Offset: 0x1746BD0 VA: 0x1817477D0
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x174BCE0 Offset: 0x174B0E0 VA: 0x18174BCE0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x17493A0 Offset: 0x17487A0 VA: 0x1817493A0
	public byte[] GetBytes() { }

	// RVA: 0x1748F00 Offset: 0x1748300 VA: 0x181748F00
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1747340 Offset: 0x1746740 VA: 0x181747340
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1747350 Offset: 0x1746750 VA: 0x181747350
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x174C630 Offset: 0x174BA30 VA: 0x18174C630
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x174C640 Offset: 0x174BA40 VA: 0x18174C640
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1748160 Offset: 0x1747560 VA: 0x181748160 Slot: 4
	public object Clone() { }

	// RVA: 0x174D6D0 Offset: 0x174CAD0 VA: 0x18174D6D0
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x174CBC0 Offset: 0x174BFC0 VA: 0x18174CBC0
	private static void .cctor() { }

}

public class PKCS12.DeriveBytes // TypeDefIndex: 56
{	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_HashName(string value) { }

	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_IterationCount(int value) { }

	// RVA: 0x1742E80 Offset: 0x1742280 VA: 0x181742E80
	public void set_Password(byte[] value) { }

	// RVA: 0x1742F30 Offset: 0x1742330 VA: 0x181742F30
	public void set_Salt(byte[] value) { }

	// RVA: 0x1742660 Offset: 0x1741A60 VA: 0x181742660
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x17428D0 Offset: 0x1741CD0 VA: 0x1817428D0
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x17427D0 Offset: 0x1741BD0 VA: 0x1817427D0
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1742750 Offset: 0x1741B50 VA: 0x181742750
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1742850 Offset: 0x1741C50 VA: 0x181742850
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1742D90 Offset: 0x1742190 VA: 0x181742D90
	private static void .cctor() { }

}

public class PKCS12 : ICloneable // TypeDefIndex: 1711
{	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x1ABAA70 Offset: 0x1AB9E70 VA: 0x181ABAA70
	public void .ctor() { }

	// RVA: 0x1ABAB60 Offset: 0x1AB9F60 VA: 0x181ABAB60
	public void .ctor(byte[] data) { }

	// RVA: 0x1ABAA20 Offset: 0x1AB9E20 VA: 0x181ABAA20
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1AB58A0 Offset: 0x1AB4CA0 VA: 0x181AB58A0
	private void Decode(byte[] data) { }

	// RVA: 0x17492F0 Offset: 0x17486F0 VA: 0x1817492F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1ABB5B0 Offset: 0x1ABA9B0 VA: 0x181ABB5B0
	public void set_Password(string value) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public int get_IterationCount() { }

	// RVA: 0xD6ED70 Offset: 0xD6E170 VA: 0x180D6ED70
	public void set_IterationCount(int value) { }

	// RVA: 0x1ABAF10 Offset: 0x1ABA310 VA: 0x181ABAF10
	public ArrayList get_Keys() { }

	// RVA: 0x1ABABE0 Offset: 0x1AB9FE0 VA: 0x181ABABE0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x174D790 Offset: 0x174CB90 VA: 0x18174D790
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x17482A0 Offset: 0x17476A0 VA: 0x1817482A0
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1AB9440 Offset: 0x1AB8840 VA: 0x181AB9440
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1AB6110 Offset: 0x1AB5510 VA: 0x181AB6110
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1AB6260 Offset: 0x1AB5660 VA: 0x181AB6260
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1AB6390 Offset: 0x1AB5790 VA: 0x181AB6390
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1AB9210 Offset: 0x1AB8610 VA: 0x181AB9210
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1AB49C0 Offset: 0x1AB3DC0 VA: 0x181AB49C0
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1AB9CD0 Offset: 0x1AB90D0 VA: 0x181AB9CD0
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1AB4B30 Offset: 0x1AB3F30 VA: 0x181AB4B30
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1AB9A60 Offset: 0x1AB8E60 VA: 0x181AB9A60
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1AB6D10 Offset: 0x1AB6110 VA: 0x181AB6D10
	public byte[] GetBytes() { }

	// RVA: 0x1AB64E0 Offset: 0x1AB58E0 VA: 0x181AB64E0
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1AB49B0 Offset: 0x1AB3DB0 VA: 0x181AB49B0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1AB46C0 Offset: 0x1AB3AC0 VA: 0x181AB46C0
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1ABA3D0 Offset: 0x1AB97D0 VA: 0x181ABA3D0
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1ABA3E0 Offset: 0x1AB97E0 VA: 0x181ABA3E0
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1AB5760 Offset: 0x1AB4B60 VA: 0x181AB5760 Slot: 4
	public object Clone() { }

	// RVA: 0x1ABB4F0 Offset: 0x1ABA8F0 VA: 0x181ABB4F0
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1ABA9E0 Offset: 0x1AB9DE0 VA: 0x181ABA9E0
	private static void .cctor() { }

}

public class PKCS12.DeriveBytes // TypeDefIndex: 1712
{	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_HashName(string value) { }

	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_IterationCount(int value) { }

	// RVA: 0x1AAF670 Offset: 0x1AAEA70 VA: 0x181AAF670
	public void set_Password(byte[] value) { }

	// RVA: 0x1AAF720 Offset: 0x1AAEB20 VA: 0x181AAF720
	public void set_Salt(byte[] value) { }

	// RVA: 0x1742660 Offset: 0x1741A60 VA: 0x181742660
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1AAF0C0 Offset: 0x1AAE4C0 VA: 0x181AAF0C0
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1AAEFC0 Offset: 0x1AAE3C0 VA: 0x181AAEFC0
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1AAEF40 Offset: 0x1AAE340 VA: 0x181AAEF40
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1AAF040 Offset: 0x1AAE440 VA: 0x181AAF040
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1AAF580 Offset: 0x1AAE980 VA: 0x181AAF580
	private static void .cctor() { }

}

