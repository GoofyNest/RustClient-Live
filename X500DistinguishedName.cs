public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 2812
{	private string name; // 0x20
	private byte[] canonEncoding; // 0x28


	public void .ctor(byte[] encodedDistinguishedName) { }

	public string Decode(X500DistinguishedNameFlags flag) { }

	public override string Format(bool multiLine) { }

	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	private void DecodeRawData() { }

	private static string Canonize(string s) { }

	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

}

