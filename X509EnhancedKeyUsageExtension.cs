public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 2830
{
	private OidCollection _enhKeyUsage;
	private AsnDecodeStatus _status;


	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal AsnDecodeStatus Decode(byte[] extension) { }

	internal override string ToString(bool multiLine) { }

}

