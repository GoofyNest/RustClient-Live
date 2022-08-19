internal class BasicClient : IAuthenticationModule // TypeDefIndex: 2988
{	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x154C380 Offset: 0x154B780 VA: 0x18154C380 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x154C430 Offset: 0x154B830 VA: 0x18154C430
	private static byte[] GetBytes(string str) { }

	// RVA: 0x154C4D0 Offset: 0x154B8D0 VA: 0x18154C4D0
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x154C8B0 Offset: 0x154BCB0 VA: 0x18154C8B0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x154C8D0 Offset: 0x154BCD0 VA: 0x18154C8D0 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

