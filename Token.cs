internal struct Token // TypeDefIndex: 5781
{	// Fields
	public static readonly Token Empty; // 0x0
	private readonly Token.Type type; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <StartPosition>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <EndPosition>k__BackingField; // 0x8

	// Properties
	public int StartPosition { get; set; }
	public int EndPosition { get; set; }
	public Token.Type Kind { get; }

	// Methods

	// RVA: 0x19DDC0 Offset: 0x19D1C0 VA: 0x18019DDC0
	public void .ctor(Token.Type type, int startPosition, int endPosition) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14B670 Offset: 0x14AA70 VA: 0x18014B670
	public int get_StartPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DDF0 Offset: 0x19D1F0 VA: 0x18019DDF0
	private void set_StartPosition(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public int get_EndPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DDE0 Offset: 0x19D1E0 VA: 0x18019DDE0
	private void set_EndPosition(int value) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public Token.Type get_Kind() { }

	// RVA: 0xDE15E0 Offset: 0xDE09E0 VA: 0x180DE15E0
	public static Token.Type op_Implicit(Token token) { }

	// RVA: 0x19DD40 Offset: 0x19D140 VA: 0x18019DD40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1092530 Offset: 0x1091930 VA: 0x181092530
	private static void .cctor() { }

}

public enum Token.Type // TypeDefIndex: 5782
{	// Fields
	public int value__; // 0x0
	public const Token.Type Error = 0;
	public const Token.Type End = 1;
	public const Token.Type Token = 2;
	public const Token.Type QuotedString = 3;
	public const Token.Type SeparatorEqual = 4;
	public const Token.Type SeparatorSemicolon = 5;
	public const Token.Type SeparatorSlash = 6;
	public const Token.Type SeparatorDash = 7;
	public const Token.Type SeparatorComma = 8;
	public const Token.Type OpenParens = 9;

}

