public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 2793
{
	private ArrayList m_list; 

public Oid Item { get; }
public int Count { get; }
public object SyncRoot { get; }


public void .ctor() { }

public int Add(Oid oid) { }

public Oid get_Item(int index) { }

public int get_Count() { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

private void System.Collections.ICollection.CopyTo(Array array, int index) { }

public object get_SyncRoot() { }

}

