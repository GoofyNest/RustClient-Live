public class CookieContainer // TypeDefIndex: 2944
{	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x1551B10 Offset: 0x1550F10 VA: 0x181551B10
	public void .ctor() { }

	// RVA: 0x154E800 Offset: 0x154DC00 VA: 0x18154E800
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x154E940 Offset: 0x154DD40 VA: 0x18154E940
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x154F070 Offset: 0x154E470 VA: 0x18154F070
	private bool AgeCookies(string domain) { }

	// RVA: 0x1550CB0 Offset: 0x15500B0 VA: 0x181550CB0
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x1551510 Offset: 0x1550910 VA: 0x181551510
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x1550610 Offset: 0x154FA10 VA: 0x181550610
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x1551200 Offset: 0x1550600 VA: 0x181551200
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x154FEC0 Offset: 0x154F2C0 VA: 0x18154FEC0
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x1551810 Offset: 0x1550C10 VA: 0x181551810
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x1550E20 Offset: 0x1550220 VA: 0x181550E20
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1550EE0 Offset: 0x15502E0 VA: 0x181550EE0
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x1551A10 Offset: 0x1550E10 VA: 0x181551A10
	private static void .cctor() { }

}

