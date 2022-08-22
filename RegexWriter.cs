internal sealed class RegexWriter // TypeDefIndex: 2632
{	internal int[] _intStack; // 0x10
	internal int _depth; // 0x18
	internal int[] _emitted; // 0x20
	internal int _curpos; // 0x28
	internal Dictionary<string, int> _stringhash; // 0x30
	internal List<string> _stringtable; // 0x38
	internal bool _counting; // 0x40
	internal int _count; // 0x44
	internal int _trackcount; // 0x48
	internal Hashtable _caps; // 0x50


	internal static RegexCode Write(RegexTree t) { }

	private void .ctor() { }

	internal void PushInt(int I) { }

	internal bool EmptyStack() { }

	internal int PopInt() { }

	internal int CurPos() { }

	internal void PatchJump(int Offset, int jumpDest) { }

	internal void Emit(int op) { }

	internal void Emit(int op, int opd1) { }

	internal void Emit(int op, int opd1, int opd2) { }

	internal int StringCode(string str) { }

	internal ArgumentException MakeException(string message) { }

	internal int MapCapnum(int capnum) { }

	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex) { }

}

