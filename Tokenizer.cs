internal sealed class Tokenizer // TypeDefIndex: 920
{	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x17C15D0 Offset: 0x17C09D0 VA: 0x1817C15D0
	internal void BasicInitialization() { }

	// RVA: 0x17C2320 Offset: 0x17C1720 VA: 0x1817C2320
	public void Recycle() { }

	// RVA: 0x17C2380 Offset: 0x17C1780 VA: 0x1817C2380
	internal void .ctor(string input) { }

	// RVA: 0x17C1650 Offset: 0x17C0A50 VA: 0x1817C1650
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x17C18E0 Offset: 0x17C0CE0 VA: 0x1817C18E0
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x17C18C0 Offset: 0x17C0CC0 VA: 0x1817C18C0
	private string GetStringToken() { }

}

private enum Tokenizer.TokenSource // TypeDefIndex: 921
{	// Fields
	public int value__; // 0x0
	public const Tokenizer.TokenSource UnicodeByteArray = 0;
	public const Tokenizer.TokenSource UTF8ByteArray = 1;
	public const Tokenizer.TokenSource ASCIIByteArray = 2;
	public const Tokenizer.TokenSource CharArray = 3;
	public const Tokenizer.TokenSource String = 4;
	public const Tokenizer.TokenSource NestedStrings = 5;
	public const Tokenizer.TokenSource Other = 6;

}

internal sealed class Tokenizer.StringMaker // TypeDefIndex: 922
{	// Fields
	private string[] aStrings; // 0x10
	private uint cStringsMax; // 0x18
	private uint cStringsUsed; // 0x1C
	public StringBuilder _outStringBuilder; // 0x20
	public char[] _outChars; // 0x28
	public int _outIndex; // 0x30

	// Methods

	// RVA: 0x18AB660 Offset: 0x18AAA60 VA: 0x1818AB660
	private static uint HashString(string str) { }

	// RVA: 0x18AB600 Offset: 0x18AAA00 VA: 0x1818AB600
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x18ABB70 Offset: 0x18AAF70 VA: 0x1818ABB70
	public void .ctor() { }

	// RVA: 0x18AB500 Offset: 0x18AA900 VA: 0x1818AB500
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x18AB730 Offset: 0x18AAB30 VA: 0x1818AB730
	public string MakeString() { }

}

internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 924
{	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x18AADE0 Offset: 0x18AA1E0 VA: 0x1818AADE0
	internal void .ctor(StreamReader input) { }

	// RVA: 0x18AADA0 Offset: 0x18AA1A0 VA: 0x1818AADA0 Slot: 5
	public virtual int Read() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	internal int get_NumCharEncountered() { }

}

