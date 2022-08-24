public class GroupCollection : ICollection, IEnumerable // TypeDefIndex: 2617
{
	internal Match _match; 
	internal Hashtable _captureMap; 
	internal Group[] _groups; 

	public object SyncRoot { get; }
	public int Count { get; }
	public Group Item { get; }
	public Group Item { get; }


	internal void .ctor(Match match, Hashtable caps) { }

	public object get_SyncRoot() { }

	public int get_Count() { }

	public Group get_Item(int groupnum) { }

	public Group get_Item(string groupname) { }

	internal Group GetGroup(int groupnum) { }

	internal Group GetGroupImpl(int groupnum) { }

	public void CopyTo(Array array, int arrayIndex) { }

	public IEnumerator GetEnumerator() { }

	internal void .ctor() { }

}

