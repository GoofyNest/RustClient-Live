internal class Uri // TypeDefIndex: 52
{	// Fields
	private bool isUnixFilePath; // 0x10
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

	// Properties
	public string AbsolutePath { get; }
	public bool IsFile { get; }
	public bool IsUnc { get; }
	public string LocalPath { get; }

	// Methods

	// RVA: 0x1756FC0 Offset: 0x17563C0 VA: 0x181756FC0
	public void .ctor(string uriString) { }

	// RVA: 0x1756E90 Offset: 0x1756290 VA: 0x181756E90
	public void .ctor(string uriString, bool dontEscape) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_AbsolutePath() { }

	// RVA: 0x17570E0 Offset: 0x17564E0 VA: 0x1817570E0
	public bool get_IsFile() { }

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_IsUnc() { }

	// RVA: 0x1757150 Offset: 0x1756550 VA: 0x181757150
	public string get_LocalPath() { }

	// RVA: 0x1753210 Offset: 0x1752610 VA: 0x181753210 Slot: 0
	public override bool Equals(object comparant) { }

	// RVA: 0x1753CF0 Offset: 0x17530F0 VA: 0x181753CF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1753DE0 Offset: 0x17531E0 VA: 0x181753DE0
	public string GetLeftPart(UriPartial part) { }

	// RVA: 0x1753AF0 Offset: 0x1752EF0 VA: 0x181753AF0
	public static int FromHex(char digit) { }

	// RVA: 0x17545D0 Offset: 0x17539D0 VA: 0x1817545D0
	public static string HexEscape(char character) { }

	// RVA: 0x1754700 Offset: 0x1753B00 VA: 0x181754700
	public static char HexUnescape(string pattern, ref int index) { }

	// RVA: 0x17549F0 Offset: 0x1753DF0 VA: 0x1817549F0
	public static bool IsHexDigit(char digit) { }

	// RVA: 0x1754A20 Offset: 0x1753E20 VA: 0x181754A20
	public static bool IsHexEncoding(string pattern, int index) { }

	// RVA: 0x1756660 Offset: 0x1755A60 VA: 0x181756660 Slot: 3
	public override string ToString() { }

	// RVA: 0x1753810 Offset: 0x1752C10 VA: 0x181753810
	protected static string EscapeString(string str) { }

	// RVA: 0x1753530 Offset: 0x1752930 VA: 0x181753530
	internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets) { }

	// RVA: 0x1755120 Offset: 0x1754520 VA: 0x181755120
	protected void Parse() { }

	// RVA: 0x1756770 Offset: 0x1755B70 VA: 0x181756770
	protected string Unescape(string str) { }

	// RVA: 0x1756780 Offset: 0x1755B80 VA: 0x181756780
	internal string Unescape(string str, bool excludeSharp) { }

	// RVA: 0x1754F40 Offset: 0x1754340 VA: 0x181754F40
	private void ParseAsWindowsUNC(string uriString) { }

	// RVA: 0x1754DD0 Offset: 0x17541D0 VA: 0x181754DD0
	private void ParseAsWindowsAbsoluteFilePath(string uriString) { }

	// RVA: 0x1754C40 Offset: 0x1754040 VA: 0x181754C40
	private void ParseAsUnixAbsoluteFilePath(string uriString) { }

	// RVA: 0x1755440 Offset: 0x1754840 VA: 0x181755440
	private void Parse(string uriString) { }

	// RVA: 0x17563F0 Offset: 0x17557F0 VA: 0x1817563F0
	private static string Reduce(string path) { }

	// RVA: 0x1754440 Offset: 0x1753840 VA: 0x181754440
	internal static string GetSchemeDelimiter(string scheme) { }

	// RVA: 0x1753B80 Offset: 0x1752F80 VA: 0x181753B80
	internal static int GetDefaultPort(string scheme) { }

	// RVA: 0x1754240 Offset: 0x1753640 VA: 0x181754240
	private string GetOpaqueWiseSchemeDelimiter() { }

	// RVA: 0x1754B50 Offset: 0x1753F50 VA: 0x181754B50
	private static bool IsPredefinedScheme(string scheme) { }

	// RVA: 0x17568F0 Offset: 0x1755CF0 VA: 0x1817568F0
	private static void .cctor() { }

}

private struct Uri.UriScheme // TypeDefIndex: 53
{	// Fields
	public string scheme; // 0x0
	public string delimiter; // 0x8
	public int defaultPort; // 0x10

	// Methods

