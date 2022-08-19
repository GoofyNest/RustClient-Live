internal sealed class RegexBoyerMoore // TypeDefIndex: 2604
{	// Fields
	internal int[] _positive; // 0x10
	internal int[] _negativeASCII; // 0x18
	internal int[][] _negativeUnicode; // 0x20
	internal string _pattern; // 0x28
	internal int _lowASCII; // 0x30
	internal int _highASCII; // 0x34
	internal bool _rightToLeft; // 0x38
	internal bool _caseInsensitive; // 0x39
	internal CultureInfo _culture; // 0x40
	internal const int infinite = 2147483647;

	// Methods

	// RVA: 0x14C4860 Offset: 0x14C3C60 VA: 0x1814C4860
	internal void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x14C4390 Offset: 0x14C3790 VA: 0x1814C4390
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x14C4310 Offset: 0x14C3710 VA: 0x1814C4310
	internal bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x14C44C0 Offset: 0x14C38C0 VA: 0x1814C44C0
	internal int Scan(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 3
	public override string ToString() { }

}

