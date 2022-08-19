public class Match : Group // TypeDefIndex: 2620
{	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x40
	internal Regex _regex; // 0x48
	internal int _textbeg; // 0x50
	internal int _textpos; // 0x54
	internal int _textend; // 0x58
	internal int _textstart; // 0x5C
	internal int[][] _matches; // 0x60
	internal int[] _matchcount; // 0x68
	internal bool _balancing; // 0x70

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x14C4200 Offset: 0x14C3600 VA: 0x1814C4200
	public static Match get_Empty() { }

	// RVA: 0x14C4020 Offset: 0x14C3420 VA: 0x1814C4020
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x14C3C90 Offset: 0x14C3090 VA: 0x1814C3C90 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x14C4260 Offset: 0x14C3660 VA: 0x1814C4260 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x14C3C00 Offset: 0x14C3000 VA: 0x1814C3C00
	public Match NextMatch() { }

	// RVA: 0x14C38A0 Offset: 0x14C2CA0 VA: 0x1814C38A0 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x14C3A50 Offset: 0x14C2E50 VA: 0x1814C3A50
	internal string LastGroupToStringImpl() { }

	// RVA: 0x14C3410 Offset: 0x14C2810 VA: 0x1814C3410 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x14C3740 Offset: 0x14C2B40 VA: 0x1814C3740 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x14C3C50 Offset: 0x14C3050 VA: 0x1814C3C50 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x14C39B0 Offset: 0x14C2DB0 VA: 0x1814C39B0 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x14C3A80 Offset: 0x14C2E80 VA: 0x1814C3A80 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x14C3B40 Offset: 0x14C2F40 VA: 0x1814C3B40 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x14C3D50 Offset: 0x14C3150 VA: 0x1814C3D50 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x14C3F90 Offset: 0x14C3390 VA: 0x1814C3F90
	private static void .cctor() { }

	// RVA: 0x14C41D0 Offset: 0x14C35D0 VA: 0x1814C41D0
	internal void .ctor() { }

}

