public class TraceListenerCollection : IList, ICollection, IEnumerable // TypeDefIndex: 2644
{
	private ArrayList list; 

public int Count { get; }
private object System.Collections.IList.Item { get; set; }
private bool System.Collections.IList.IsReadOnly { get; }
private bool System.Collections.IList.IsFixedSize { get; }
private object System.Collections.ICollection.SyncRoot { get; }


internal void .ctor() { }

public int get_Count() { }

public int Add(TraceListener listener) { }

public void Clear() { }

public IEnumerator GetEnumerator() { }

internal void InitializeListener(TraceListener listener) { }

public void RemoveAt(int index) { }

private object System.Collections.IList.get_Item(int index) { }

private void System.Collections.IList.set_Item(int index, object value) { }

private bool System.Collections.IList.get_IsReadOnly() { }

private bool System.Collections.IList.get_IsFixedSize() { }

private int System.Collections.IList.Add(object value) { }

private bool System.Collections.IList.Contains(object value) { }

private int System.Collections.IList.IndexOf(object value) { }

private void System.Collections.IList.Insert(int index, object value) { }

private void System.Collections.IList.Remove(object value) { }

private object System.Collections.ICollection.get_SyncRoot() { }

private void System.Collections.ICollection.CopyTo(Array array, int index) { }

}

