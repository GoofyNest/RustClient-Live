internal sealed class RegexNode // TypeDefIndex: 2625
{	internal int _type; // 0x10
	internal List<RegexNode> _children; // 0x18
	internal string _str; // 0x20
	internal char _ch; // 0x28
	internal int _m; // 0x2C
	internal int _n; // 0x30
	internal RegexOptions _options; // 0x34
	internal RegexNode _next; // 0x38


	internal void .ctor(int type, RegexOptions options) { }

	internal void .ctor(int type, RegexOptions options, char ch) { }

	internal void .ctor(int type, RegexOptions options, string str) { }

	internal void .ctor(int type, RegexOptions options, int m) { }

	internal void .ctor(int type, RegexOptions options, int m, int n) { }

	internal bool UseOptionR() { }

	internal RegexNode ReverseLeft() { }

	internal void MakeRep(int type, int min, int max) { }

	internal RegexNode Reduce() { }

	internal RegexNode StripEnation(int emptyType) { }

	internal RegexNode ReduceGroup() { }

	internal RegexNode ReduceRep() { }

	internal RegexNode ReduceSet() { }

	internal RegexNode ReduceAlternation() { }

	internal RegexNode ReduceConcatenation() { }

	internal RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	internal void AddChild(RegexNode newChild) { }

	internal RegexNode Child(int i) { }

	internal int ChildCount() { }

	internal int Type() { }

}

