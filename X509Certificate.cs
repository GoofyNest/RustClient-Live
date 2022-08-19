internal class X509Certificate : ISerializable // TypeDefIndex: 58
{	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private RSA _rsa; // 0x80
	private DSA _dsa; // 0x88
	private int version; // 0x90
	private byte[] serialnumber; // 0x98
	private byte[] issuerUniqueID; // 0xA0
	private byte[] subjectUniqueID; // 0xA8
	private X509ExtensionCollection extensions; // 0xB0
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; }
	public virtual string IssuerName { get; }
	public virtual byte[] KeyAlgorithmParameters { get; }
	public virtual RSA RSA { get; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }

	// Methods

	// RVA: 0x1758A10 Offset: 0x1757E10 VA: 0x181758A10
	private void Parse(byte[] data) { }

	// RVA: 0x1759300 Offset: 0x1758700 VA: 0x181759300
	public void .ctor(byte[] data) { }

	// RVA: 0x1758850 Offset: 0x1757C50 VA: 0x181758850
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x1759530 Offset: 0x1758930 VA: 0x181759530
	public DSA get_DSA() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x1759890 Offset: 0x1758C90 VA: 0x181759890 Slot: 6
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x1759910 Offset: 0x1758D10 VA: 0x181759910 Slot: 7
	public virtual RSA get_RSA() { }

	// RVA: 0x1759B10 Offset: 0x1758F10 VA: 0x181759B10 Slot: 8
	public virtual byte[] get_RawData() { }

	// RVA: 0x1759B90 Offset: 0x1758F90 VA: 0x181759B90 Slot: 9
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 10
	public virtual string get_SubjectName() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 11
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 12
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public ASN1 GetIssuerName() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public ASN1 GetSubjectName() { }

	// RVA: 0x17587F0 Offset: 0x1757BF0 VA: 0x1817587F0 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1758900 Offset: 0x1757D00 VA: 0x181758900
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x17592B0 Offset: 0x17586B0 VA: 0x1817592B0
	private static void .cctor() { }

}

public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 1017
{	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x17C6DE0 Offset: 0x17C61E0 VA: 0x1817C6DE0
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x17C6A60 Offset: 0x17C5E60 VA: 0x1817C6A60
	public void .ctor(byte[] data) { }

	// RVA: 0x17C6C60 Offset: 0x17C6060 VA: 0x1817C6C60
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x17C6AB0 Offset: 0x17C5EB0 VA: 0x1817C6AB0
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x17C67C0 Offset: 0x17C5BC0 VA: 0x1817C67C0
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x17C6E40 Offset: 0x17C6240 VA: 0x1817C6E40
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x17C6EB0 Offset: 0x17C62B0 VA: 0x1817C6EB0
	internal bool get_IsValid() { }

	// RVA: 0x17C6450 Offset: 0x17C5850 VA: 0x1817C6450 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x17C6560 Offset: 0x17C5960 VA: 0x1817C6560 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x17C6530 Offset: 0x17C5930 VA: 0x1817C6530 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x17C65E0 Offset: 0x17C59E0 VA: 0x1817C65E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17C6640 Offset: 0x17C5A40 VA: 0x1817C6640 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x17C6730 Offset: 0x17C5B30 VA: 0x1817C6730 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x17C66D0 Offset: 0x17C5AD0 VA: 0x1817C66D0 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x17C69F0 Offset: 0x17C5DF0 VA: 0x1817C69F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17C6A00 Offset: 0x17C5E00 VA: 0x1817C6A00 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x17C6CF0 Offset: 0x17C60F0 VA: 0x1817C6CF0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17C6ED0 Offset: 0x17C62D0 VA: 0x1817C6ED0
	public string get_Issuer() { }

	// RVA: 0x17C6F80 Offset: 0x17C6380 VA: 0x1817C6F80
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17C63B0 Offset: 0x17C57B0 VA: 0x1817C63B0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0xCC750 Offset: 0xCBB50 VA: 0x1800CC750
	[MonoTODOAttribute] // RVA: 0xCC750 Offset: 0xCBB50 VA: 0x1800CC750
	// RVA: 0x17C6800 Offset: 0x17C5C00 VA: 0x1817C6800 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xCC890 Offset: 0xCBC90 VA: 0x1800CC890
	[ComVisibleAttribute] // RVA: 0xCC890 Offset: 0xCBC90 VA: 0x1800CC890
	// RVA: 0x118D4A0 Offset: 0x118C8A0 VA: 0x18118D4A0 Slot: 15
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17C6930 Offset: 0x17C5D30 VA: 0x1817C6930 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17C6370 Offset: 0x17C5770 VA: 0x1817C6370 Slot: 6
	public void Dispose() { }

	// RVA: 0x17C6390 Offset: 0x17C5790 VA: 0x1817C6390 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17C6870 Offset: 0x17C5C70 VA: 0x1817C6870 Slot: 17
	public virtual void Reset() { }

}

public class X509Certificate : ISerializable // TypeDefIndex: 1716
{	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SignatureAlgorithm { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x2278EF0 Offset: 0x22782F0 VA: 0x182278EF0
	private void Parse(byte[] data) { }

	// RVA: 0x2279CB0 Offset: 0x22790B0 VA: 0x182279CB0
	public void .ctor(byte[] data) { }

	// RVA: 0x2278D30 Offset: 0x2278130 VA: 0x182278D30
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x2279EE0 Offset: 0x22792E0 VA: 0x182279EE0
	public DSA get_DSA() { }

	// RVA: 0x227ABE0 Offset: 0x2279FE0 VA: 0x18227ABE0
	public void set_DSA(DSA value) { }

	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x227A240 Offset: 0x2279640 VA: 0x18227A240
	public byte[] get_Hash() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x227A470 Offset: 0x2279870 VA: 0x18227A470 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x227A4F0 Offset: 0x22798F0 VA: 0x18227A4F0 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x227A570 Offset: 0x2279970 VA: 0x18227A570 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x227AC30 Offset: 0x227A030 VA: 0x18227AC30 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x227A770 Offset: 0x2279B70 VA: 0x18227A770 Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x227A7F0 Offset: 0x2279BF0 VA: 0x18227A7F0 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x227A870 Offset: 0x2279C70 VA: 0x18227A870 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 15
	public virtual string get_SignatureAlgorithm() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 16
	public virtual string get_SubjectName() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 17
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 18
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0xB96A00 Offset: 0xB95E00 VA: 0x180B96A00
	public int get_Version() { }

	// RVA: 0x22797B0 Offset: 0x2278BB0 VA: 0x1822797B0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x2279B50 Offset: 0x2278F50 VA: 0x182279B50
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x2279870 Offset: 0x2278C70 VA: 0x182279870
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public ASN1 GetIssuerName() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public ASN1 GetSubjectName() { }

	// RVA: 0x2278CD0 Offset: 0x22780D0 VA: 0x182278CD0 Slot: 19
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2278DE0 Offset: 0x22781E0 VA: 0x182278DE0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x2279C60 Offset: 0x2279060 VA: 0x182279C60
	private static void .cctor() { }

}

