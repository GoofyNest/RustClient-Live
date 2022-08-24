public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 1384
{
	private ArrayList list; 

protected ArrayList InnerList { get; }
protected IList List { get; }
public int Count { get; }
private bool System.Collections.IList.IsReadOnly { get; }
private bool System.Collections.IList.IsFixedSize { get; }
private object System.Collections.ICollection.SyncRoot { get; }
private object System.Collections.IList.Item { get; set; }


protected void .ctor() { }

protected ArrayList get_InnerList() { }

protected IList get_List() { }

public int get_Count() { }

public void Clear() { }

public void RemoveAt(int index) { }

private bool System.Collections.IList.get_IsReadOnly() { }

private bool System.Collections.IList.get_IsFixedSize() { }

private object System.Collections.ICollection.get_SyncRoot() { }

private void System.Collections.ICollection.CopyTo(Array array, int index) { }

private object System.Collections.IList.get_Item(int index) { }

private void System.Collections.IList.set_Item(int index, object value) { }

private bool System.Collections.IList.Contains(object value) { }

private int System.Collections.IList.Add(object value) { }

private void System.Collections.IList.Remove(object value) { }

private int System.Collections.IList.IndexOf(object value) { }

private void System.Collections.IList.Insert(int index, object value) { }

public IEnumerator GetEnumerator() { }

protected virtual void OnSet(int index, object oldValue, object newValue) { }

protected virtual void OnInsert(int index, object value) { }

protected virtual void OnClear() { }

protected virtual void OnRemove(int index, object value) { }

protected virtual void OnValidate(object value) { }

protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

protected virtual void OnInsertComplete(int index, object value) { }

protected virtual void OnClearComplete() { }

protected virtual void OnRemoveComplete(int index, object value) { }

}

