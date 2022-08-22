public sealed class IdnMapping // TypeDefIndex: 743
{	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18


	public void .ctor() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public string GetAscii(string unicode) { }

	public string GetAscii(string unicode, int index, int count) { }

	private string Convert(string input, int index, int count, bool toAscii) { }

	private string ToAscii(string s, int offset) { }

	private void VerifyLength(string s, int offset) { }

	private string NamePrep(string s, int offset) { }

	private void VerifyProhibitedCharacters(string s, int offset) { }

	private void VerifyStd3AsciiRules(string s, int offset) { }

	public string GetUnicode(string ascii) { }

	public string GetUnicode(string ascii, int index, int count) { }

	private string ToUnicode(string s, int offset) { }

}

