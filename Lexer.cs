internal class Lexer // TypeDefIndex: 5783
{	// Fields
	private static readonly bool[] token_chars; // 0x0
	private static readonly int last_token_char; // 0x8
	private static readonly string[] dt_formats; // 0x10
	private readonly string s; // 0x10
	private int pos; // 0x18

	// Properties
	public int Position { get; set; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(string stream) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Position() { }

	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_Position(int value) { }

	// RVA: 0x108B990 Offset: 0x108AD90 VA: 0x18108B990
	public string GetStringValue(Token token) { }

	// RVA: 0x108B960 Offset: 0x108AD60 VA: 0x18108B960
	public string GetStringValue(Token start, Token end) { }

	// RVA: 0x108B8F0 Offset: 0x108ACF0 VA: 0x18108B8F0
	public string GetQuotedStringValue(Token start) { }

	// RVA: 0x108B930 Offset: 0x108AD30 VA: 0x18108B930
	public string GetRemainingStringValue(int position) { }

	// RVA: 0x108B9C0 Offset: 0x108ADC0 VA: 0x18108B9C0
	public bool IsStarStringValue(Token token) { }

	// RVA: 0x108C3E0 Offset: 0x108B7E0 VA: 0x18108C3E0
	public bool TryGetNumericValue(Token token, out int value) { }

	// RVA: 0x108C320 Offset: 0x108B720 VA: 0x18108C320
	public bool TryGetNumericValue(Token token, out long value) { }

	// RVA: 0x108C4A0 Offset: 0x108B8A0 VA: 0x18108C4A0
	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

	// RVA: 0x108C150 Offset: 0x108B550 VA: 0x18108C150
	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	// RVA: 0x108C060 Offset: 0x108B460 VA: 0x18108C060
	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	// RVA: 0x108C240 Offset: 0x108B640 VA: 0x18108C240
	public bool TryGetDoubleValue(Token token, out double value) { }

	// RVA: 0x108BAC0 Offset: 0x108AEC0 VA: 0x18108BAC0
	public static bool IsValidToken(string input) { }

	// RVA: 0x108BA00 Offset: 0x108AE00 VA: 0x18108BA00
	public static bool IsValidCharacter(char input) { }

	// RVA: 0x108B8E0 Offset: 0x108ACE0 VA: 0x18108B8E0
	public void EatChar() { }

	// RVA: 0x108BB70 Offset: 0x108AF70 VA: 0x18108BB70
	public int PeekChar() { }

	// RVA: 0x108BBB0 Offset: 0x108AFB0 VA: 0x18108BBB0
	public bool ScanCommentOptional(out string value, out Token readToken) { }

	// RVA: 0x108BD10 Offset: 0x108B110 VA: 0x18108BD10
	public Token Scan(bool recognizeDash = False) { }

	// RVA: 0x108C5F0 Offset: 0x108B9F0 VA: 0x18108C5F0
	private static void .cctor() { }

}

