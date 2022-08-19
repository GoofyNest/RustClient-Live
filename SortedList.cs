public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1417
{	// Fields
	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40
	private const int _defaultCapacity = 16;
	private static object[] emptyArray; // 0x0

	// Properties
	public virtual int Capacity { get; set; }
	public virtual int Count { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual bool IsReadOnly { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x1464D40 Offset: 0x1464140 VA: 0x181464D40
	public void .ctor() { }

	// RVA: 0x14644D0 Offset: 0x14638D0 VA: 0x1814644D0
	private void Init() { }

	// RVA: 0x1464BA0 Offset: 0x1463FA0 VA: 0x181464BA0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x1464EB0 Offset: 0x14642B0 VA: 0x181464EB0
	public void .ctor(IComparer comparer) { }

	// RVA: 0x1464EF0 Offset: 0x14642F0 VA: 0x181464EF0
	public void .ctor(IComparer comparer, int capacity) { }

	// RVA: 0x1463950 Offset: 0x1462D50 VA: 0x181463950 Slot: 19
	public virtual void Add(object key, object value) { }

	// RVA: 0xA4F990 Offset: 0xA4ED90 VA: 0x180A4F990 Slot: 20
	public virtual int get_Capacity() { }

	// RVA: 0x1465060 Offset: 0x1464460 VA: 0x181465060 Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x1464FB0 Offset: 0x14643B0 VA: 0x181464FB0 Slot: 23
	public virtual ICollection get_Keys() { }

	// RVA: 0x1465040 Offset: 0x1464440 VA: 0x181465040 Slot: 24
	public virtual ICollection get_Values() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 25
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1464FD0 Offset: 0x14643D0 VA: 0x181464FD0 Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x1463AE0 Offset: 0x1462EE0 VA: 0x181463AE0 Slot: 27
	public virtual void Clear() { }

	// RVA: 0x1463B20 Offset: 0x1462F20 VA: 0x181463B20 Slot: 28
	public virtual object Clone() { }

	// RVA: 0x1463D60 Offset: 0x1463160 VA: 0x181463D60 Slot: 29
	public virtual bool Contains(object key) { }

	// RVA: 0x1463D60 Offset: 0x1463160 VA: 0x181463D60 Slot: 30
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1463D80 Offset: 0x1463180 VA: 0x181463D80 Slot: 31
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x1463DA0 Offset: 0x14631A0 VA: 0x181463DA0 Slot: 32
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1464040 Offset: 0x1463440 VA: 0x181464040
	private void EnsureCapacity(int min) { }

	// RVA: 0x1464090 Offset: 0x1463490 VA: 0x181464090 Slot: 33
	public virtual object GetByIndex(int index) { }

	// RVA: 0x1464AA0 Offset: 0x1463EA0 VA: 0x181464AA0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1464150 Offset: 0x1463550 VA: 0x181464150 Slot: 34
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1464270 Offset: 0x1463670 VA: 0x181464270 Slot: 35
	public virtual object GetKey(int index) { }

	// RVA: 0x14641E0 Offset: 0x14635E0 VA: 0x1814641E0 Slot: 36
	public virtual IList GetKeyList() { }

	// RVA: 0x1464330 Offset: 0x1463730 VA: 0x181464330 Slot: 37
	public virtual IList GetValueList() { }

	// RVA: 0x1464F50 Offset: 0x1464350 VA: 0x181464F50 Slot: 38
	public virtual object get_Item(object key) { }

	// RVA: 0x1465220 Offset: 0x1464620 VA: 0x181465220 Slot: 39
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x14643C0 Offset: 0x14637C0 VA: 0x1814643C0 Slot: 40
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x1464470 Offset: 0x1463870 VA: 0x181464470 Slot: 41
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x1464640 Offset: 0x1463A40 VA: 0x181464640
	private void Insert(int index, object key, object value) { }

	// RVA: 0x14647E0 Offset: 0x1463BE0 VA: 0x1814647E0 Slot: 42
	public virtual void RemoveAt(int index) { }

	// RVA: 0x1464960 Offset: 0x1463D60 VA: 0x181464960 Slot: 43
	public virtual void Remove(object key) { }

	// RVA: 0x14649A0 Offset: 0x1463DA0 VA: 0x1814649A0
	public static SortedList Synchronized(SortedList list) { }

	// RVA: 0x1464B30 Offset: 0x1463F30 VA: 0x181464B30
	private static void .cctor() { }

}

private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 1418
{	// Fields
	private SortedList _list; // 0x48
	private object _root; // 0x50

	// Properties
	public override int Count { get; }
	public override object SyncRoot { get; }
	public override bool IsReadOnly { get; }
	public override object Item { get; set; }
	public override int Capacity { get; }

	// Methods

	// RVA: 0x1467BC0 Offset: 0x1466FC0 VA: 0x181467BC0
	internal void .ctor(SortedList list) { }

	// RVA: 0x1467D40 Offset: 0x1467140 VA: 0x181467D40 Slot: 22
	public override int get_Count() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x1467E20 Offset: 0x1467220 VA: 0x181467E20 Slot: 25
	public override bool get_IsReadOnly() { }

	// RVA: 0x1467E50 Offset: 0x1467250 VA: 0x181467E50 Slot: 38
	public override object get_Item(object key) { }

	// RVA: 0x1467F30 Offset: 0x1467330 VA: 0x181467F30 Slot: 39
	public override void set_Item(object key, object value) { }

	// RVA: 0x1466D60 Offset: 0x1466160 VA: 0x181466D60 Slot: 19
	public override void Add(object key, object value) { }

	// RVA: 0x1467C60 Offset: 0x1467060 VA: 0x181467C60 Slot: 20
	public override int get_Capacity() { }

	// RVA: 0x1466E40 Offset: 0x1466240 VA: 0x181466E40 Slot: 27
	public override void Clear() { }

	// RVA: 0x1466F00 Offset: 0x1466300 VA: 0x181466F00 Slot: 28
	public override object Clone() { }

	// RVA: 0x14671C0 Offset: 0x14665C0 VA: 0x1814671C0 Slot: 29
	public override bool Contains(object key) { }

	// RVA: 0x1466FE0 Offset: 0x14663E0 VA: 0x181466FE0 Slot: 30
	public override bool ContainsKey(object key) { }

	// RVA: 0x14670D0 Offset: 0x14664D0 VA: 0x1814670D0 Slot: 31
	public override bool ContainsValue(object key) { }

	// RVA: 0x14672B0 Offset: 0x14666B0 VA: 0x1814672B0 Slot: 32
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x1467390 Offset: 0x1466790 VA: 0x181467390 Slot: 33
	public override object GetByIndex(int index) { }

	// RVA: 0x1467470 Offset: 0x1466870 VA: 0x181467470 Slot: 34
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1467630 Offset: 0x1466A30 VA: 0x181467630 Slot: 35
	public override object GetKey(int index) { }

	// RVA: 0x1467550 Offset: 0x1466950 VA: 0x181467550 Slot: 36
	public override IList GetKeyList() { }

	// RVA: 0x1467710 Offset: 0x1466B10 VA: 0x181467710 Slot: 37
	public override IList GetValueList() { }

	// RVA: 0x14677F0 Offset: 0x1466BF0 VA: 0x1814677F0 Slot: 40
	public override int IndexOfKey(object key) { }

	// RVA: 0x1467940 Offset: 0x1466D40 VA: 0x181467940 Slot: 41
	public override int IndexOfValue(object value) { }

	// RVA: 0x1467A20 Offset: 0x1466E20 VA: 0x181467A20 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x1467AF0 Offset: 0x1466EF0 VA: 0x181467AF0 Slot: 43
	public override void Remove(object key) { }

}

private class SortedList.SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1419
{	// Fields
	private SortedList sortedList; // 0x10
	private object key; // 0x18
	private object value; // 0x20
	private int index; // 0x28
	private int startIndex; // 0x2C
	private int endIndex; // 0x30
	private int version; // 0x34
	private bool current; // 0x38
	private int getObjectRetType; // 0x3C

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x1463510 Offset: 0x1462910 VA: 0x181463510
	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 10
	public object Clone() { }

	// RVA: 0x1463790 Offset: 0x1462B90 VA: 0x181463790 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x1463320 Offset: 0x1462720 VA: 0x181463320 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x1463690 Offset: 0x1462A90 VA: 0x181463690 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x1463590 Offset: 0x1462990 VA: 0x181463590 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1463870 Offset: 0x1462C70 VA: 0x181463870 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x1463460 Offset: 0x1462860 VA: 0x181463460 Slot: 16
	public virtual void Reset() { }

}

private class SortedList.KeyList : IList, ICollection, IEnumerable // TypeDefIndex: 1420
{	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x133F460 Offset: 0x133E860 VA: 0x18133F460 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 21
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x1343720 Offset: 0x1342B20 VA: 0x181343720 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x145F560 Offset: 0x145E960 VA: 0x18145F560 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x145F5D0 Offset: 0x145E9D0 VA: 0x18145F5D0 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x145F640 Offset: 0x145EA40 VA: 0x18145F640 Slot: 25
	public virtual bool Contains(object key) { }

	// RVA: 0x145F670 Offset: 0x145EA70 VA: 0x18145F670 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x145F8F0 Offset: 0x145ECF0 VA: 0x18145F8F0 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x145FA40 Offset: 0x145EE40 VA: 0x18145FA40 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x145FA70 Offset: 0x145EE70 VA: 0x18145FA70 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x145F750 Offset: 0x145EB50 VA: 0x18145F750 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x145F800 Offset: 0x145EC00 VA: 0x18145F800 Slot: 31
	public virtual int IndexOf(object key) { }

	// RVA: 0x145F9D0 Offset: 0x145EDD0 VA: 0x18145F9D0 Slot: 32
	public virtual void Remove(object key) { }

	// RVA: 0x145F960 Offset: 0x145ED60 VA: 0x18145F960 Slot: 33
	public virtual void RemoveAt(int index) { }

}

private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 1421
{	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x133F460 Offset: 0x133E860 VA: 0x18133F460 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 21
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x1343720 Offset: 0x1342B20 VA: 0x181343720 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x14682B0 Offset: 0x14676B0 VA: 0x1814682B0 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x1468320 Offset: 0x1467720 VA: 0x181468320 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x1468390 Offset: 0x1467790 VA: 0x181468390 Slot: 25
	public virtual bool Contains(object value) { }

	// RVA: 0x14683C0 Offset: 0x14677C0 VA: 0x1814683C0 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14685D0 Offset: 0x14679D0 VA: 0x1814685D0 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x1468720 Offset: 0x1467B20 VA: 0x181468720 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x1468750 Offset: 0x1467B50 VA: 0x181468750 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x14684A0 Offset: 0x14678A0 VA: 0x1814684A0 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1468550 Offset: 0x1467950 VA: 0x181468550 Slot: 31
	public virtual int IndexOf(object value) { }

	// RVA: 0x14686B0 Offset: 0x1467AB0 VA: 0x1814686B0 Slot: 32
	public virtual void Remove(object value) { }

	// RVA: 0x1468640 Offset: 0x1467A40 VA: 0x181468640 Slot: 33
	public virtual void RemoveAt(int index) { }

}

private struct SortedList.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 3138
{	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230F60 Offset: 0x230360 VA: 0x180230F60
	|-SortedList.Enumerator<long, object>..ctor
	|-SortedList.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FEC0 Offset: 0x22F2C0 VA: 0x18022FEC0
	|-SortedList.Enumerator<long, object>.Dispose
	|-SortedList.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230370 Offset: 0x22F770 VA: 0x180230370
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x230270 Offset: 0x22F670 VA: 0x180230270
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FFB0 Offset: 0x22F3B0 VA: 0x18022FFB0
	|-SortedList.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x22FEF0 Offset: 0x22F2F0 VA: 0x18022FEF0
	|-SortedList.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22FFF0 Offset: 0x22F3F0 VA: 0x18022FFF0
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x230150 Offset: 0x22F550 VA: 0x180230150
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231070 Offset: 0x230470 VA: 0x180231070
	|-SortedList.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x231180 Offset: 0x230580 VA: 0x180231180
	|-SortedList.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230B10 Offset: 0x22FF10 VA: 0x180230B10
	|-SortedList.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230B20 Offset: 0x22FF20 VA: 0x180230B20
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2305B0 Offset: 0x22F9B0 VA: 0x1802305B0
	|-SortedList.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2304B0 Offset: 0x22F8B0 VA: 0x1802304B0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
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
{	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C0C0 Offset: 0x1E2B4C0 VA: 0x181E2C0C0
	|-SortedList.SortedListKeyEnumerator<long, object>..ctor
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BBE0 Offset: 0x1E2AFE0 VA: 0x181E2BBE0
	|-SortedList.SortedListKeyEnumerator<long, object>.Dispose
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BD10 Offset: 0x1E2B110 VA: 0x181E2BD10
	|-SortedList.SortedListKeyEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E2BBF0 Offset: 0x1E2AFF0 VA: 0x181E2BBF0
	|-SortedList.SortedListKeyEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-SortedList.SortedListKeyEnumerator<long, object>.get_Current
	|-SortedList.SortedListKeyEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BFE0 Offset: 0x1E2B3E0 VA: 0x181E2BFE0
	|-SortedList.SortedListKeyEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E2BF30 Offset: 0x1E2B330 VA: 0x181E2BF30
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
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
{	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C0C0 Offset: 0x1E2B4C0 VA: 0x181E2C0C0
	|-SortedList.SortedListValueEnumerator<long, object>..ctor
	|-SortedList.SortedListValueEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2BBE0 Offset: 0x1E2AFE0 VA: 0x181E2BBE0
	|-SortedList.SortedListValueEnumerator<long, object>.Dispose
	|-SortedList.SortedListValueEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C110 Offset: 0x1E2B510 VA: 0x181E2C110
	|-SortedList.SortedListValueEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x1E2C230 Offset: 0x1E2B630 VA: 0x181E2C230
	|-SortedList.SortedListValueEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-SortedList.SortedListValueEnumerator<long, object>.get_Current
	|-SortedList.SortedListValueEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C500 Offset: 0x1E2B900 VA: 0x181E2C500
	|-SortedList.SortedListValueEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1E2C450 Offset: 0x1E2B850 VA: 0x181E2C450
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
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
{	// Fields
	private SortedList<TKey, TValue> _dict; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TKey Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1354950 Offset: 0x1353D50 VA: 0x181354950
	|-SortedList.KeyList<long, object>..ctor
	|-SortedList.KeyList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133F460 Offset: 0x133E860 VA: 0x18133F460
	|-SortedList.KeyList<long, object>.get_Count
	|-SortedList.KeyList<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	|-SortedList.KeyList<long, object>.get_IsReadOnly
	|-SortedList.KeyList<object, object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E284B0 Offset: 0x1E278B0 VA: 0x181E284B0
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E28460 Offset: 0x1E27860 VA: 0x181E28460
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27BB0 Offset: 0x1E26FB0 VA: 0x181E27BB0
	|-SortedList.KeyList<long, object>.Add
	|
	|-RVA: 0x1E27C10 Offset: 0x1E27010 VA: 0x181E27C10
	|-SortedList.KeyList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27C70 Offset: 0x1E27070 VA: 0x181E27C70
	|-SortedList.KeyList<long, object>.Clear
	|
	|-RVA: 0x1E27CD0 Offset: 0x1E270D0 VA: 0x181E27CD0
	|-SortedList.KeyList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2AF0 Offset: 0x15E1EF0 VA: 0x1815E2AF0
	|-SortedList.KeyList<long, object>.Contains
	|-SortedList.KeyList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27D30 Offset: 0x1E27130 VA: 0x181E27D30
	|-SortedList.KeyList<long, object>.CopyTo
	|-SortedList.KeyList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28330 Offset: 0x1E27730 VA: 0x181E28330
	|-SortedList.KeyList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E28200 Offset: 0x1E27600 VA: 0x181E28200
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27FC0 Offset: 0x1E273C0 VA: 0x181E27FC0
	|-SortedList.KeyList<long, object>.Insert
	|
	|-RVA: 0x1E28020 Offset: 0x1E27420 VA: 0x181E28020
	|-SortedList.KeyList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28500 Offset: 0x1E27900 VA: 0x181E28500
	|-SortedList.KeyList<long, object>.get_Item
	|-SortedList.KeyList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28530 Offset: 0x1E27930 VA: 0x181E28530
	|-SortedList.KeyList<long, object>.set_Item
	|
	|-RVA: 0x1E28590 Offset: 0x1E27990 VA: 0x181E28590
	|-SortedList.KeyList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27DA0 Offset: 0x1E271A0 VA: 0x181E27DA0
	|-SortedList.KeyList<long, object>.GetEnumerator
	|-SortedList.KeyList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27DA0 Offset: 0x1E271A0 VA: 0x181E27DA0
	|-SortedList.KeyList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27F00 Offset: 0x1E27300 VA: 0x181E27F00
	|-SortedList.KeyList<long, object>.IndexOf
	|
	|-RVA: 0x1E27E10 Offset: 0x1E27210 VA: 0x181E27E10
	|-SortedList.KeyList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28140 Offset: 0x1E27540 VA: 0x181E28140
	|-SortedList.KeyList<long, object>.Remove
	|
	|-RVA: 0x1E281A0 Offset: 0x1E275A0 VA: 0x181E281A0
	|-SortedList.KeyList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
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
{	// Fields
	private SortedList<TKey, TValue> _dict; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1354950 Offset: 0x1353D50 VA: 0x181354950
	|-SortedList.ValueList<long, object>..ctor
	|-SortedList.ValueList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133F460 Offset: 0x133E860 VA: 0x18133F460
	|-SortedList.ValueList<long, object>.get_Count
	|-SortedList.ValueList<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	|-SortedList.ValueList<long, object>.get_IsReadOnly
	|-SortedList.ValueList<object, object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32A70 Offset: 0x1E31E70 VA: 0x181E32A70
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1E32A20 Offset: 0x1E31E20 VA: 0x181E32A20
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32380 Offset: 0x1E31780 VA: 0x181E32380
	|-SortedList.ValueList<long, object>.Add
	|
	|-RVA: 0x1E32320 Offset: 0x1E31720 VA: 0x181E32320
	|-SortedList.ValueList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E323E0 Offset: 0x1E317E0 VA: 0x181E323E0
	|-SortedList.ValueList<long, object>.Clear
	|
	|-RVA: 0x1E32440 Offset: 0x1E31840 VA: 0x181E32440
	|-SortedList.ValueList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2AF0 Offset: 0x15E1EF0 VA: 0x1815E2AF0
	|-SortedList.ValueList<long, object>.Contains
	|-SortedList.ValueList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E324A0 Offset: 0x1E318A0 VA: 0x181E324A0
	|-SortedList.ValueList<long, object>.CopyTo
	|-SortedList.ValueList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E327C0 Offset: 0x1E31BC0 VA: 0x181E327C0
	|-SortedList.ValueList<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1E328F0 Offset: 0x1E31CF0 VA: 0x181E328F0
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32580 Offset: 0x1E31980 VA: 0x181E32580
	|-SortedList.ValueList<long, object>.Insert
	|
	|-RVA: 0x1E325E0 Offset: 0x1E319E0 VA: 0x181E325E0
	|-SortedList.ValueList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E28500 Offset: 0x1E27900 VA: 0x181E28500
	|-SortedList.ValueList<long, object>.get_Item
	|-SortedList.ValueList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32AC0 Offset: 0x1E31EC0 VA: 0x181E32AC0
	|-SortedList.ValueList<long, object>.set_Item
	|
	|-RVA: 0x1E32B20 Offset: 0x1E31F20 VA: 0x181E32B20
	|-SortedList.ValueList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27DA0 Offset: 0x1E271A0 VA: 0x181E27DA0
	|-SortedList.ValueList<long, object>.GetEnumerator
	|-SortedList.ValueList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E27DA0 Offset: 0x1E271A0 VA: 0x181E27DA0
	|-SortedList.ValueList<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32510 Offset: 0x1E31910 VA: 0x181E32510
	|-SortedList.ValueList<long, object>.IndexOf
	|-SortedList.ValueList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32700 Offset: 0x1E31B00 VA: 0x181E32700
	|-SortedList.ValueList<long, object>.Remove
	|
	|-RVA: 0x1E32760 Offset: 0x1E31B60 VA: 0x181E32760
	|-SortedList.ValueList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
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

