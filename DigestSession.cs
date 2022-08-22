internal class DigestSession // TypeDefIndex: 2993
{	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }


	private static void .cctor() { }

	public void .ctor() { }

	public string get_Algorithm() { }

	public string get_Realm() { }

	public string get_Nonce() { }

	public string get_Opaque() { }

	public string get_QOP() { }

	public string get_CNonce() { }

	public bool Parse(string challenge) { }

	private string HashToHexString(string toBeHashed) { }

	private string HA1(string username, string password) { }

	private string HA2(HttpWebRequest webRequest) { }

	private string Response(string username, string password, HttpWebRequest webRequest) { }

	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	public DateTime get_LastUse() { }

}

