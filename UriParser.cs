public abstract class UriParser // TypeDefIndex: 2583
{	// Fields
	private const UriSyntaxFlags SchemeOnlyFlags = 16;
	private static readonly Dictionary<string, UriParser> m_Table; // 0x0
	private static Dictionary<string, UriParser> m_TempTable; // 0x8
	private UriSyntaxFlags m_Flags; // 0x10
	private UriSyntaxFlags m_UpdatableFlags; // 0x14
	private bool m_UpdatableFlagsUsed; // 0x18
	private const UriSyntaxFlags c_UpdatableFlags = 33554432;
	private int m_Port; // 0x1C
	private string m_Scheme; // 0x20
	internal const int NoDefaultPort = -1;
	private const int c_InitialTableSize = 25;
	internal static UriParser HttpUri; // 0x10
	internal static UriParser HttpsUri; // 0x18
	internal static UriParser WsUri; // 0x20
	internal static UriParser WssUri; // 0x28
	internal static UriParser FtpUri; // 0x30
	internal static UriParser FileUri; // 0x38
	internal static UriParser GopherUri; // 0x40
	internal static UriParser NntpUri; // 0x48
	internal static UriParser NewsUri; // 0x50
	internal static UriParser MailToUri; // 0x58
	internal static UriParser UuidUri; // 0x60
	internal static UriParser TelnetUri; // 0x68
	internal static UriParser LdapUri; // 0x70
	internal static UriParser NetTcpUri; // 0x78
	internal static UriParser NetPipeUri; // 0x80
	internal static UriParser VsMacrosUri; // 0x88
	private static readonly UriParser.UriQuirksVersion s_QuirksVersion; // 0x90
	private const int c_MaxCapacity = 512;
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
	private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533;
	private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405;
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536;
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405;
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405;
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565;
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796;
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737;

	// Properties
	internal string SchemeName { get; }
	internal int DefaultPort { get; }
	internal static bool ShouldUseLegacyV2Quirks { get; }
	internal UriSyntaxFlags Flags { get; }
	internal bool IsSimple { get; }

	// Methods

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal string get_SchemeName() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	internal int get_DefaultPort() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 4
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x22B4210 Offset: 0x22B3610 VA: 0x1822B4210 Slot: 5
	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0x22B4440 Offset: 0x22B3840 VA: 0x1822B4440 Slot: 6
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0x22B3EB0 Offset: 0x22B32B0 VA: 0x1822B3EB0 Slot: 7
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x22B43C0 Offset: 0x22B37C0 VA: 0x1822B43C0 Slot: 8
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x22B5170 Offset: 0x22B4570 VA: 0x1822B5170
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x22B4640 Offset: 0x22B3A40 VA: 0x1822B4640
	private static void .cctor() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x22B43E0 Offset: 0x22B37E0 VA: 0x1822B43E0
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x22B41B0 Offset: 0x22B35B0 VA: 0x1822B41B0
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x22B42F0 Offset: 0x22B36F0 VA: 0x1822B42F0
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x22B4350 Offset: 0x22B3750 VA: 0x1822B4350
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x22B5100 Offset: 0x22B4500 VA: 0x1822B5100
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x22B3BB0 Offset: 0x22B2FB0 VA: 0x1822B3BB0
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x22B40D0 Offset: 0x22B34D0 VA: 0x1822B40D0
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x22B5160 Offset: 0x22B4560 VA: 0x1822B5160
	internal bool get_IsSimple() { }

	// RVA: 0x22B4270 Offset: 0x22B3670 VA: 0x1822B4270
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x22B42D0 Offset: 0x22B36D0 VA: 0x1822B42D0
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0x13968C0 Offset: 0x1395CC0 VA: 0x1813968C0
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0x22B4250 Offset: 0x22B3650 VA: 0x1822B4250
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0xE53EE0 Offset: 0xE532E0 VA: 0x180E53EE0
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

}

private enum UriParser.UriQuirksVersion // TypeDefIndex: 2584
{	// Fields
	public int value__; // 0x0
	public const UriParser.UriQuirksVersion V2 = 2;
	public const UriParser.UriQuirksVersion V3 = 3;

}

private class UriParser.BuiltInUriParser : UriParser // TypeDefIndex: 2585
{	// Methods

	// RVA: 0x22B0B10 Offset: 0x22AFF10 VA: 0x1822B0B10
	internal void .ctor(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

}

