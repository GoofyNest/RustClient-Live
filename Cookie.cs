public sealed class Cookie // TypeDefIndex: 2934
{	// Fields
	internal static readonly char[] PortSplitDelimiters; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x1555410 Offset: 0x1554810 VA: 0x181555410
	public void .ctor() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Comment() { }

	// RVA: 0x1555910 Offset: 0x1554D10 VA: 0x181555910
	public void set_Comment(string value) { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_CommentUri(Uri value) { }

	// RVA: 0xE89200 Offset: 0xE88600 VA: 0x180E89200
	public void set_HttpOnly(bool value) { }

	// RVA: 0x772430 Offset: 0x771830 VA: 0x180772430
	public void set_Discard(bool value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Domain() { }

	// RVA: 0x1555970 Offset: 0x1554D70 VA: 0x181555970
	public void set_Domain(string value) { }

	// RVA: 0x1555660 Offset: 0x1554A60 VA: 0x181555660
	private string get__Domain() { }

	// RVA: 0x1555590 Offset: 0x1554990 VA: 0x181555590
	public bool get_Expired() { }

	// RVA: 0xC107D0 Offset: 0xC0FBD0 VA: 0x180C107D0
	public void set_Expires(DateTime value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_Name() { }

	// RVA: 0x1553C50 Offset: 0x1553050 VA: 0x181553C50
	internal bool InternalSetName(string value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public string get_Path() { }

	// RVA: 0x1555A00 Offset: 0x1554E00 VA: 0x181555A00
	public void set_Path(string value) { }

	// RVA: 0x1555700 Offset: 0x1554B00 VA: 0x181555700
	private string get__Path() { }

	// RVA: 0x11C9310 Offset: 0x11C8710 VA: 0x1811C9310
	internal bool get_Plain() { }

	// RVA: 0x1553D60 Offset: 0x1553160 VA: 0x181553D60
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x1554400 Offset: 0x1553800 VA: 0x181554400
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x1553650 Offset: 0x1552A50 VA: 0x181553650
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x1555A70 Offset: 0x1554E70 VA: 0x181555A70
	public void set_Port(string value) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	internal int[] get_PortList() { }

	// RVA: 0x1555770 Offset: 0x1554B70 VA: 0x181555770
	private string get__Port() { }

	// RVA: 0xC2CA80 Offset: 0xC2BE80 VA: 0x180C2CA80
	public bool get_Secure() { }

	// RVA: 0xC2DBA0 Offset: 0xC2CFA0 VA: 0x180C2DBA0
	public void set_Secure(bool value) { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public string get_Value() { }

	// RVA: 0x1555E80 Offset: 0x1555280 VA: 0x181555E80
	public void set_Value(string value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal CookieVariant get_Variant() { }

	// RVA: 0x1555570 Offset: 0x1554970 VA: 0x181555570
	internal string get_DomainKey() { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	public int get_Version() { }

	// RVA: 0x1555EF0 Offset: 0x15552F0 VA: 0x181555EF0
	public void set_Version(int value) { }

	// RVA: 0x1555820 Offset: 0x1554C20 VA: 0x181555820
	private string get__Version() { }

	// RVA: 0x15537F0 Offset: 0x1552BF0 VA: 0x1815537F0
	internal static IComparer GetComparer() { }

	// RVA: 0x15536E0 Offset: 0x1552AE0 VA: 0x1815536E0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1553850 Offset: 0x1552C50 VA: 0x181553850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1553DC0 Offset: 0x15531C0 VA: 0x181553DC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x15552B0 Offset: 0x15546B0 VA: 0x1815552B0
	private static void .cctor() { }

}

