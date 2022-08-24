public class CaptureCollection : ICollection, IEnumerable // TypeDefIndex: 2606
{
	internal Group _group; 
	internal int _capcount; 
	internal Capture[] _captures; 

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

