internal sealed class RegexTree // TypeDefIndex: 2631
{	// Fields
	internal RegexNode _root; // 0x10
	internal Hashtable _caps; // 0x18
	internal int[] _capnumlist; // 0x20
	internal Hashtable _capnames; // 0x28
	internal string[] _capslist; // 0x30
	internal RegexOptions _options; // 0x38
	internal int _captop; // 0x3C

	// Methods

	// RVA: 0x16B3D20 Offset: 0x16B3120 VA: 0x1816B3D20
	internal void .ctor(RegexNode root, Hashtable caps, int[] capnumlist, int captop, Hashtable capnames, string[] capslist, RegexOptions opts) { }

}

