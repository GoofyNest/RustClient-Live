internal class DigestHeaderParser // TypeDefIndex: 2992
{
internal class DigestHeaderParser // TypeDefIndex: 2992
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }


	public void .ctor(string header) { }

	public string get_Realm() { }

	public string get_Opaque() { }

	public string get_Nonce() { }

	public string get_Algorithm() { }

	public string get_QOP() { }

	public bool Parse() { }

	private void SkipWhitespace() { }

	private string GetKey() { }

	private bool GetKeywordAndValue(out string key, out string value) { }

	private static void .cctor() { }

}

