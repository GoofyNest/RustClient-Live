public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 3110
{
	private ArrayList data; 

	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }


	public string get_Item(int index) { }

	public void set_Item(int index, string value) { }

	public int get_Count() { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private bool System.Collections.IList.get_IsFixedSize() { }

	public int Add(string value) { }

	public void Clear() { }

	public bool Contains(string value) { }

	public void CopyTo(string[] array, int index) { }

	public int IndexOf(string value) { }

	public void Insert(int index, string value) { }

	public void Remove(string value) { }

	public void RemoveAt(int index) { }

	public object get_SyncRoot() { }

	private object System.Collections.IList.get_Item(int index) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

	private int System.Collections.IList.Add(object value) { }

	private bool System.Collections.IList.Contains(object value) { }

	private int System.Collections.IList.IndexOf(object value) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void .ctor() { }

}

