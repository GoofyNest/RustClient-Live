internal sealed class RegexWriter // TypeDefIndex: 2632
{	// Fields
	internal int[] _intStack; // 0x10
	internal int _depth; // 0x18
	internal int[] _emitted; // 0x20
	internal int _curpos; // 0x28
	internal Dictionary<string, int> _stringhash; // 0x30
	internal List<string> _stringtable; // 0x38
	internal bool _counting; // 0x40
	internal int _count; // 0x44
	internal int _trackcount; // 0x48
	internal Hashtable _caps; // 0x50

	// Methods

	// RVA: 0x16B5250 Offset: 0x16B4650 VA: 0x1816B5250
	internal static RegexCode Write(RegexTree t) { }

	// RVA: 0x16B5370 Offset: 0x16B4770 VA: 0x1816B5370
	private void .ctor() { }

	// RVA: 0x16B4B40 Offset: 0x16B3F40 VA: 0x1816B4B40
	internal void PushInt(int I) { }

	// RVA: 0x14CD760 Offset: 0x14CCB60 VA: 0x1814CD760
	internal bool EmptyStack() { }

	// RVA: 0x14CD7C0 Offset: 0x14CCBC0 VA: 0x1814CD7C0
	internal int PopInt() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	internal int CurPos() { }

	// RVA: 0x16B4B00 Offset: 0x16B3F00 VA: 0x1816B4B00
	internal void PatchJump(int Offset, int jumpDest) { }

	// RVA: 0x16B4970 Offset: 0x16B3D70 VA: 0x1816B4970
	internal void Emit(int op) { }

	// RVA: 0x16B4800 Offset: 0x16B3C00 VA: 0x1816B4800
	internal void Emit(int op, int opd1) { }

	// RVA: 0x16B48A0 Offset: 0x16B3CA0 VA: 0x1816B48A0
	internal void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x16B5150 Offset: 0x16B4550 VA: 0x1816B5150
	internal int StringCode(string str) { }

	// RVA: 0x16B49E0 Offset: 0x16B3DE0 VA: 0x1816B49E0
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x16B4A40 Offset: 0x16B3E40 VA: 0x1816B4A40
	internal int MapCapnum(int capnum) { }

	// RVA: 0x16B4C20 Offset: 0x16B4020 VA: 0x1816B4C20
	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x16B3DC0 Offset: 0x16B31C0 VA: 0x1816B3DC0
	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex) { }

}