	// RVA: 0x1DB270 Offset: 0x1DA670 VA: 0x1801DB270
	public void .ctor(string s, string d, int p) { }

}

public class Uri : ISerializable // TypeDefIndex: 2568
{	// Fields
	public static readonly string UriSchemeFile; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x16C4FC0 Offset: 0x16C43C0 VA: 0x1816C4FC0
	private bool get_IsImplicitFile() { }

	// RVA: 0x16C50A0 Offset: 0x16C44A0 VA: 0x1816C50A0
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16C4EF0 Offset: 0x16C42F0 VA: 0x1816C4EF0
	private bool get_IsDosPath() { }

	// RVA: 0x16C50B0 Offset: 0x16C44B0 VA: 0x1816C50B0
	private bool get_IsUncPath() { }

	// RVA: 0x16C4C60 Offset: 0x16C4060 VA: 0x1816C4C60
	private Uri.Flags get_HostType() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	private UriParser get_Syntax() { }

	// RVA: 0x16C5090 Offset: 0x16C4490 VA: 0x1816C5090
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16BF1C0 Offset: 0x16BE5C0 VA: 0x1816BF1C0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16C4560 Offset: 0x16C3960 VA: 0x1816C4560
	private bool get_AllowIdn() { }

	// RVA: 0x16B57E0 Offset: 0x16B4BE0 VA: 0x1816B57E0
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x16C5760 Offset: 0x16C4B60 VA: 0x1816C5760
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x16C2A10 Offset: 0x16C1E10 VA: 0x1816C2A10
	private void SetUserDrivenParsing() { }

	// RVA: 0x16C5700 Offset: 0x16C4B00 VA: 0x1816C5700
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16BF5C0 Offset: 0x16BE9C0 VA: 0x1816BF5C0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16BE0E0 Offset: 0x16BD4E0 VA: 0x1816BE0E0
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x16C2A60 Offset: 0x16C1E60 VA: 0x1816C2A60
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16C2A30 Offset: 0x16C1E30 VA: 0x1816C2A30
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16BA9D0 Offset: 0x16B9DD0 VA: 0x1816BA9D0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x16BA9B0 Offset: 0x16B9DB0 VA: 0x1816BA9B0
	private void EnsureParseRemaining() { }

	// RVA: 0x16BA950 Offset: 0x16B9D50 VA: 0x1816BA950
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x16C4170 Offset: 0x16C3570 VA: 0x1816C4170
	public void .ctor(string uriString) { }

	// RVA: 0x16C40D0 Offset: 0x16C34D0 VA: 0x1816C40D0
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x16C3D50 Offset: 0x16C3150 VA: 0x1816C3D50
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x16BA610 Offset: 0x16B9A10 VA: 0x1816BA610
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x16C3E30 Offset: 0x16C3230 VA: 0x1816C3E30
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x16BBBE0 Offset: 0x16BAFE0 VA: 0x1816BBBE0
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x16BC400 Offset: 0x16BB800 VA: 0x1816BC400
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x16C3B10 Offset: 0x16C2F10 VA: 0x1816C3B10
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16BD3D0 Offset: 0x16BC7D0 VA: 0x1816BD3D0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16BD3D0 Offset: 0x16BC7D0 VA: 0x1816BD3D0
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C42B0 Offset: 0x16C36B0 VA: 0x1816C42B0
	public string get_AbsolutePath() { }

	// RVA: 0x16C5470 Offset: 0x16C4870 VA: 0x1816C5470
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x16C4430 Offset: 0x16C3830 VA: 0x1816C4430
	public string get_AbsoluteUri() { }

	// RVA: 0x16C5150 Offset: 0x16C4550 VA: 0x1816C5150
	public string get_LocalPath() { }

	// RVA: 0x16C4660 Offset: 0x16C3A60 VA: 0x1816C4660
	public string get_Authority() { }

	// RVA: 0x16C4B20 Offset: 0x16C3F20 VA: 0x1816C4B20
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x16C4E00 Offset: 0x16C4200 VA: 0x1816C4E00
	public bool get_IsDefaultPort() { }

	// RVA: 0x16C4F00 Offset: 0x16C4300 VA: 0x1816C4F00
	public bool get_IsFile() { }

	// RVA: 0x16C4FD0 Offset: 0x16C43D0 VA: 0x1816C4FD0
	public bool get_IsLoopback() { }

	// RVA: 0x16C52A0 Offset: 0x16C46A0 VA: 0x1816C52A0
	public string get_PathAndQuery() { }

