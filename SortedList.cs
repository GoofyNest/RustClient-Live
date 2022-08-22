public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1417
{	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40
	private const int _defaultCapacity = 16;
	private static object[] emptyArray; // 0x0

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
{	private SortedList _list; // 0x48
	private object _root; // 0x50

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
{	private SortedList sortedList; // 0x10
	private object key; // 0x18
	private object value; // 0x20
	private int index; // 0x28
	private int startIndex; // 0x2C
	private int endIndex; // 0x30
	private int version; // 0x34
	private bool current; // 0x38
	private int getObjectRetType; // 0x3C

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
{	private SortedList sortedList; // 0x10

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
{	private SortedList sortedList; // 0x10

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
{	private SortedList<TKey, TValue> _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private int _getEnumeratorRetType; // 0x0

	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }


	internal void .ctor(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230F60 Offset: 0x230360 VA: 0x180230F60
	|-SortedList.Enumerator<long, object>..ctor
	|-SortedList.Enumerator<object, object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FEC0 Offset: 0x22F2C0 VA: 0x18022FEC0
	|-SortedList.Enumerator<long, object>.Dispose
	|-SortedList.Enumerator<object, object>.Dispose
	*/

	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230370 Offset: 0x22F770 VA: 0x180230370
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x230270 Offset: 0x22F670 VA: 0x180230270
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FFB0 Offset: 0x22F3B0 VA: 0x18022FFB0
	|-SortedList.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x22FEF0 Offset: 0x22F2F0 VA: 0x18022FEF0
	|-SortedList.Enumerator<object, object>.MoveNext
	*/

	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FFF0 Offset: 0x22F3F0 VA: 0x18022FFF0
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x230150 Offset: 0x22F550 VA: 0x180230150
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231070 Offset: 0x230470 VA: 0x180231070
	|-SortedList.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x231180 Offset: 0x230580 VA: 0x180231180
	|-SortedList.Enumerator<object, object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230B10 Offset: 0x22FF10 VA: 0x180230B10
	|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230B20 Offset: 0x22FF20 VA: 0x180230B20
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2305B0 Offset: 0x22F9B0 VA: 0x1802305B0
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2304B0 Offset: 0x22F8B0 VA: 0x1802304B0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230740 Offset: 0x22FB40 VA: 0x180230740
	|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x230850 Offset: 0x22FC50 VA: 0x180230850
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	*/

}

private sealed class SortedList.SortedListKeyEnumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 3139
{	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C0C0 Offset: 0x1E2B4C0 VA: 0x181E2C0C0
	|-SortedList.SortedListKeyEnumerator<long, object>..ctor
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BBE0 Offset: 0x1E2AFE0 VA: 0x181E2BBE0
	|-SortedList.SortedListKeyEnumerator<long, object>.Dispose
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BD10 Offset: 0x1E2B110 VA: 0x181E2BD10
	|-SortedList.SortedListKeyEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E2BBF0 Offset: 0x1E2AFF0 VA: 0x181E2BBF0
	|-SortedList.SortedListKeyEnumerator<object, object>.MoveNext
	*/

	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-SortedList.SortedListKeyEnumerator<long, object>.get_Current
	|-SortedList.SortedListKeyEnumerator<object, object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BFE0 Offset: 0x1E2B3E0 VA: 0x181E2BFE0
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E2BF30 Offset: 0x1E2B330 VA: 0x181E2BF30
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BE30 Offset: 0x1E2B230 VA: 0x181E2BE30
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E2BEB0 Offset: 0x1E2B2B0 VA: 0x181E2BEB0
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.Reset
	*/

}

private sealed class SortedList.SortedListValueEnumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 3140
{	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C0C0 Offset: 0x1E2B4C0 VA: 0x181E2C0C0
	|-SortedList.SortedListValueEnumerator<long, object>..ctor
	|-SortedList.SortedListValueEnumerator<object, object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BBE0 Offset: 0x1E2AFE0 VA: 0x181E2BBE0
	|-SortedList.SortedListValueEnumerator<long, object>.Dispose
	|-SortedList.SortedListValueEnumerator<object, object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C110 Offset: 0x1E2B510 VA: 0x181E2C110
	|-SortedList.SortedListValueEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E2C230 Offset: 0x1E2B630 VA: 0x181E2C230
	|-SortedList.SortedListValueEnumerator<object, object>.MoveNext
	*/

	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-SortedList.SortedListValueEnumerator<long, object>.get_Current
	|-SortedList.SortedListValueEnumerator<object, object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C500 Offset: 0x1E2B900 VA: 0x181E2C500
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E2C450 Offset: 0x1E2B850 VA: 0x181E2C450
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C3D0 Offset: 0x1E2B7D0 VA: 0x181E2C3D0
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1E2C350 Offset: 0x1E2B750 VA: 0x181E2C350
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.Reset
	*/

}

private sealed class SortedList.KeyList<TKey, TValue> : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection // TypeDefIndex: 3141
{	private SortedList<TKey, TValue> _dict; // 0x0

	public int Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TKey Item { get; set; }


	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1354950 Offset: 0x1353D50 VA: 0x181354950
	|-SortedList.KeyList<long, object>..ctor
	|-SortedList.KeyList<object, object>..ctor
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133F460 Offset: 0x133E860 VA: 0x18133F460
	|-SortedList.KeyList<long, object>.get_Count
	|-SortedList.KeyList<object, object>.get_Count
	*/

	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	|-SortedList.KeyList<long, object>.get_IsReadOnly
	|-SortedList.KeyList<object, object>.get_IsReadOnly
	*/

	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E284B0 Offset: 0x1E278B0 VA: 0x181E284B0
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E28460 Offset: 0x1E27860 VA: 0x181E28460
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27BB0 Offset: 0x1E26FB0 VA: 0x181E27BB0
	|-SortedList.KeyList<long, object>.Add
	|
	|-RVA: 0x1E27C10 Offset: 0x1E27010 VA: 0x181E27C10
	|-SortedList.KeyList<object, object>.Add
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27C70 Offset: 0x1E27070 VA: 0x181E27C70
	|-SortedList.KeyList<long, object>.Clear
	|
	|-RVA: 0x1E27CD0 Offset: 0x1E270D0 VA: 0x181E27CD0
	|-SortedList.KeyList<object, object>.Clear
	*/

	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2AF0 Offset: 0x15E1EF0 VA: 0x1815E2AF0
	|-SortedList.KeyList<long, object>.Contains
	|-SortedList.KeyList<object, object>.Contains
	*/

	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27D30 Offset: 0x1E27130 VA: 0x181E27D30
	|-SortedList.KeyList<long, object>.CopyTo
	|-SortedList.KeyList<object, object>.CopyTo
	*/

	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28330 Offset: 0x1E27730 VA: 0x181E28330
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E28200 Offset: 0x1E27600 VA: 0x181E28200
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	*/

	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27FC0 Offset: 0x1E273C0 VA: 0x181E27FC0
	|-SortedList.KeyList<long, object>.Insert
	|
	|-RVA: 0x1E28020 Offset: 0x1E27420 VA: 0x181E28020
	|-SortedList.KeyList<object, object>.Insert
	*/

	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28500 Offset: 0x1E27900 VA: 0x181E28500
	|-SortedList.KeyList<long, object>.get_Item
	|-SortedList.KeyList<object, object>.get_Item
	*/

	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28530 Offset: 0x1E27930 VA: 0x181E28530
	|-SortedList.KeyList<long, object>.set_Item
	|
	|-RVA: 0x1E28590 Offset: 0x1E27990 VA: 0x181E28590
	|-SortedList.KeyList<object, object>.set_Item
	*/

	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27DA0 Offset: 0x1E271A0 VA: 0x181E27DA0
	|-SortedList.KeyList<long, object>.GetEnumerator
	|-SortedList.KeyList<object, object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27DA0 Offset: 0x1E271A0 VA: 0x181E27DA0
	|-SortedList.KeyList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27F00 Offset: 0x1E27300 VA: 0x181E27F00
	|-SortedList.KeyList<long, object>.IndexOf
	|
	|-RVA: 0x1E27E10 Offset: 0x1E27210 VA: 0x181E27E10
	|-SortedList.KeyList<object, object>.IndexOf
	*/

	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28140 Offset: 0x1E27540 VA: 0x181E28140
	|-SortedList.KeyList<long, object>.Remove
	|
	|-RVA: 0x1E281A0 Offset: 0x1E275A0 VA: 0x181E281A0
	|-SortedList.KeyList<object, object>.Remove
	*/

	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E280E0 Offset: 0x1E274E0 VA: 0x181E280E0
	|-SortedList.KeyList<long, object>.RemoveAt
	|
	|-RVA: 0x1E28080 Offset: 0x1E27480 VA: 0x181E28080
	|-SortedList.KeyList<object, object>.RemoveAt
	*/

}

private sealed class SortedList.ValueList<TKey, TValue> : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection // TypeDefIndex: 3142
{	private SortedList<TKey, TValue> _dict; // 0x0

	public int Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }


	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1354950 Offset: 0x1353D50 VA: 0x181354950
	|-SortedList.ValueList<long, object>..ctor
	|-SortedList.ValueList<object, object>..ctor
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133F460 Offset: 0x133E860 VA: 0x18133F460
	|-SortedList.ValueList<long, object>.get_Count
	|-SortedList.ValueList<object, object>.get_Count
	*/

	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	|-SortedList.ValueList<long, object>.get_IsReadOnly
	|-SortedList.ValueList<object, object>.get_IsReadOnly
	*/

	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32A70 Offset: 0x1E31E70 VA: 0x181E32A70
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E32A20 Offset: 0x1E31E20 VA: 0x181E32A20
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32380 Offset: 0x1E31780 VA: 0x181E32380
	|-SortedList.ValueList<long, object>.Add
	|
	|-RVA: 0x1E32320 Offset: 0x1E31720 VA: 0x181E32320
	|-SortedList.ValueList<object, object>.Add
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E323E0 Offset: 0x1E317E0 VA: 0x181E323E0
	|-SortedList.ValueList<long, object>.Clear
	|
	|-RVA: 0x1E32440 Offset: 0x1E31840 VA: 0x181E32440
	|-SortedList.ValueList<object, object>.Clear
	*/

	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2AF0 Offset: 0x15E1EF0 VA: 0x1815E2AF0
	|-SortedList.ValueList<long, object>.Contains
	|-SortedList.ValueList<object, object>.Contains
	*/

	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E324A0 Offset: 0x1E318A0 VA: 0x181E324A0
	|-SortedList.ValueList<long, object>.CopyTo
	|-SortedList.ValueList<object, object>.CopyTo
	*/

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E327C0 Offset: 0x1E31BC0 VA: 0x181E327C0
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E328F0 Offset: 0x1E31CF0 VA: 0x181E328F0
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	*/

	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32580 Offset: 0x1E31980 VA: 0x181E32580
	|-SortedList.ValueList<long, object>.Insert
	|
	|-RVA: 0x1E325E0 Offset: 0x1E319E0 VA: 0x181E325E0
	|-SortedList.ValueList<object, object>.Insert
	*/

	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28500 Offset: 0x1E27900 VA: 0x181E28500
	|-SortedList.ValueList<long, object>.get_Item
	|-SortedList.ValueList<object, object>.get_Item
	*/

	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32AC0 Offset: 0x1E31EC0 VA: 0x181E32AC0
	|-SortedList.ValueList<long, object>.set_Item
	|
	|-RVA: 0x1E32B20 Offset: 0x1E31F20 VA: 0x181E32B20
	|-SortedList.ValueList<object, object>.set_Item
	*/

	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27DA0 Offset: 0x1E271A0 VA: 0x181E27DA0
	|-SortedList.ValueList<long, object>.GetEnumerator
	|-SortedList.ValueList<object, object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27DA0 Offset: 0x1E271A0 VA: 0x181E27DA0
	|-SortedList.ValueList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32510 Offset: 0x1E31910 VA: 0x181E32510
	|-SortedList.ValueList<long, object>.IndexOf
	|-SortedList.ValueList<object, object>.IndexOf
	*/

	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32700 Offset: 0x1E31B00 VA: 0x181E32700
	|-SortedList.ValueList<long, object>.Remove
	|
	|-RVA: 0x1E32760 Offset: 0x1E31B60 VA: 0x181E32760
	|-SortedList.ValueList<object, object>.Remove
	*/

	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E326A0 Offset: 0x1E31AA0 VA: 0x181E326A0
	|-SortedList.ValueList<long, object>.RemoveAt
	|
	|-RVA: 0x1E32640 Offset: 0x1E31A40 VA: 0x181E32640
	|-SortedList.ValueList<object, object>.RemoveAt
	*/

}

