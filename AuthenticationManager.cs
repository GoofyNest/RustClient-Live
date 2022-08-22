public class AuthenticationManager // TypeDefIndex: 2987
{	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10


	private static void EnsureModules() { }

	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	private static void .cctor() { }

}

