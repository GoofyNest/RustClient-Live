internal class Uri // TypeDefIndex: 52
{	private bool isUnixFilePath; // 0x10
	private string source; // 0x18
	private string scheme; // 0x20
	private string host; // 0x28
	private int port; // 0x30
	private string path; // 0x38
	private string query; // 0x40
	private string fragment; // 0x48
	private string userinfo; // 0x50
	private bool isUnc; // 0x58
	private bool isOpaquePart; // 0x59
	private bool userEscaped; // 0x5A
	private string cachedToString; // 0x60
	private string cachedLocalPath; // 0x68
	private int cachedHashCode; // 0x70
	private bool reduce; // 0x74
	private static readonly string hexUpperChars; // 0x0
	public static readonly string SchemeDelimiter; // 0x8
	public static readonly string UriSchemeFile; // 0x10
	public static readonly string UriSchemeFtp; // 0x18
	public static readonly string UriSchemeGopher; // 0x20
	public static readonly string UriSchemeHttp; // 0x28
	public static readonly string UriSchemeHttps; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	private static Uri.UriScheme[] schemes; // 0x50

	public string AbsolutePath { get; }
	public bool IsFile { get; }
	public bool IsUnc { get; }
	public string LocalPath { get; }


	public void .ctor(string uriString) { }

	public void .ctor(string uriString, bool dontEscape) { }

	public string get_AbsolutePath() { }

	public bool get_IsFile() { }

	public bool get_IsUnc() { }

	public string get_LocalPath() { }

	public override bool Equals(object comparant) { }

	public override int GetHashCode() { }

	public string GetLeftPart(UriPartial part) { }

	public static int FromHex(char digit) { }

	public static string HexEscape(char character) { }

	public static char HexUnescape(string pattern, ref int index) { }

	public static bool IsHexDigit(char digit) { }

	public static bool IsHexEncoding(string pattern, int index) { }

	public override string ToString() { }

	protected static string EscapeString(string str) { }

	internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets) { }

	protected void Parse() { }

	protected string Unescape(string str) { }

	internal string Unescape(string str, bool excludeSharp) { }

	private void ParseAsWindowsUNC(string uriString) { }

	private void ParseAsWindowsAbsoluteFilePath(string uriString) { }

	private void ParseAsUnixAbsoluteFilePath(string uriString) { }

	private void Parse(string uriString) { }

	private static string Reduce(string path) { }

	internal static string GetSchemeDelimiter(string scheme) { }

	internal static int GetDefaultPort(string scheme) { }

	private string GetOpaqueWiseSchemeDelimiter() { }

	private static bool IsPredefinedScheme(string scheme) { }

	private static void .cctor() { }

}

private struct Uri.UriScheme // TypeDefIndex: 53
{	public string scheme; // 0x0
	public string delimiter; // 0x8
	public int defaultPort; // 0x10


	public void .ctor(string s, string d, int p) { }

}

