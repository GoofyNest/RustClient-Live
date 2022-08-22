internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 2560
{	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x2B0AAB0

	public string AuthenticationType { get; }


	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	public string get_AuthenticationType() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class NtlmClient.<>c // TypeDefIndex: 2561
{	public static readonly NtlmClient.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession> <>9__1_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 3017
{	private IAuthenticationModule authObject; // 0x10

	public string AuthenticationType { get; }


	public void .ctor() { }

	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	public string get_AuthenticationType() { }

}

