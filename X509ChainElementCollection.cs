public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 2824
{
	private ArrayList _list; 

public int Count { get; }
public X509ChainElement Item { get; }
public object SyncRoot { get; }


internal void .ctor() { }

public int get_Count() { }

public X509ChainElement get_Item(int index) { }

public object get_SyncRoot() { }

private void System.Collections.ICollection.CopyTo(Array array, int index) { }

public X509ChainElementEnumerator GetEnumerator() { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

internal void Add(X509Certificate2 certificate) { }

internal void Clear() { }

internal bool Contains(X509Certificate2 certificate) { }

}

