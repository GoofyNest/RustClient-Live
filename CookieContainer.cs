public class CookieContainer // TypeDefIndex: 2944
{
	private static readonly HeaderVariantInfo[] HeaderInfo;
	private Hashtable m_domainTable;
	private int m_maxCookieSize;
	private int m_maxCookies;
	private int m_maxCookiesPerDomain;
	private int m_count;
	private string m_fqdnMyDomain;


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