	// RVA: 0x16C50C0 Offset: 0x16C44C0 VA: 0x1816C50C0
	public bool get_IsUnc() { }

	// RVA: 0x16C4C70 Offset: 0x16C4070 VA: 0x1816C4C70
	public string get_Host() { }

	// RVA: 0x16C2A40 Offset: 0x16C1E40 VA: 0x1816C2A40
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x16C4D00 Offset: 0x16C4100 VA: 0x1816C4D00
	private static object get_InitializeLock() { }

	// RVA: 0x16BE0F0 Offset: 0x16BD4F0 VA: 0x1816BE0F0
	private static void InitializeUriConfig() { }

	// RVA: 0x16BCB70 Offset: 0x16BBF70 VA: 0x1816BCB70
	private string GetLocalPath() { }

	// RVA: 0x16C5370 Offset: 0x16C4770 VA: 0x1816C5370
	public int get_Port() { }

	// RVA: 0x16C5550 Offset: 0x16C4950 VA: 0x1816C5550
	public string get_Query() { }

	// RVA: 0x16C49E0 Offset: 0x16C3DE0 VA: 0x1816C49E0
	public string get_Fragment() { }

	// RVA: 0x16C5680 Offset: 0x16C4A80 VA: 0x1816C5680
	public string get_Scheme() { }

	// RVA: 0x16C51D0 Offset: 0x16C45D0 VA: 0x1816C51D0
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x16C5240 Offset: 0x16C4640 VA: 0x1816C5240
	public string get_OriginalString() { }

	// RVA: 0x16C46F0 Offset: 0x16C3AF0 VA: 0x1816C46F0
	public string get_DnsSafeHost() { }

	// RVA: 0x1230020 Offset: 0x122F420 VA: 0x181230020
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x16C5770 Offset: 0x16C4B70 VA: 0x1816C5770
	public bool get_UserEscaped() { }

	// RVA: 0x16C5780 Offset: 0x16C4B80 VA: 0x1816C5780
	public string get_UserInfo() { }

	// RVA: 0x16BF350 Offset: 0x16BE750 VA: 0x1816BF350
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x16B8000 Offset: 0x16B7400 VA: 0x1816B8000
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x16BF380 Offset: 0x16BE780 VA: 0x1816BF380
	public static bool IsHexDigit(char character) { }

	// RVA: 0x16BB360 Offset: 0x16BA760 VA: 0x1816BB360
	public static int FromHex(char digit) { }

	// RVA: 0x16BC520 Offset: 0x16BB920 VA: 0x1816BC520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16C2BE0 Offset: 0x16C1FE0 VA: 0x1816C2BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16C5810 Offset: 0x16C4C10 VA: 0x1816C5810
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x16C5840 Offset: 0x16C4C40 VA: 0x1816C5840
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x16BAA00 Offset: 0x16B9E00 VA: 0x1816BAA00 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x16B7600 Offset: 0x16B6A00 VA: 0x1816B7600
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x16BEB80 Offset: 0x16BDF80 VA: 0x1816BEB80
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x16C08F0 Offset: 0x16BFCF0 VA: 0x1816C08F0
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16BF5D0 Offset: 0x16BE9D0 VA: 0x1816BF5D0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x16C0B00 Offset: 0x16BFF00 VA: 0x1816C0B00
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x16C09E0 Offset: 0x16BFDE0 VA: 0x1816C09E0
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x16BA020 Offset: 0x16B9420 VA: 0x1816BA020
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x16B9810 Offset: 0x16B8C10 VA: 0x1816B9810
	private void CreateHostString() { }

	// RVA: 0x16B9640 Offset: 0x16B8A40 VA: 0x1816B9640
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x16BC6D0 Offset: 0x16BBAD0 VA: 0x1816BC6D0
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x16BC120 Offset: 0x16BB520 VA: 0x1816BC120
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x16BC2E0 Offset: 0x16BB6E0 VA: 0x1816BC2E0
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x16BD820 Offset: 0x16BCC20 VA: 0x1816BD820
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x16C1330 Offset: 0x16C0730 VA: 0x1816C1330
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x16BD910 Offset: 0x16BCD10 VA: 0x1816BD910
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x16BF650 Offset: 0x16BEA50 VA: 0x1816BF650
	private void ParseRemaining() { }

