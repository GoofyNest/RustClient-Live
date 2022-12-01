public class AuthenticationManager // TypeDefIndex: 2987
{
	private static ArrayList modules;
	private static object locker;
	private static ICredentialPolicy credential_policy;


	private static void EnsureModules() { }

	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	private static void .cctor() { }

}

