internal sealed class RegexNode // TypeDefIndex: 2625
{
	internal int _type;
	internal List<RegexNode> _children;
	internal string _str;
	internal char _ch;
	internal int _m;
	internal int _n;
	internal RegexOptions _options;
	internal RegexNode _next;


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

