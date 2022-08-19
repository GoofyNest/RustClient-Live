internal sealed class RegexFCD // TypeDefIndex: 2613
{	// Fields
	private int[] _intStack; // 0x10
	private int _intDepth; // 0x18
	private RegexFC[] _fcStack; // 0x20
	private int _fcDepth; // 0x28
	private bool _skipAllChildren; // 0x2C
	private bool _skipchild; // 0x2D
	private bool _failed; // 0x2E

	// Methods

	// RVA: 0x14CD4C0 Offset: 0x14CC8C0 VA: 0x1814CD4C0
	internal static RegexPrefix FirstChars(RegexTree t) { }

	// RVA: 0x14CD800 Offset: 0x14CCC00 VA: 0x1814CD800
	internal static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x14CCC70 Offset: 0x14CC070 VA: 0x1814CCC70
	internal static int Anchors(RegexTree tree) { }

	// RVA: 0x14CCBF0 Offset: 0x14CBFF0 VA: 0x1814CCBF0
	private static int AnchorFromType(int type) { }

	// RVA: 0x14CDF50 Offset: 0x14CD350 VA: 0x1814CDF50
	private void .ctor() { }

	// RVA: 0x14CDBC0 Offset: 0x14CCFC0 VA: 0x1814CDBC0
	private void PushInt(int I) { }

	// RVA: 0x14CD760 Offset: 0x14CCB60 VA: 0x1814CD760
	private bool IntIsEmpty() { }

	// RVA: 0x14CD7C0 Offset: 0x14CCBC0 VA: 0x1814CD7C0
	private int PopInt() { }

	// RVA: 0x14CDAA0 Offset: 0x14CCEA0 VA: 0x1814CDAA0
	private void PushFC(RegexFC fc) { }

	// RVA: 0xEB1900 Offset: 0xEB0D00 VA: 0x180EB1900
	private bool FCIsEmpty() { }

	// RVA: 0x14CD770 Offset: 0x14CCB70 VA: 0x1814CD770
	private RegexFC PopFC() { }

	// RVA: 0x14CDF10 Offset: 0x14CD310 VA: 0x1814CDF10
	private RegexFC TopFC() { }

	// RVA: 0x14CDCA0 Offset: 0x14CD0A0 VA: 0x1814CDCA0
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x14CDF00 Offset: 0x14CD300 VA: 0x1814CDF00
	private void SkipChild() { }

	// RVA: 0x14CCE30 Offset: 0x14CC230 VA: 0x1814CCE30
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

}