public class Uri : ISerializable // TypeDefIndex: 2568
{	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }


	private bool get_IsImplicitFile() { }

	private bool get_IsUncOrDosPath() { }

	private bool get_IsDosPath() { }

	private bool get_IsUncPath() { }

	private Uri.Flags get_HostType() { }

	private UriParser get_Syntax() { }

	private bool get_IsNotAbsoluteUri() { }

	internal static bool IriParsingStatic(UriParser syntax) { }

	private bool get_AllowIdn() { }

	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	private bool IsIntranet(string schemeHost) { }

	internal bool get_UserDrivenParsing() { }

	private void SetUserDrivenParsing() { }

	private ushort get_SecuredPathIndex() { }

	private bool NotAny(Uri.Flags flags) { }

	private bool InFact(Uri.Flags flags) { }

	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	private Uri.UriInfo EnsureUriInfo() { }

	private void EnsureParseRemaining() { }

	private void EnsureHostString(bool allowDnsOptimization) { }

	public void .ctor(string uriString) { }

	public void .ctor(string uriString, UriKind uriKind) { }

	public void .ctor(Uri baseUri, string relativeUri) { }

	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	public void .ctor(Uri baseUri, Uri relativeUri) { }

	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	private static UriFormatException GetException(ParsingError err) { }

	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public string get_AbsolutePath() { }

	private string get_PrivateAbsolutePath() { }

	public string get_AbsoluteUri() { }

	public string get_LocalPath() { }

	public string get_Authority() { }

	public UriHostNameType get_HostNameType() { }

	public bool get_IsDefaultPort() { }

	public bool get_IsFile() { }

	public bool get_IsLoopback() { }

	public string get_PathAndQuery() { }

	public bool get_IsUnc() { }

	public string get_Host() { }

	private static bool StaticIsFile(UriParser syntax) { }

	private static object get_InitializeLock() { }

	private static void InitializeUriConfig() { }

	private string GetLocalPath() { }

	public int get_Port() { }

	public string get_Query() { }

	public string get_Fragment() { }

	public string get_Scheme() { }

	private bool get_OriginalStringSwitched() { }

	public string get_OriginalString() { }

	public string get_DnsSafeHost() { }

	public bool get_IsAbsoluteUri() { }

	public bool get_UserEscaped() { }

	public string get_UserInfo() { }

	internal static bool IsGenDelim(char ch) { }

	public static bool CheckSchemeName(string schemeName) { }

	public static bool IsHexDigit(char character) { }

	public static int FromHex(char digit) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public static bool op_Equality(Uri uri1, Uri uri2) { }

	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	public override bool Equals(object comparand) { }

	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	internal static string InternalEscapeString(string rawString) { }

	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	internal UriFormatException ParseMinimal() { }

	private ParsingError PrivateParseMinimal() { }

	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	private void CreateUriInfo(Uri.Flags cF) { }

	private void CreateHostString() { }

	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	private void GetHostViaCustomSyntax() { }

	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	private string GetEscapedParts(UriComponents uriParts) { }

	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	private void ParseRemaining() { }

	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	internal bool get_HasAuthority() { }

	private static bool IsLWS(char ch) { }

	private static bool IsAsciiLetter(char character) { }

	internal static bool IsAsciiLetterOrDigit(char character) { }

	internal static bool IsBidiControlCharacter(char ch) { }

	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	private bool CheckForConfigLoad(string data) { }

	private bool CheckForUnicode(string data) { }

	private bool CheckForEscapedUnreserved(string data) { }

	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	public string GetComponents(UriComponents components, UriFormat format) { }

	public bool IsWellFormedOriginalString() { }

	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	internal bool InternalIsWellFormedOriginalString() { }

	public static string UnescapeDataString(string stringToUnescape) { }

	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	private string GetRelativeSerializationString(UriFormat format) { }

	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	private void CreateThisFromUri(Uri otherUri) { }

	private static void .cctor() { }

}

