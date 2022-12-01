internal sealed class RegexBoyerMoore // TypeDefIndex: 2604
{
	internal int[] _positive;
	internal int[] _negativeASCII;
	internal int[][] _negativeUnicode;
	internal string _pattern;
	internal int _lowASCII;
	internal int _highASCII;
	internal bool _rightToLeft;
	internal bool _caseInsensitive;
	internal CultureInfo _culture;
	internal const int infinite = 2147483647;


	internal void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	private bool MatchPattern(string text, int index) { }

	internal bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	internal int Scan(string text, int index, int beglimit, int endlimit) { }

	public override string ToString() { }

}

