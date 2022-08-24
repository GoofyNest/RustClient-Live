public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1417
{
	private object[] keys; 
	private object[] values; 
	private int _size; 
	private int version; 
	private IComparer comparer; 
	private SortedList.KeyList keyList; 
	private SortedList.ValueList valueList; 
	private object _syncRoot; 
private const int _defaultCapacity = 16;
	private static object[] emptyArray; 

public virtual int Capacity { get; set; }
public virtual int Count { get; }
public virtual ICollection Keys { get; }
public virtual ICollection Values { get; }
public virtual bool IsReadOnly { get; }
public virtual object SyncRoot { get; }
public virtual object Item { get; set; }


public void .ctor() { }

private void Init() { }

public void .ctor(int initialCapacity) { }

public void .ctor(IComparer comparer) { }

public void .ctor(IComparer comparer, int capacity) { }

public virtual void Add(object key, object value) { }

public virtual int get_Capacity() { }

public virtual void set_Capacity(int value) { }

public virtual int get_Count() { }

public virtual ICollection get_Keys() { }

public virtual ICollection get_Values() { }

public virtual bool get_IsReadOnly() { }

public virtual object get_SyncRoot() { }

public virtual void Clear() { }

public virtual object Clone() { }

public virtual bool Contains(object key) { }

public virtual bool ContainsKey(object key) { }

public virtual bool ContainsValue(object value) { }

public virtual void CopyTo(Array array, int arrayIndex) { }

private void EnsureCapacity(int min) { }

public virtual object GetByIndex(int index) { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

public virtual IDictionaryEnumerator GetEnumerator() { }

public virtual object GetKey(int index) { }

public virtual IList GetKeyList() { }

public virtual IList GetValueList() { }

public virtual object get_Item(object key) { }

public virtual void set_Item(object key, object value) { }

public virtual int IndexOfKey(object key) { }

public virtual int IndexOfValue(object value) { }

private void Insert(int index, object key, object value) { }

public virtual void RemoveAt(int index) { }

public virtual void Remove(object key) { }

public static SortedList Synchronized(SortedList list) { }

private static void .cctor() { }

}

private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 1418
{
	private SortedList _list; 
	private object _root; 

public override int Count { get; }
public override object SyncRoot { get; }
public override bool IsReadOnly { get; }
public override object Item { get; set; }
public override int Capacity { get; }


internal void .ctor(SortedList list) { }

public override int get_Count() { }

public override object get_SyncRoot() { }

public override bool get_IsReadOnly() { }

public override object get_Item(object key) { }

public override void set_Item(object key, object value) { }

public override void Add(object key, object value) { }

public override int get_Capacity() { }

public override void Clear() { }

public override object Clone() { }

public override bool Contains(object key) { }

public override bool ContainsKey(object key) { }

public override bool ContainsValue(object key) { }

public override void CopyTo(Array array, int index) { }

public override object GetByIndex(int index) { }

public override IDictionaryEnumerator GetEnumerator() { }

public override object GetKey(int index) { }

public override IList GetKeyList() { }

public override IList GetValueList() { }

public override int IndexOfKey(object key) { }

public override int IndexOfValue(object value) { }

public override void RemoveAt(int index) { }

public override void Remove(object key) { }

}

private class SortedList.SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1419
{
	private SortedList sortedList; 
	private object key; 
	private object value; 
	private int index; 
	private int startIndex; 
	private int endIndex; 
	private int version; 
	private bool current; 
	private int getObjectRetType; 

public virtual object Key { get; }
public virtual DictionaryEntry Entry { get; }
public virtual object Current { get; }
public virtual object Value { get; }


internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

public object Clone() { }

public virtual object get_Key() { }

public virtual bool MoveNext() { }

public virtual DictionaryEntry get_Entry() { }

public virtual object get_Current() { }

public virtual object get_Value() { }

public virtual void Reset() { }

}

private class SortedList.KeyList : IList, ICollection, IEnumerable // TypeDefIndex: 1420
{
	private SortedList sortedList; 

public virtual int Count { get; }
public virtual bool IsReadOnly { get; }
public virtual bool IsFixedSize { get; }
public virtual object SyncRoot { get; }
public virtual object Item { get; set; }


internal void .ctor(SortedList sortedList) { }

public virtual int get_Count() { }

public virtual bool get_IsReadOnly() { }

public virtual bool get_IsFixedSize() { }

public virtual object get_SyncRoot() { }

public virtual int Add(object key) { }

public virtual void Clear() { }

public virtual bool Contains(object key) { }

public virtual void CopyTo(Array array, int arrayIndex) { }

public virtual void Insert(int index, object value) { }

public virtual object get_Item(int index) { }

public virtual void set_Item(int index, object value) { }

public virtual IEnumerator GetEnumerator() { }

public virtual int IndexOf(object key) { }

public virtual void Remove(object key) { }

public virtual void RemoveAt(int index) { }

}

private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 1421
{
	private SortedList sortedList; 

public virtual int Count { get; }
public virtual bool IsReadOnly { get; }
public virtual bool IsFixedSize { get; }
public virtual object SyncRoot { get; }
public virtual object Item { get; set; }


internal void .ctor(SortedList sortedList) { }

public virtual int get_Count() { }

public virtual bool get_IsReadOnly() { }

public virtual bool get_IsFixedSize() { }

public virtual object get_SyncRoot() { }

public virtual int Add(object key) { }

public virtual void Clear() { }

public virtual bool Contains(object value) { }

public virtual void CopyTo(Array array, int arrayIndex) { }

public virtual void Insert(int index, object value) { }

public virtual object get_Item(int index) { }

public virtual void set_Item(int index, object value) { }

public virtual IEnumerator GetEnumerator() { }

public virtual int IndexOf(object value) { }

public virtual void Remove(object value) { }

public virtual void RemoveAt(int index) { }

}

private struct SortedList.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 3138
{
	private SortedList<TKey, TValue> _sortedList; 
	private TKey _key; 
	private TValue _value; 
	private int _index; 
	private int _version; 
	private int _getEnumeratorRetType; 

private object System.Collections.IDictionaryEnumerator.Key { get; }
private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
public KeyValuePair<TKey, TValue> Current { get; }
private object System.Collections.IEnumerator.Current { get; }
private object System.Collections.IDictionaryEnumerator.Value { get; }


internal void .ctor(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>..ctor
|-SortedList.Enumerator<object, object>..ctor
*/

public void Dispose() { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>.Dispose
|-SortedList.Enumerator<object, object>.Dispose
*/

private object System.Collections.IDictionaryEnumerator.get_Key() { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
|
|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
*/

public bool MoveNext() { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>.MoveNext
|
|-SortedList.Enumerator<object, object>.MoveNext
*/

private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
|
|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
*/

public KeyValuePair<TKey, TValue> get_Current() { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>.get_Current
|
|-SortedList.Enumerator<object, object>.get_Current
*/

private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
|
|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
*/

private object System.Collections.IDictionaryEnumerator.get_Value() { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
|
|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
*/

private void System.Collections.IEnumerator.Reset() { }
/* GenericInstMethod :
|
|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.Reset
|
|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.Reset
*/

}

private sealed class SortedList.SortedListKeyEnumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 3139
{
	private SortedList<TKey, TValue> _sortedList; 
	private int _index; 
	private int _version; 
	private TKey _currentKey; 

public TKey Current { get; }
private object System.Collections.IEnumerator.Current { get; }


internal void .ctor(SortedList<TKey, TValue> sortedList) { }
/* GenericInstMethod :
|
|-SortedList.SortedListKeyEnumerator<long, object>..ctor
|-SortedList.SortedListKeyEnumerator<object, object>..ctor
*/

public void Dispose() { }
/* GenericInstMethod :
|
|-SortedList.SortedListKeyEnumerator<long, object>.Dispose
|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
*/

public bool MoveNext() { }
/* GenericInstMethod :
|
|-SortedList.SortedListKeyEnumerator<long, object>.MoveNext
|
|-SortedList.SortedListKeyEnumerator<object, object>.MoveNext
*/

public TKey get_Current() { }
/* GenericInstMethod :
|
|-SortedList.SortedListKeyEnumerator<long, object>.get_Current
|-SortedList.SortedListKeyEnumerator<object, object>.get_Current
*/

private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.get_Current
|
|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
*/

private void System.Collections.IEnumerator.Reset() { }
/* GenericInstMethod :
|
|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.Reset
|
|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.Reset
*/

}

private sealed class SortedList.SortedListValueEnumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 3140
{
	private SortedList<TKey, TValue> _sortedList; 
	private int _index; 
	private int _version; 
	private TValue _currentValue; 

public TValue Current { get; }
private object System.Collections.IEnumerator.Current { get; }


internal void .ctor(SortedList<TKey, TValue> sortedList) { }
/* GenericInstMethod :
|
|-SortedList.SortedListValueEnumerator<long, object>..ctor
|-SortedList.SortedListValueEnumerator<object, object>..ctor
*/

public void Dispose() { }
/* GenericInstMethod :
|
|-SortedList.SortedListValueEnumerator<long, object>.Dispose
|-SortedList.SortedListValueEnumerator<object, object>.Dispose
*/

public bool MoveNext() { }
/* GenericInstMethod :
|
|-SortedList.SortedListValueEnumerator<long, object>.MoveNext
|
|-SortedList.SortedListValueEnumerator<object, object>.MoveNext
*/

public TValue get_Current() { }
/* GenericInstMethod :
|
|-SortedList.SortedListValueEnumerator<long, object>.get_Current
|-SortedList.SortedListValueEnumerator<object, object>.get_Current
*/

private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.get_Current
|
|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
*/

private void System.Collections.IEnumerator.Reset() { }
/* GenericInstMethod :
|
|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.Reset
|
|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.Reset
*/

}

private sealed class SortedList.KeyList<TKey, TValue> : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection // TypeDefIndex: 3141
{
	private SortedList<TKey, TValue> _dict; 

public int Count { get; }
public bool IsReadOnly { get; }
private object System.Collections.ICollection.SyncRoot { get; }
public TKey Item { get; set; }


internal void .ctor(SortedList<TKey, TValue> dictionary) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>..ctor
|-SortedList.KeyList<object, object>..ctor
*/

public int get_Count() { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.get_Count
|-SortedList.KeyList<object, object>.get_Count
*/

public bool get_IsReadOnly() { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.get_IsReadOnly
|-SortedList.KeyList<object, object>.get_IsReadOnly
*/

private object System.Collections.ICollection.get_SyncRoot() { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.System.Collections.ICollection.get_SyncRoot
|
|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
*/

public void Add(TKey key) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.Add
|
|-SortedList.KeyList<object, object>.Add
*/

public void Clear() { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.Clear
|
|-SortedList.KeyList<object, object>.Clear
*/

public bool Contains(TKey key) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.Contains
|-SortedList.KeyList<object, object>.Contains
*/

public void CopyTo(TKey[] array, int arrayIndex) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.CopyTo
|-SortedList.KeyList<object, object>.CopyTo
*/

private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.System.Collections.ICollection.CopyTo
|
|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
*/

public void Insert(int index, TKey value) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.Insert
|
|-SortedList.KeyList<object, object>.Insert
*/

public TKey get_Item(int index) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.get_Item
|-SortedList.KeyList<object, object>.get_Item
*/

public void set_Item(int index, TKey value) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.set_Item
|
|-SortedList.KeyList<object, object>.set_Item
*/

public IEnumerator<TKey> GetEnumerator() { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.GetEnumerator
|-SortedList.KeyList<object, object>.GetEnumerator
*/

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.System.Collections.IEnumerable.GetEnumerator
|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
*/

public int IndexOf(TKey key) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.IndexOf
|
|-SortedList.KeyList<object, object>.IndexOf
*/

public bool Remove(TKey key) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.Remove
|
|-SortedList.KeyList<object, object>.Remove
*/

public void RemoveAt(int index) { }
/* GenericInstMethod :
|
|-SortedList.KeyList<long, object>.RemoveAt
|
|-SortedList.KeyList<object, object>.RemoveAt
*/

}

private sealed class SortedList.ValueList<TKey, TValue> : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection // TypeDefIndex: 3142
{
	private SortedList<TKey, TValue> _dict; 

public int Count { get; }
public bool IsReadOnly { get; }
private object System.Collections.ICollection.SyncRoot { get; }
public TValue Item { get; set; }


internal void .ctor(SortedList<TKey, TValue> dictionary) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>..ctor
|-SortedList.ValueList<object, object>..ctor
*/

public int get_Count() { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.get_Count
|-SortedList.ValueList<object, object>.get_Count
*/

public bool get_IsReadOnly() { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.get_IsReadOnly
|-SortedList.ValueList<object, object>.get_IsReadOnly
*/

private object System.Collections.ICollection.get_SyncRoot() { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.System.Collections.ICollection.get_SyncRoot
|
|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
*/

public void Add(TValue key) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.Add
|
|-SortedList.ValueList<object, object>.Add
*/

public void Clear() { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.Clear
|
|-SortedList.ValueList<object, object>.Clear
*/

public bool Contains(TValue value) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.Contains
|-SortedList.ValueList<object, object>.Contains
*/

public void CopyTo(TValue[] array, int arrayIndex) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.CopyTo
|-SortedList.ValueList<object, object>.CopyTo
*/

private void System.Collections.ICollection.CopyTo(Array array, int index) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.System.Collections.ICollection.CopyTo
|
|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
*/

public void Insert(int index, TValue value) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.Insert
|
|-SortedList.ValueList<object, object>.Insert
*/

public TValue get_Item(int index) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.get_Item
|-SortedList.ValueList<object, object>.get_Item
*/

public void set_Item(int index, TValue value) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.set_Item
|
|-SortedList.ValueList<object, object>.set_Item
*/

public IEnumerator<TValue> GetEnumerator() { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.GetEnumerator
|-SortedList.ValueList<object, object>.GetEnumerator
*/

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.System.Collections.IEnumerable.GetEnumerator
|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
*/

public int IndexOf(TValue value) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.IndexOf
|-SortedList.ValueList<object, object>.IndexOf
*/

public bool Remove(TValue value) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.Remove
|
|-SortedList.ValueList<object, object>.Remove
*/

public void RemoveAt(int index) { }
/* GenericInstMethod :
|
|-SortedList.ValueList<long, object>.RemoveAt
|
|-SortedList.ValueList<object, object>.RemoveAt
*/

}

