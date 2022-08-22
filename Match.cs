public class Match : Group // TypeDefIndex: 2620
{	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x40
	internal Regex _regex; // 0x48
	internal int _textbeg; // 0x50
	internal int _textpos; // 0x54
	internal int _textend; // 0x58
	internal int _textstart; // 0x5C
	internal int[][] _matches; // 0x60
	internal int[] _matchcount; // 0x68
	internal bool _balancing; // 0x70

	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }


	public static Match get_Empty() { }

	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	public virtual GroupCollection get_Groups() { }

	public Match NextMatch() { }

	internal virtual string GroupToStringImpl(int groupnum) { }

	internal string LastGroupToStringImpl() { }

	internal virtual void AddMatch(int cap, int start, int len) { }

	internal virtual void BalanceMatch(int cap) { }

	internal virtual void RemoveMatch(int cap) { }

	internal virtual bool IsMatched(int cap) { }

	internal virtual int MatchIndex(int cap) { }

	internal virtual int MatchLength(int cap) { }

	internal virtual void Tidy(int textpos) { }

	private static void .cctor() { }

	internal void .ctor() { }

}

