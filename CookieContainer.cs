public class CookieContainer // TypeDefIndex: 2944
{	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28


	public void .ctor() { }

	private void AddRemoveDomain(string key, PathList value) { }

	internal void Add(Cookie cookie, bool throwOnError) { }

	private bool AgeCookies(string domain) { }

	private int ExpireCollection(CookieCollection cc) { }

	internal bool IsLocalDomain(string host) { }

	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	internal CookieCollection InternalGetCookies(Uri uri) { }

	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	public string GetCookieHeader(Uri uri) { }

	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	private static void .cctor() { }

}

