public class PKCS7.ContentInfo // TypeDefIndex: 49
{

public class PKCS7.ContentInfo 
	private string contentType; 
	private ASN1 content; 

	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }


	public void .ctor() { }

	public void .ctor(string oid) { }

	public void .ctor(byte[] data) { }

	public void .ctor(ASN1 asn1) { }

	public ASN1 get_ASN1() { }

	public ASN1 get_Content() { }

	public void set_Content(ASN1 value) { }

	public string get_ContentType() { }

	public void set_ContentType(string value) { }

	internal ASN1 GetASN1() { }

}

public class PKCS7.EncryptedData // TypeDefIndex: 50
{
	private byte _version; 
	private PKCS7.ContentInfo _content; 
	private PKCS7.ContentInfo _encryptionAlgorithm; 
	private byte[] _encrypted; 

	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }


	public void .ctor() { }

	public void .ctor(ASN1 asn1) { }

	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	public byte[] get_EncryptedContent() { }

}

public class PKCS7.ContentInfo // TypeDefIndex: 1708
{

public class PKCS7.ContentInfo 
	private string contentType; 
	private ASN1 content; 

	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }


	public void .ctor() { }

	public void .ctor(string oid) { }

	public void .ctor(byte[] data) { }

	public void .ctor(ASN1 asn1) { }

	public ASN1 get_ASN1() { }

	public ASN1 get_Content() { }

	public void set_Content(ASN1 value) { }

	public string get_ContentType() { }

	public void set_ContentType(string value) { }

	internal ASN1 GetASN1() { }

}

public class PKCS7.EncryptedData // TypeDefIndex: 1709
{
	private byte _version; 
	private PKCS7.ContentInfo _content; 
	private PKCS7.ContentInfo _encryptionAlgorithm; 
	private byte[] _encrypted; 

	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }


	public void .ctor() { }

	public void .ctor(ASN1 asn1) { }

	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	public byte[] get_EncryptedContent() { }

}