private enum Uri.Flags // TypeDefIndex: 2569
{	public ulong value__; // 0x0
	public const Uri.Flags Zero = 0;
	public const Uri.Flags SchemeNotCanonical = 1;
	public const Uri.Flags UserNotCanonical = 2;
	public const Uri.Flags HostNotCanonical = 4;
	public const Uri.Flags PortNotCanonical = 8;
	public const Uri.Flags PathNotCanonical = 16;
	public const Uri.Flags QueryNotCanonical = 32;
	public const Uri.Flags FragmentNotCanonical = 64;
	public const Uri.Flags CannotDisplayCanonical = 127;
	public const Uri.Flags E_UserNotCanonical = 128;
	public const Uri.Flags E_HostNotCanonical = 256;
	public const Uri.Flags E_PortNotCanonical = 512;
	public const Uri.Flags E_PathNotCanonical = 1024;
	public const Uri.Flags E_QueryNotCanonical = 2048;
	public const Uri.Flags E_FragmentNotCanonical = 4096;
	public const Uri.Flags E_CannotDisplayCanonical = 8064;
	public const Uri.Flags ShouldBeCompressed = 8192;
	public const Uri.Flags FirstSlashAbsent = 16384;
	public const Uri.Flags BackslashInPath = 32768;
	public const Uri.Flags IndexMask = 65535;
	public const Uri.Flags HostTypeMask = 458752;
	public const Uri.Flags HostNotParsed = 0;
	public const Uri.Flags IPv6HostType = 65536;
	public const Uri.Flags IPv4HostType = 131072;
	public const Uri.Flags DnsHostType = 196608;
	public const Uri.Flags UncHostType = 262144;
	public const Uri.Flags BasicHostType = 327680;
	public const Uri.Flags UnusedHostType = 393216;
	public const Uri.Flags UnknownHostType = 458752;
	public const Uri.Flags UserEscaped = 524288;
	public const Uri.Flags AuthorityFound = 1048576;
	public const Uri.Flags HasUserInfo = 2097152;
	public const Uri.Flags LoopbackHost = 4194304;
	public const Uri.Flags NotDefaultPort = 8388608;
	public const Uri.Flags UserDrivenParsing = 16777216;
	public const Uri.Flags CanonicalDnsHost = 33554432;
	public const Uri.Flags ErrorOrParsingRecursion = 67108864;
	public const Uri.Flags DosPath = 134217728;
	public const Uri.Flags UncPath = 268435456;
	public const Uri.Flags ImplicitFile = 536870912;
	public const Uri.Flags MinimalUriInfoSet = 1073741824;
	public const Uri.Flags AllUriInfoSet = 2147483648;
	public const Uri.Flags IdnHost = 4294967296;
	public const Uri.Flags HasUnicode = 8589934592;
	public const Uri.Flags HostUnicodeNormalized = 17179869184;
	public const Uri.Flags RestUnicodeNormalized = 34359738368;
	public const Uri.Flags UnicodeHost = 68719476736;
	public const Uri.Flags IntranetUri = 137438953472;
	public const Uri.Flags UseOrigUncdStrOffset = 274877906944;
	public const Uri.Flags UserIriCanonical = 549755813888;
	public const Uri.Flags PathIriCanonical = 1099511627776;
	public const Uri.Flags QueryIriCanonical = 2199023255552;
	public const Uri.Flags FragmentIriCanonical = 4398046511104;
	public const Uri.Flags IriCanonical = 8246337208320;
	public const Uri.Flags CompressedSlashes = 17592186044416;

}

private class Uri.UriInfo // TypeDefIndex: 2570
{	public string Host; // 0x10
	public string ScopeId; // 0x18
	public string String; // 0x20
	public Uri.Offset Offset; // 0x28
	public string DnsSafeHost; // 0x38
	public Uri.MoreInfo MoreInfo; // 0x40


	public void .ctor() { }

}

private struct Uri.Offset // TypeDefIndex: 2571
{	public ushort Scheme; // 0x0
	public ushort User; // 0x2
	public ushort Host; // 0x4
	public ushort PortValue; // 0x6
	public ushort Path; // 0x8
	public ushort Query; // 0xA
	public ushort Fragment; // 0xC
	public ushort End; // 0xE

}

private class Uri.MoreInfo // TypeDefIndex: 2572
{	public string Path; // 0x10
	public string Query; // 0x18
	public string Fragment; // 0x20
	public string AbsoluteUri; // 0x28
	public int Hash; // 0x30
	public string RemoteUrl; // 0x38


	public void .ctor() { }

}

private enum Uri.Check // TypeDefIndex: 2573
{	public int value__; // 0x0
	public const Uri.Check None = 0;
	public const Uri.Check EscapedCanonical = 1;
	public const Uri.Check DisplayCanonical = 2;
	public const Uri.Check DotSlashAttn = 4;
	public const Uri.Check DotSlashEscaped = 128;
	public const Uri.Check BackslashInPath = 16;
	public const Uri.Check ReservedFound = 32;
	public const Uri.Check NotIriCanonical = 64;
	public const Uri.Check FoundNonAscii = 8;

}

