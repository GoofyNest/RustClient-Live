internal struct Token // TypeDefIndex: 5781
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

public enum Token.Type // TypeDefIndex: 5782
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

