internal sealed class Tokenizer // TypeDefIndex: 920
{
	public int LineNo;
	private int _inProcessingTag;
	private byte[] _inBytes;
	private char[] _inChars;
	private string _inString;
	private int _inIndex;
	private int _inSize;
	private int _inSavedCharacter;
	private Tokenizer.TokenSource _inTokenSource;
	private Tokenizer.ITokenReader _inTokenReader;
	private Tokenizer.StringMaker _maker;
	private string[] _searchStrings;
	private string[] _replaceStrings;
	private int _inNestedIndex;
	private int _inNestedSize;
	private string _inNestedString;


	internal void BasicInitialization() { }

	public void Recycle() { }

	internal void .ctor(string input) { }

	internal void ChangeFormat(Encoding encoding) { }

	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	private string GetStringToken() { }

}

private enum Tokenizer.TokenSource // TypeDefIndex: 921
{
	public int value__;
	public const Tokenizer.TokenSource UnicodeByteArray = 0;
	public const Tokenizer.TokenSource UTF8ByteArray = 1;
	public const Tokenizer.TokenSource ASCIIByteArray = 2;
	public const Tokenizer.TokenSource CharArray = 3;
	public const Tokenizer.TokenSource String = 4;
	public const Tokenizer.TokenSource NestedStrings = 5;
	public const Tokenizer.TokenSource Other = 6;

}

internal sealed class Tokenizer.StringMaker // TypeDefIndex: 922
{
	private string[] aStrings;
	private uint cStringsMax;
	private uint cStringsUsed;
	public StringBuilder _outStringBuilder;
	public char[] _outChars;
	public int _outIndex;


	private static uint HashString(string str) { }

	private static uint HashCharArray(char[] a, int l) { }

	public void .ctor() { }

	private bool CompareStringAndChars(string str, char[] a, int l) { }

	public string MakeString() { }

}

internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 924
{
	internal StreamReader _in;
	internal int _numCharRead;

	internal int NumCharEncountered { get; }


	internal void .ctor(StreamReader input) { }

	public virtual int Read() { }

	internal int get_NumCharEncountered() { }

}

