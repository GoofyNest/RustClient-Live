internal sealed class RegexCode // TypeDefIndex: 2612
{	internal const int Onerep = 0;
	internal const int Notonerep = 1;
	internal const int Setrep = 2;
	internal const int Oneloop = 3;
	internal const int Notoneloop = 4;
	internal const int Setloop = 5;
	internal const int Onelazy = 6;
	internal const int Notonelazy = 7;
	internal const int Setlazy = 8;
	internal const int One = 9;
	internal const int Notone = 10;
	internal const int Set = 11;
	internal const int Multi = 12;
	internal const int Ref = 13;
	internal const int Bol = 14;
	internal const int Eol = 15;
	internal const int Boundary = 16;
	internal const int Nonboundary = 17;
	internal const int Beginning = 18;
	internal const int Start = 19;
	internal const int EndZ = 20;
	internal const int End = 21;
	internal const int Nothing = 22;
	internal const int Lazybranch = 23;
	internal const int Branchmark = 24;
	internal const int Lazybranchmark = 25;
	internal const int Nullcount = 26;
	internal const int Setcount = 27;
	internal const int Branchcount = 28;
	internal const int Lazybranchcount = 29;
	internal const int Nullmark = 30;
	internal const int Setmark = 31;
	internal const int Capturemark = 32;
	internal const int Getmark = 33;
	internal const int Setjump = 34;
	internal const int Backjump = 35;
	internal const int Forejump = 36;
	internal const int Testref = 37;
	internal const int Goto = 38;
	internal const int Prune = 39;
	internal const int Stop = 40;
	internal const int ECMABoundary = 41;
	internal const int NonECMABoundary = 42;
	internal const int Mask = 63;
	internal const int Rtl = 64;
	internal const int Back = 128;
	internal const int Back2 = 256;
	internal const int Ci = 512;
	internal int[] _codes; // 0x10
	internal string[] _strings; // 0x18
	internal int _trackcount; // 0x20
	internal Hashtable _caps; // 0x28
	internal int _capsize; // 0x30
	internal RegexPrefix _fcPrefix; // 0x38
	internal RegexBoyerMoore _bmPrefix; // 0x40
	internal int _anchors; // 0x48
	internal bool _rightToLeft; // 0x4C


	internal void .ctor(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix fcPrefix, int anchors, bool rightToLeft) { }

	internal static bool OpcodeBacktracks(int Op) { }

}

