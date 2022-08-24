public abstract class UriParser // TypeDefIndex: 2583
{
private const UriSyntaxFlags SchemeOnlyFlags = 16;
	private static readonly Dictionary<string, UriParser> m_Table; 
	private static Dictionary<string, UriParser> m_TempTable; 
	private UriSyntaxFlags m_Flags; 
	private UriSyntaxFlags m_UpdatableFlags; 
	private bool m_UpdatableFlagsUsed; 
private const UriSyntaxFlags c_UpdatableFlags = 33554432;
	private int m_Port; 
	private string m_Scheme; 
internal const int NoDefaultPort = -1;
private const int c_InitialTableSize = 25;
	internal static UriParser HttpUri; 
	internal static UriParser HttpsUri; 
	internal static UriParser WsUri; 
	internal static UriParser WssUri; 
	internal static UriParser FtpUri; 
	internal static UriParser FileUri; 
	internal static UriParser GopherUri; 
	internal static UriParser NntpUri; 
	internal static UriParser NewsUri; 
	internal static UriParser MailToUri; 
	internal static UriParser UuidUri; 
	internal static UriParser TelnetUri; 
	internal static UriParser LdapUri; 
	internal static UriParser NetTcpUri; 
	internal static UriParser NetPipeUri; 
	internal static UriParser VsMacrosUri; 
	private static readonly UriParser.UriQuirksVersion s_QuirksVersion; 
private const int c_MaxCapacity = 512;
private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
	private static readonly UriSyntaxFlags HttpSyntaxFlags; 
private const UriSyntaxFlags FtpSyntaxFlags = 367005533;
	private static readonly UriSyntaxFlags FileSyntaxFlags; 
private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
private const UriSyntaxFlags GopherSyntaxFlags = 337645405;
private const UriSyntaxFlags NewsSyntaxFlags = 268435536;
private const UriSyntaxFlags NntpSyntaxFlags = 337645405;
private const UriSyntaxFlags TelnetSyntaxFlags = 337645405;
private const UriSyntaxFlags LdapSyntaxFlags = 337645565;
private const UriSyntaxFlags MailtoSyntaxFlags = 335564796;
private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737;

internal string SchemeName { get; }
internal int DefaultPort { get; }
internal static bool ShouldUseLegacyV2Quirks { get; }
internal UriSyntaxFlags Flags { get; }
internal bool IsSimple { get; }


internal string get_SchemeName() { }

internal int get_DefaultPort() { }

protected virtual UriParser OnNewUri() { }

protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

protected virtual bool IsWellFormedOriginalString(Uri uri) { }

internal static bool get_ShouldUseLegacyV2Quirks() { }

private static void .cctor() { }

internal UriSyntaxFlags get_Flags() { }

internal bool NotAny(UriSyntaxFlags flags) { }

internal bool InFact(UriSyntaxFlags flags) { }

internal bool IsAllSet(UriSyntaxFlags flags) { }

private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

internal void .ctor(UriSyntaxFlags flags) { }

internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

internal static UriParser GetSyntax(string lwrCaseScheme) { }

internal bool get_IsSimple() { }

internal UriParser InternalOnNewUri() { }

internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

}

private enum UriParser.UriQuirksVersion // TypeDefIndex: 2584
{
	public int value__; 
public const UriParser.UriQuirksVersion V2 = 2;
public const UriParser.UriQuirksVersion V3 = 3;

}

private class UriParser.BuiltInUriParser : UriParser // TypeDefIndex: 2585
{

internal void .ctor(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

}