	// RVA: 0x16C03F0 Offset: 0x16BF7F0 VA: 0x1816C03F0
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16B7A50 Offset: 0x16B6E50 VA: 0x1816B7A50
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x16B8140 Offset: 0x16B7540 VA: 0x1816B8140
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x16B61F0 Offset: 0x16B55F0 VA: 0x1816B61F0
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16B5C90 Offset: 0x16B5090 VA: 0x1816B5C90
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16B59B0 Offset: 0x16B4DB0 VA: 0x1816B59B0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16BB2B0 Offset: 0x16BA6B0 VA: 0x1816BB2B0
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16BB210 Offset: 0x16BA610 VA: 0x1816BB210
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16B7240 Offset: 0x16B6640 VA: 0x1816B7240
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16BB400 Offset: 0x16BA800 VA: 0x1816BB400
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x16C3470 Offset: 0x16C2870 VA: 0x1816C3470
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x16B8EA0 Offset: 0x16B82A0 VA: 0x1816B8EA0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x16B58F0 Offset: 0x16B4CF0 VA: 0x1816B58F0
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x16B8270 Offset: 0x16B7670 VA: 0x1816B8270
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x16C4B10 Offset: 0x16C3F10 VA: 0x1816C4B10
	internal bool get_HasAuthority() { }

	// RVA: 0x16BF3B0 Offset: 0x16BE7B0 VA: 0x1816BF3B0
	private static bool IsLWS(char ch) { }

	// RVA: 0x16BF2F0 Offset: 0x16BE6F0 VA: 0x1816BF2F0
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x16BF270 Offset: 0x16BE670 VA: 0x1816BF270
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x16BF310 Offset: 0x16BE710 VA: 0x1816BF310
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x16C2A70 Offset: 0x16C1E70 VA: 0x1816C2A70
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x16B9E70 Offset: 0x16B9270 VA: 0x1816B9E70
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x16BE3B0 Offset: 0x16BD7B0 VA: 0x1816BE3B0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16B76A0 Offset: 0x16B6AA0 VA: 0x1816B76A0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x16B7910 Offset: 0x16B6D10 VA: 0x1816B7910
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16B7750 Offset: 0x16B6B50 VA: 0x1816B7750
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x16C31F0 Offset: 0x16C25F0 VA: 0x1816C31F0
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x16C2D00 Offset: 0x16C2100 VA: 0x1816C2D00
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	// RVA: 0x16C3020 Offset: 0x16C2420 VA: 0x1816C3020
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	// RVA: 0x16BC120 Offset: 0x16BB520 VA: 0x1816BC120
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x16BF3E0 Offset: 0x16BE7E0 VA: 0x1816BF3E0
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x16BF430 Offset: 0x16BE830 VA: 0x1816BF430
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x16BEC70 Offset: 0x16BE070 VA: 0x1816BEC70
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x16C32E0 Offset: 0x16C26E0 VA: 0x1816C32E0
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16BB1B0 Offset: 0x16BA5B0 VA: 0x1816BB1B0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x16C4070 Offset: 0x16C3470 VA: 0x1816C4070
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16B9390 Offset: 0x16B8790 VA: 0x1816B9390
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x16C24B0 Offset: 0x16C18B0 VA: 0x1816C24B0
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x16BD4A0 Offset: 0x16BC8A0 VA: 0x1816BD4A0
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x16BBE00 Offset: 0x16BB200 VA: 0x1816BBE00
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x16B9CC0 Offset: 0x16B90C0 VA: 0x1816B9CC0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16C3690 Offset: 0x16C2A90 VA: 0x1816C3690
	private static void .cctor() { }

}

private enum Uri.Flags // TypeDefIndex: 2569
{	// Fields
	public ulong value__; // 0x0
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
{	// Fields
	public string Host; // 0x10
	public string ScopeId; // 0x18
	public string String; // 0x20
	public Uri.Offset Offset; // 0x28
	public string DnsSafeHost; // 0x38
	public Uri.MoreInfo MoreInfo; // 0x40

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private struct Uri.Offset // TypeDefIndex: 2571
{	// Fields
	public ushort Scheme; // 0x0
	public ushort User; // 0x2
	public ushort Host; // 0x4
	public ushort PortValue; // 0x6
	public ushort Path; // 0x8
	public ushort Query; // 0xA
	public ushort Fragment; // 0xC
	public ushort End; // 0xE

}

private class Uri.MoreInfo // TypeDefIndex: 2572
{	// Fields
	public string Path; // 0x10
	public string Query; // 0x18
	public string Fragment; // 0x20
	public string AbsoluteUri; // 0x28
	public int Hash; // 0x30
	public string RemoteUrl; // 0x38

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private enum Uri.Check // TypeDefIndex: 2573
{	// Fields
	public int value__; // 0x0
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

