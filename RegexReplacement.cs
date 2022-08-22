internal sealed class RegexReplacement // TypeDefIndex: 2628
{	internal string _rep; // 0x10
	internal List<string> _strings; // 0x18
	internal List<int> _rules; // 0x20

	internal string Pattern { get; }


	internal void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	private void ReplacementImpl(StringBuilder sb, Match match) { }

	private void ReplacementImplRTL(List<string> al, Match match) { }

	internal string get_Pattern() { }

	internal string Replace(Regex regex, string input, int count, int startat) { }

}

