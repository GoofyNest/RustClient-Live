internal struct Token // TypeDefIndex: 5785
{
	public static readonly Token Empty; 
	private readonly Token.Type type; 
	[CompilerGeneratedAttribute] 
	private int <StartPosition>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <EndPosition>k__BackingField; 

	public int StartPosition { get; set; }
	public int EndPosition { get; set; }
	public Token.Type Kind { get; }


	public void .ctor(Token.Type type, int startPosition, int endPosition) { }

	[CompilerGeneratedAttribute] 
	public int get_StartPosition() { }

	[CompilerGeneratedAttribute] 
	private void set_StartPosition(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_EndPosition() { }

	[CompilerGeneratedAttribute] 
	private void set_EndPosition(int value) { }

	public Token.Type get_Kind() { }

	public static Token.Type op_Implicit(Token token) { }

	public override string ToString() { }

	private static void .cctor() { }

}

public enum Token.Type // TypeDefIndex: 5786
{
	public int value__; 
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

public struct Token // TypeDefIndex: 9692
{
	[CompilerGeneratedAttribute] 
	private Utf8String <App>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <ClientId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <AccountId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <AccessToken>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private double <ExpiresIn>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <ExpiresAt>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AuthTokenType <AuthType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <RefreshToken>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private double <RefreshExpiresIn>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <RefreshExpiresAt>k__BackingField; 

	public Utf8String App { get; set; }
	public Utf8String ClientId { get; set; }
	public EpicAccountId AccountId { get; set; }
	public Utf8String AccessToken { get; set; }
	public double ExpiresIn { get; set; }
	public Utf8String ExpiresAt { get; set; }
	public AuthTokenType AuthType { get; set; }
	public Utf8String RefreshToken { get; set; }
	public double RefreshExpiresIn { get; set; }
	public Utf8String RefreshExpiresAt { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_App() { }

	[CompilerGeneratedAttribute] 
	public void set_App(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_ClientId() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_AccountId() { }

	[CompilerGeneratedAttribute] 
	public void set_AccountId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_AccessToken() { }

	[CompilerGeneratedAttribute] 
	public void set_AccessToken(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public double get_ExpiresIn() { }

	[CompilerGeneratedAttribute] 
	public void set_ExpiresIn(double value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_ExpiresAt() { }

	[CompilerGeneratedAttribute] 
	public void set_ExpiresAt(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public AuthTokenType get_AuthType() { }

	[CompilerGeneratedAttribute] 
	public void set_AuthType(AuthTokenType value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_RefreshToken() { }

	[CompilerGeneratedAttribute] 
	public void set_RefreshToken(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public double get_RefreshExpiresIn() { }

	[CompilerGeneratedAttribute] 
	public void set_RefreshExpiresIn(double value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_RefreshExpiresAt() { }

	[CompilerGeneratedAttribute] 
	public void set_RefreshExpiresAt(Utf8String value) { }

	internal void Set(ref TokenInternal other) { }

}

