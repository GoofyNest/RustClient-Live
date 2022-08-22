internal sealed class RegexBoyerMoore // TypeDefIndex: 2604
{	internal int[] _positive; // 0x10
	internal int[] _negativeASCII; // 0x18
	internal int[][] _negativeUnicode; // 0x20
	internal string _pattern; // 0x28
	internal int _lowASCII; // 0x30
	internal int _highASCII; // 0x34
	internal bool _rightToLeft; // 0x38
	internal bool _caseInsensitive; // 0x39
	internal CultureInfo _culture; // 0x40
	internal const int infinite = 2147483647;


	internal void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	private bool MatchPattern(string text, int index) { }

	internal bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	internal int Scan(string text, int index, int beglimit, int endlimit) { }

	public override string ToString() { }

}

