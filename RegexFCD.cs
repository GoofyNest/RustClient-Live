internal sealed class RegexFCD // TypeDefIndex: 2613
{	private int[] _intStack; // 0x10
	private int _intDepth; // 0x18
	private RegexFC[] _fcStack; // 0x20
	private int _fcDepth; // 0x28
	private bool _skipAllChildren; // 0x2C
	private bool _skipchild; // 0x2D
	private bool _failed; // 0x2E


	internal static RegexPrefix FirstChars(RegexTree t) { }

	internal static RegexPrefix Prefix(RegexTree tree) { }

	internal static int Anchors(RegexTree tree) { }

	private static int AnchorFromType(int type) { }

	private void .ctor() { }

	private void PushInt(int I) { }

	private bool IntIsEmpty() { }

	private int PopInt() { }

	private void PushFC(RegexFC fc) { }

	private bool FCIsEmpty() { }

	private RegexFC PopFC() { }

	private RegexFC TopFC() { }

	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	private void SkipChild() { }

	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

}

