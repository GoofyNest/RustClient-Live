public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 2838
{	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	public string SubjectKeyIdentifier { get; }


	public void .ctor() { }

	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	public void .ctor(PublicKey key, bool critical) { }

	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	public string get_SubjectKeyIdentifier() { }

	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal static byte FromHexChar(char c) { }

	internal static byte FromHexChars(char c1, char c2) { }

	internal static byte[] FromHex(string hex) { }

	internal AsnDecodeStatus Decode(byte[] extension) { }

	internal byte[] Encode() { }

	internal override string ToString(bool multiLine) { }

}

