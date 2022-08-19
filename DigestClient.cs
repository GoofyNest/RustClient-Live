internal class DigestClient : IAuthenticationModule // TypeDefIndex: 2994
{	// Fields
	private static readonly Hashtable cache; // 0x13944

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x155A2A0 Offset: 0x15596A0 VA: 0x18155A2A0
	private static Hashtable get_Cache() { }

	// RVA: 0x1559AC0 Offset: 0x1558EC0 VA: 0x181559AC0
	private static void CheckExpired(int count) { }

	// RVA: 0x1559790 Offset: 0x1558B90 VA: 0x181559790 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x155A050 Offset: 0x1559450 VA: 0x18155A050 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x155A270 Offset: 0x1559670 VA: 0x18155A270 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x155A200 Offset: 0x1559600 VA: 0x18155A200
	private static void .cctor() { }

}

