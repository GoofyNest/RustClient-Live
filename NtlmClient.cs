internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 2560
{	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x2B0AAB0

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1215C80 Offset: 0x1215080 VA: 0x181215C80 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1216080 Offset: 0x1215480 VA: 0x181216080 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1216020 Offset: 0x1215420 VA: 0x181216020
	private static void .cctor() { }

}

private sealed class NtlmClient.<>c // TypeDefIndex: 2561
{	// Fields
	public static readonly NtlmClient.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x1218B90 Offset: 0x1217F90 VA: 0x181218B90
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1218740 Offset: 0x1217B40 VA: 0x181218740
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 3017
{	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x13430C0 Offset: 0x13424C0 VA: 0x1813430C0
	public void .ctor() { }

	// RVA: 0x1342FE0 Offset: 0x13423E0 VA: 0x181342FE0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1343130 Offset: 0x1342530 VA: 0x181343130 Slot: 6
	public string get_AuthenticationType() { }

}

