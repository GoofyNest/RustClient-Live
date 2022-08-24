public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid> // TypeDefIndex: 241
{
	public static readonly Guid Empty; 
	private int _a; 
	private short _b; 
	private short _c; 
	private byte _d; 
	private byte _e; 
	private byte _f; 
	private byte _g; 
	private byte _h; 
	private byte _i; 
	private byte _j; 
	private byte _k; 
	private static object _rngAccess; 
	private static RandomNumberGenerator _rng; 
	private static RandomNumberGenerator _fastRng; 


public void .ctor(byte[] b) { }

	[CLSCompliantAttribute] 
public void .ctor(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

public void .ctor(string g) { }

public static Guid Parse(string input) { }

public static bool TryParse(string input, out Guid result) { }

private static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

private static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result) { }

private static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result) { }

private static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result) { }

private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

private static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

private static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

private static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

private static string EatAllWhitespace(string str) { }

private static bool IsHexPrefix(string str, int i) { }

public byte[] ToByteArray() { }

public override string ToString() { }

public override int GetHashCode() { }

public override bool Equals(object o) { }

public bool Equals(Guid g) { }

private int GetResult(uint me, uint them) { }

public int CompareTo(object value) { }

public int CompareTo(Guid value) { }

public static bool op_Equality(Guid a, Guid b) { }

public static bool op_Inequality(Guid a, Guid b) { }

public string ToString(string format) { }

private static char HexToChar(int a) { }

private static int HexsToChars(char* guidChars, int offset, int a, int b) { }

private static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) { }

public string ToString(string format, IFormatProvider provider) { }

public static Guid NewGuid() { }

private static void .cctor() { }

}

private enum Guid.GuidStyles // TypeDefIndex: 242
{
	public int value__; 
public const Guid.GuidStyles None = 0;
public const Guid.GuidStyles AllowParenthesis = 1;
public const Guid.GuidStyles AllowBraces = 2;
public const Guid.GuidStyles AllowDashes = 4;
public const Guid.GuidStyles AllowHexPrefix = 8;
public const Guid.GuidStyles RequireParenthesis = 16;
public const Guid.GuidStyles RequireBraces = 32;
public const Guid.GuidStyles RequireDashes = 64;
public const Guid.GuidStyles RequireHexPrefix = 128;
public const Guid.GuidStyles HexFormat = 160;
public const Guid.GuidStyles NumberFormat = 0;
public const Guid.GuidStyles DigitFormat = 64;
public const Guid.GuidStyles BraceFormat = 96;
public const Guid.GuidStyles ParenthesisFormat = 80;
public const Guid.GuidStyles Any = 15;

}

private enum Guid.GuidParseThrowStyle // TypeDefIndex: 243
{
	public int value__; 
public const Guid.GuidParseThrowStyle None = 0;
public const Guid.GuidParseThrowStyle All = 1;
public const Guid.GuidParseThrowStyle AllButOverflow = 2;

}

private enum Guid.ParseFailureKind // TypeDefIndex: 244
{
	public int value__; 
public const Guid.ParseFailureKind None = 0;
public const Guid.ParseFailureKind ArgumentNull = 1;
public const Guid.ParseFailureKind Format = 2;
public const Guid.ParseFailureKind FormatWithParameter = 3;
public const Guid.ParseFailureKind NativeException = 4;
public const Guid.ParseFailureKind FormatWithInnerException = 5;

}

private struct Guid.GuidResult // TypeDefIndex: 245
{
	internal Guid parsedGuid; 
	internal Guid.GuidParseThrowStyle throwStyle; 
	internal Guid.ParseFailureKind m_failure; 
	internal string m_failureMessageID; 
	internal object m_failureMessageFormatArgument; 
	internal string m_failureArgumentName; 
	internal Exception m_innerException; 


internal void Init(Guid.GuidParseThrowStyle canThrow) { }

internal void SetFailure(Exception nativeException) { }

internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

internal Exception GetGuidParseException() { }

}

