public class Match : Group // TypeDefIndex: 2620
{
	internal static Match _empty; 
	internal GroupCollection _groupcoll; 
	internal Regex _regex; 
	internal int _textbeg; 
	internal int _textpos; 
	internal int _textend; 
	internal int _textstart; 
	internal int[][] _matches; 
	internal int[] _matchcount; 
	internal bool _balancing; 

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

