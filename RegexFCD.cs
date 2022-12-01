internal sealed class RegexFCD // TypeDefIndex: 2613
{
	private int[] _intStack;
	private int _intDepth;
	private RegexFC[] _fcStack;
	private int _fcDepth;
	private bool _skipAllChildren;
	private bool _skipchild;
	private bool _failed;


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

