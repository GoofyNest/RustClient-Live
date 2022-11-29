internal class Lexer // TypeDefIndex: 5790
{
	private static readonly bool[] token_chars; 
	private static readonly int last_token_char; 
	private static readonly string[] dt_formats; 
	private readonly string s; 
	private int pos; 

	public int Position { get; set; }


	public void .ctor(string stream) { }

	public int get_Position() { }

	public void set_Position(int value) { }

	public string GetStringValue(Token token) { }

	public string GetStringValue(Token start, Token end) { }

	public string GetQuotedStringValue(Token start) { }

	public string GetRemainingStringValue(int position) { }

	public bool IsStarStringValue(Token token) { }

	public bool TryGetNumericValue(Token token, out int value) { }

	public bool TryGetNumericValue(Token token, out long value) { }

	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	public bool TryGetDoubleValue(Token token, out double value) { }

	public static bool IsValidToken(string input) { }

	public static bool IsValidCharacter(char input) { }

	public void EatChar() { }

	public int PeekChar() { }

	public bool ScanCommentOptional(out string value, out Token readToken) { }

	public Token Scan(bool recognizeDash = False) { }

	private static void .cctor() { }

}

