internal sealed class RegexWriter // TypeDefIndex: 2632
{
	internal int[] _intStack; 
	internal int _depth; 
	internal int[] _emitted; 
	internal int _curpos; 
	internal Dictionary<string, int> _stringhash; 
	internal List<string> _stringtable; 
	internal bool _counting; 
	internal int _count; 
	internal int _trackcount; 
	internal Hashtable _caps; 


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

