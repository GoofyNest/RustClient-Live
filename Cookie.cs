public sealed class Cookie // TypeDefIndex: 2934
{
	internal static readonly char[] PortSplitDelimiters; 
	internal static readonly char[] Reserved2Name; 
	internal static readonly char[] Reserved2Value; 
	private static Comparer staticComparer; 
	private string m_comment; 
	private Uri m_commentUri; 
	private CookieVariant m_cookieVariant; 
	private bool m_discard; 
	private string m_domain; 
	private bool m_domain_implicit; 
	private DateTime m_expires; 
	private string m_name; 
	private string m_path; 
	private bool m_path_implicit; 
	private string m_port; 
	private bool m_port_implicit; 
	private int[] m_port_list; 
	private bool m_secure; 
	[OptionalFieldAttribute] 
	private bool m_httpOnly; 
	private DateTime m_timeStamp; 
	private string m_value; 
	private int m_version; 
	private string m_domainKey; 
	internal bool IsQuotedVersion; 
	internal bool IsQuotedDomain; 

	public string Comment { get; set; }
	public Uri CommentUri { set; }
	public bool HttpOnly { set; }
	public bool Discard { set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	public bool Expired { get; }
	public DateTime Expires { set; }
	public string Name { get; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { set; }
	internal int[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }


	public void .ctor() { }

	public string get_Comment() { }

	public void set_Comment(string value) { }

	public void set_CommentUri(Uri value) { }

	public void set_HttpOnly(bool value) { }

	public void set_Discard(bool value) { }

	public string get_Domain() { }

	public void set_Domain(string value) { }

	private string get__Domain() { }

	public bool get_Expired() { }

	public void set_Expires(DateTime value) { }

	public string get_Name() { }

	internal bool InternalSetName(string value) { }

	public string get_Path() { }

	public void set_Path(string value) { }

	private string get__Path() { }

	internal bool get_Plain() { }

	private static bool IsDomainEqualToHost(string domain, string host) { }

	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	private static bool DomainCharsTest(string name) { }

	public void set_Port(string value) { }

	internal int[] get_PortList() { }

	private string get__Port() { }

	public bool get_Secure() { }

	public void set_Secure(bool value) { }

	public string get_Value() { }

	public void set_Value(string value) { }

	internal CookieVariant get_Variant() { }

	internal string get_DomainKey() { }

	public int get_Version() { }

	public void set_Version(int value) { }

	private string get__Version() { }

	internal static IComparer GetComparer() { }

	public override bool Equals(object comparand) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private static void .cctor() { }

}

