internal sealed class RegexReplacement // TypeDefIndex: 2628
{	// Fields
	internal string _rep; // 0x10
	internal List<string> _strings; // 0x18
	internal List<int> _rules; // 0x20

	// Properties
	internal string Pattern { get; }

	// Methods

	// RVA: 0x16B2720 Offset: 0x16B1B20 VA: 0x1816B2720
	internal void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x16B25A0 Offset: 0x16B19A0 VA: 0x1816B25A0
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x16B2420 Offset: 0x16B1820 VA: 0x1816B2420
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal string get_Pattern() { }

	// RVA: 0x16B1E80 Offset: 0x16B1280 VA: 0x1816B1E80
	internal string Replace(Regex regex, string input, int count, int startat) { }

}

