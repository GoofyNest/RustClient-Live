public class AuthenticationManager // TypeDefIndex: 2987
{	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x154BBD0 Offset: 0x154AFD0 VA: 0x18154BBD0
	private static void EnsureModules() { }

	// RVA: 0x154B780 Offset: 0x154AB80 VA: 0x18154B780
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x154B8A0 Offset: 0x154ACA0 VA: 0x18154B8A0
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x154BE40 Offset: 0x154B240 VA: 0x18154BE40
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x154C1D0 Offset: 0x154B5D0 VA: 0x18154C1D0
	private static void .cctor() { }

}

