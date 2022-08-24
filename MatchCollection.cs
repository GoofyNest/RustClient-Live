public class MatchCollection : ICollection, IEnumerable // TypeDefIndex: 2622
{
	internal Regex _regex; 
	internal ArrayList _matches; 
	internal bool _done; 
	internal string _input; 
	internal int _beginning; 
	internal int _length; 
	internal int _startat; 
	internal int _prevlen; 
	private static int infinite; 

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

