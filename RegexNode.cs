internal sealed class RegexNode // TypeDefIndex: 2625
{	// Fields
	internal int _type; // 0x10
	internal List<RegexNode> _children; // 0x18
	internal string _str; // 0x20
	internal char _ch; // 0x28
	internal int _m; // 0x2C
	internal int _n; // 0x30
	internal RegexOptions _options; // 0x34
	internal RegexNode _next; // 0x38

	// Methods

	// RVA: 0x16AB1D0 Offset: 0x16AA5D0 VA: 0x1816AB1D0
	internal void .ctor(int type, RegexOptions options) { }

	// RVA: 0x16AB260 Offset: 0x16AA660 VA: 0x1816AB260
	internal void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x16AB210 Offset: 0x16AA610 VA: 0x1816AB210
	internal void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x16AB2B0 Offset: 0x16AA6B0 VA: 0x1816AB2B0
	internal void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x16AB180 Offset: 0x16AA580 VA: 0x1816AB180
	internal void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x16AB170 Offset: 0x16AA570 VA: 0x1816AB170
	internal bool UseOptionR() { }

	// RVA: 0x16AB010 Offset: 0x16AA410 VA: 0x1816AB010
	internal RegexNode ReverseLeft() { }

	// RVA: 0x16AA220 Offset: 0x16A9620 VA: 0x1816AA220
	internal void MakeRep(int type, int min, int max) { }

	// RVA: 0x16AAD70 Offset: 0x16AA170 VA: 0x1816AAD70
	internal RegexNode Reduce() { }

	// RVA: 0x16AB070 Offset: 0x16AA470 VA: 0x1816AB070
	internal RegexNode StripEnation(int emptyType) { }

	// RVA: 0x16AA9A0 Offset: 0x16A9DA0 VA: 0x1816AA9A0
	internal RegexNode ReduceGroup() { }

	// RVA: 0x16AAA10 Offset: 0x16A9E10 VA: 0x1816AAA10
	internal RegexNode ReduceRep() { }

	// RVA: 0x16AABD0 Offset: 0x16A9FD0 VA: 0x1816AABD0
	internal RegexNode ReduceSet() { }

	// RVA: 0x16AA230 Offset: 0x16A9630 VA: 0x1816AA230
	internal RegexNode ReduceAlternation() { }

	// RVA: 0x16AA630 Offset: 0x16A9A30 VA: 0x1816AA630
	internal RegexNode ReduceConcatenation() { }

	// RVA: 0x16AA110 Offset: 0x16A9510 VA: 0x1816AA110
	internal RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x16A9FA0 Offset: 0x16A93A0 VA: 0x1816A9FA0
	internal void AddChild(RegexNode newChild) { }

	// RVA: 0x16AA0B0 Offset: 0x16A94B0 VA: 0x1816AA0B0
	internal RegexNode Child(int i) { }

	// RVA: 0x16AA070 Offset: 0x16A9470 VA: 0x1816AA070
	internal int ChildCount() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	internal int Type() { }

}

