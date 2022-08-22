public sealed class Cookie // TypeDefIndex: 2934
{	internal static readonly char[] PortSplitDelimiters; // 0x0
	internal static readonly char[] Reserved2Name; // 0x8
	internal static readonly char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

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

