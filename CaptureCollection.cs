public class CaptureCollection : ICollection, IEnumerable // TypeDefIndex: 2606
{	internal Group _group; // 0x10
	internal int _capcount; // 0x18
	internal Capture[] _captures; // 0x20

	public object SyncRoot { get; }
	public int Count { get; }
	public Capture Item { get; }


	internal void .ctor(Group group) { }

	public object get_SyncRoot() { }

	public int get_Count() { }

	public Capture get_Item(int i) { }

	public void CopyTo(Array array, int arrayIndex) { }

	public IEnumerator GetEnumerator() { }

	internal Capture GetCapture(int i) { }

	internal void .ctor() { }

}

