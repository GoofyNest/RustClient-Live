public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary // TypeDefIndex: 2735
{
	public static readonly PropertyDescriptorCollection Empty; 
	private IDictionary cachedFoundProperties; 
	private bool cachedIgnoreCase; 
	private PropertyDescriptor[] properties; 
	private int propCount; 
	private string[] namedSort; 
	private IComparer comparer; 
	private bool propsOwned; 
	private bool needSort; 
	private bool readOnly; 

	public int Count { get; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }


	public void .ctor(PropertyDescriptor[] properties) { }

	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	public int get_Count() { }

	public virtual PropertyDescriptor get_Item(int index) { }

	public virtual PropertyDescriptor get_Item(string name) { }

	public int Add(PropertyDescriptor value) { }

	public void Clear() { }

	public bool Contains(PropertyDescriptor value) { }

	public void CopyTo(Array array, int index) { }

	private void EnsurePropsOwned() { }

	private void EnsureSize(int sizeNeeded) { }

	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	public int IndexOf(PropertyDescriptor value) { }

	public void Insert(int index, PropertyDescriptor value) { }

	public void Remove(PropertyDescriptor value) { }

	public void RemoveAt(int index) { }

	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	protected void InternalSort(string[] names) { }

	protected void InternalSort(IComparer sorter) { }

	public virtual IEnumerator GetEnumerator() { }

	private int System.Collections.ICollection.get_Count() { }

	private object System.Collections.ICollection.get_SyncRoot() { }

	private void System.Collections.IDictionary.Add(object key, object value) { }

	private void System.Collections.IDictionary.Clear() { }

	private bool System.Collections.IDictionary.Contains(object key) { }

	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	private object System.Collections.IDictionary.get_Item(object key) { }

	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	private ICollection System.Collections.IDictionary.get_Keys() { }

	private ICollection System.Collections.IDictionary.get_Values() { }

	private void System.Collections.IDictionary.Remove(object key) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private int System.Collections.IList.Add(object value) { }

	private void System.Collections.IList.Clear() { }

	private bool System.Collections.IList.Contains(object value) { }

	private int System.Collections.IList.IndexOf(object value) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private bool System.Collections.IList.get_IsFixedSize() { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.IList.RemoveAt(int index) { }

	private object System.Collections.IList.get_Item(int index) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

	private static void .cctor() { }

}

private class PropertyDescriptorCollection.PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2736
{
	private PropertyDescriptorCollection owner; 
	private int index; 

	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }


	public void .ctor(PropertyDescriptorCollection owner) { }

	public object get_Current() { }

	public DictionaryEntry get_Entry() { }

	public object get_Key() { }

	public object get_Value() { }

	public bool MoveNext() { }

	public void Reset() { }

}

