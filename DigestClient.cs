internal class DigestClient : IAuthenticationModule // TypeDefIndex: 2994
{
	private static readonly Hashtable cache; 

	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }


	private static Hashtable get_Cache() { }

	private static void CheckExpired(int count) { }

	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	public string get_AuthenticationType() { }

	public void .ctor() { }

	private static void .cctor() { }

}

