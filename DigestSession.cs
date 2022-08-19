internal class DigestSession // TypeDefIndex: 2993
{	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x155BB60 Offset: 0x155AF60 VA: 0x18155BB60
	private static void .cctor() { }

	// RVA: 0x155BBB0 Offset: 0x155AFB0 VA: 0x18155BBB0
	public void .ctor() { }

	// RVA: 0x155BC20 Offset: 0x155B020 VA: 0x18155BC20
	public string get_Algorithm() { }

	// RVA: 0x155BE20 Offset: 0x155B220 VA: 0x18155BE20
	public string get_Realm() { }

	// RVA: 0x155BD60 Offset: 0x155B160 VA: 0x18155BD60
	public string get_Nonce() { }

	// RVA: 0x155BDA0 Offset: 0x155B1A0 VA: 0x18155BDA0
	public string get_Opaque() { }

	// RVA: 0x155BDE0 Offset: 0x155B1E0 VA: 0x18155BDE0
	public string get_QOP() { }

	// RVA: 0x155BC60 Offset: 0x155B060 VA: 0x18155BC60
	public string get_CNonce() { }

	// RVA: 0x155B620 Offset: 0x155AA20 VA: 0x18155B620
	public bool Parse(string challenge) { }

	// RVA: 0x155B4D0 Offset: 0x155A8D0 VA: 0x18155B4D0
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x155B270 Offset: 0x155A670 VA: 0x18155B270
	private string HA1(string username, string password) { }

	// RVA: 0x155B3E0 Offset: 0x155A7E0 VA: 0x18155B3E0
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x155B7C0 Offset: 0x155ABC0 VA: 0x18155B7C0
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x155AE40 Offset: 0x155A240 VA: 0x18155AE40
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public DateTime get_LastUse() { }

}

