public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid> // TypeDefIndex: 241
{	// Fields
	public static readonly Guid Empty; // 0x0
	private int _a; // 0x0
	private short _b; // 0x4
	private short _c; // 0x6
	private byte _d; // 0x8
	private byte _e; // 0x9
	private byte _f; // 0xA
	private byte _g; // 0xB
	private byte _h; // 0xC
	private byte _i; // 0xD
	private byte _j; // 0xE
	private byte _k; // 0xF
	private static object _rngAccess; // 0x10
	private static RandomNumberGenerator _rng; // 0x18
	private static RandomNumberGenerator _fastRng; // 0x20

	// Methods

	// RVA: 0x1ECC70 Offset: 0x1EC070 VA: 0x1801ECC70
	public void .ctor(byte[] b) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1ECC20 Offset: 0x1EC020 VA: 0x1801ECC20
	public void .ctor(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1ECC20 Offset: 0x1EC020 VA: 0x1801ECC20
	public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1ECC80 Offset: 0x1EC080 VA: 0x1801ECC80
	public void .ctor(string g) { }

	// RVA: 0x137A330 Offset: 0x1379730 VA: 0x18137A330
	public static Guid Parse(string input) { }

	// RVA: 0x137C510 Offset: 0x137B910 VA: 0x18137C510
	public static bool TryParse(string input, out Guid result) { }

	// RVA: 0x137C310 Offset: 0x137B710 VA: 0x18137C310
	private static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

	// RVA: 0x137B780 Offset: 0x137AB80 VA: 0x18137B780
	private static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x137BED0 Offset: 0x137B2D0 VA: 0x18137BED0
	private static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x137B2D0 Offset: 0x137A6D0 VA: 0x18137B2D0
	private static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x137A980 Offset: 0x1379D80 VA: 0x18137A980
	private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137A8C0 Offset: 0x1379CC0 VA: 0x18137A8C0
	private static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137A470 Offset: 0x1379870 VA: 0x18137A470
	private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137A680 Offset: 0x1379A80 VA: 0x18137A680
	private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137A510 Offset: 0x1379910 VA: 0x18137A510
	private static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137A710 Offset: 0x1379B10 VA: 0x18137A710
	private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137A7A0 Offset: 0x1379BA0 VA: 0x18137A7A0
	private static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x1379A50 Offset: 0x1378E50 VA: 0x181379A50
	private static string EatAllWhitespace(string str) { }

	// RVA: 0x137A000 Offset: 0x1379400 VA: 0x18137A000
	private static bool IsHexPrefix(string str, int i) { }

	// RVA: 0x1ECBB0 Offset: 0x1EBFB0 VA: 0x1801ECBB0
	public byte[] ToByteArray() { }

	// RVA: 0x1ECBC0 Offset: 0x1EBFC0 VA: 0x1801ECBC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ECB60 Offset: 0x1EBF60 VA: 0x1801ECB60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EC900 Offset: 0x1EBD00 VA: 0x1801EC900 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1ECA70 Offset: 0x1EBE70 VA: 0x1801ECA70 Slot: 7
	public bool Equals(Guid g) { }

	// RVA: 0x1ECB90 Offset: 0x1EBF90 VA: 0x1801ECB90
	private int GetResult(uint me, uint them) { }

	// RVA: 0x1EC8D0 Offset: 0x1EBCD0 VA: 0x1801EC8D0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1EC8E0 Offset: 0x1EBCE0 VA: 0x1801EC8E0 Slot: 6
	public int CompareTo(Guid value) { }

	// RVA: 0x137CAE0 Offset: 0x137BEE0 VA: 0x18137CAE0
	public static bool op_Equality(Guid a, Guid b) { }

	// RVA: 0x137CC70 Offset: 0x137C070 VA: 0x18137CC70
	public static bool op_Inequality(Guid a, Guid b) { }

	// RVA: 0x1ECC10 Offset: 0x1EC010 VA: 0x1801ECC10
	public string ToString(string format) { }

	// RVA: 0x1379DF0 Offset: 0x13791F0 VA: 0x181379DF0
	private static char HexToChar(int a) { }

	// RVA: 0x1379E10 Offset: 0x1379210 VA: 0x181379E10
	private static int HexsToChars(char* guidChars, int offset, int a, int b) { }

	// RVA: 0x1379EA0 Offset: 0x13792A0 VA: 0x181379EA0
	private static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) { }

	// RVA: 0x1ECC00 Offset: 0x1EC000 VA: 0x1801ECC00 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x137A0F0 Offset: 0x13794F0 VA: 0x18137A0F0
	public static Guid NewGuid() { }

	// RVA: 0x137C640 Offset: 0x137BA40 VA: 0x18137C640
	private static void .cctor() { }

}

private enum Guid.GuidStyles // TypeDefIndex: 242
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const Guid.GuidParseThrowStyle None = 0;
	public const Guid.GuidParseThrowStyle All = 1;
	public const Guid.GuidParseThrowStyle AllButOverflow = 2;

}

private enum Guid.ParseFailureKind // TypeDefIndex: 244
{	// Fields
	public int value__; // 0x0
	public const Guid.ParseFailureKind None = 0;
	public const Guid.ParseFailureKind ArgumentNull = 1;
	public const Guid.ParseFailureKind Format = 2;
	public const Guid.ParseFailureKind FormatWithParameter = 3;
	public const Guid.ParseFailureKind NativeException = 4;
	public const Guid.ParseFailureKind FormatWithInnerException = 5;

}

private struct Guid.GuidResult // TypeDefIndex: 245
{	// Fields
	internal Guid parsedGuid; // 0x0
	internal Guid.GuidParseThrowStyle throwStyle; // 0x10
	internal Guid.ParseFailureKind m_failure; // 0x14
	internal string m_failureMessageID; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal string m_failureArgumentName; // 0x28
	internal Exception m_innerException; // 0x30

	// Methods

	// RVA: 0x1EC810 Offset: 0x1EBC10 VA: 0x1801EC810
	internal void Init(Guid.GuidParseThrowStyle canThrow) { }

	// RVA: 0x1EC890 Offset: 0x1EBC90 VA: 0x1801EC890
	internal void SetFailure(Exception nativeException) { }

	// RVA: 0x1EC850 Offset: 0x1EBC50 VA: 0x1801EC850
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1EC820 Offset: 0x1EBC20 VA: 0x1801EC820
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1EC880 Offset: 0x1EBC80 VA: 0x1801EC880
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	// RVA: 0x1EC800 Offset: 0x1EBC00 VA: 0x1801EC800
	internal Exception GetGuidParseException() { }

}

