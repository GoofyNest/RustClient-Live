public class PKCS7.ContentInfo // TypeDefIndex: 49
{
// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 49
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x1740680 Offset: 0x173FA80 VA: 0x181740680
	public void .ctor() { }

	// RVA: 0x1740450 Offset: 0x173F850 VA: 0x181740450
	public void .ctor(string oid) { }

	// RVA: 0x17406F0 Offset: 0x173FAF0 VA: 0x1817406F0
	public void .ctor(byte[] data) { }

	// RVA: 0x17404E0 Offset: 0x173F8E0 VA: 0x1817404E0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1740320 Offset: 0x173F720 VA: 0x181740320
	public ASN1 get_ASN1() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public ASN1 get_Content() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Content(ASN1 value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_ContentType() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_ContentType(string value) { }

	// RVA: 0x1740320 Offset: 0x173F720 VA: 0x181740320
	internal ASN1 GetASN1() { }

}

public class PKCS7.EncryptedData // TypeDefIndex: 50
{	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x1742FD0 Offset: 0x17423D0 VA: 0x181742FD0
	public void .ctor() { }

	// RVA: 0x1742FF0 Offset: 0x17423F0 VA: 0x181742FF0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1743360 Offset: 0x1742760 VA: 0x181743360
	public byte[] get_EncryptedContent() { }

}

public class PKCS7.ContentInfo // TypeDefIndex: 1708
{
// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 1708
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x1AAECF0 Offset: 0x1AAE0F0 VA: 0x181AAECF0
	public void .ctor() { }

	// RVA: 0x1AAED70 Offset: 0x1AAE170 VA: 0x181AAED70
	public void .ctor(string oid) { }

	// RVA: 0x1AAEDA0 Offset: 0x1AAE1A0 VA: 0x181AAEDA0
	public void .ctor(byte[] data) { }

	// RVA: 0x1AAEB20 Offset: 0x1AADF20 VA: 0x181AAEB20
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1AAEE10 Offset: 0x1AAE210 VA: 0x181AAEE10
	public ASN1 get_ASN1() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public ASN1 get_Content() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Content(ASN1 value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_ContentType() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_ContentType(string value) { }

	// RVA: 0x1AAE960 Offset: 0x1AADD60 VA: 0x181AAE960
	internal ASN1 GetASN1() { }

}

public class PKCS7.EncryptedData // TypeDefIndex: 1709
{	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x1742FD0 Offset: 0x17423D0 VA: 0x181742FD0
	public void .ctor() { }

	// RVA: 0x1AAF7C0 Offset: 0x1AAEBC0 VA: 0x181AAF7C0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1AAFB50 Offset: 0x1AAEF50 VA: 0x181AAFB50
	public byte[] get_EncryptedContent() { }

}

