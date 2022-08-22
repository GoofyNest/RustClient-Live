public class MatchCollection : ICollection, IEnumerable // TypeDefIndex: 2622
{	internal Regex _regex; // 0x10
	internal ArrayList _matches; // 0x18
	internal bool _done; // 0x20
	internal string _input; // 0x28
	internal int _beginning; // 0x30
	internal int _length; // 0x34
	internal int _startat; // 0x38
	internal int _prevlen; // 0x3C
	private static int infinite; // 0x0

	public int Count { get; }
	public object SyncRoot { get; }


	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	internal Match GetMatch(int i) { }

	public int get_Count() { }

	public object get_SyncRoot() { }

	public void CopyTo(Array array, int arrayIndex) { }

	public IEnumerator GetEnumerator() { }

	private static void .cctor() { }

	internal void .ctor() { }

}

