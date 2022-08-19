public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1389
{	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor(bool trash) { }

	// RVA: 0x145CE80 Offset: 0x145C280 VA: 0x18145CE80
	public void .ctor() { }

	// RVA: 0x145CFF0 Offset: 0x145C3F0 VA: 0x18145CFF0
	public void .ctor(int capacity) { }

	// RVA: 0x145D000 Offset: 0x145C400 VA: 0x18145D000
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xE75A0 Offset: 0xE69A0 VA: 0x1800E75A0
	// RVA: 0x145D280 Offset: 0x145C680 VA: 0x18145D280
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x145CF30 Offset: 0x145C330 VA: 0x18145CF30
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xE7640 Offset: 0xE6A40 VA: 0x1800E7640
	// RVA: 0x145D350 Offset: 0x145C750 VA: 0x18145D350
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x145CF70 Offset: 0x145C370 VA: 0x18145CF70
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x145CFB0 Offset: 0x145C3B0 VA: 0x18145CFB0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x145CEA0 Offset: 0x145C2A0 VA: 0x18145CEA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x145BA40 Offset: 0x145AE40 VA: 0x18145BA40
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x145AAD0 Offset: 0x1459ED0 VA: 0x18145AAD0 Slot: 21
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x145AAF0 Offset: 0x1459EF0 VA: 0x18145AAF0 Slot: 22
	public virtual void Clear() { }

	// RVA: 0x145AC40 Offset: 0x145A040 VA: 0x18145AC40 Slot: 23
	public virtual object Clone() { }

	// RVA: 0x145AF10 Offset: 0x145A310 VA: 0x18145AF10 Slot: 24
	public virtual bool Contains(object key) { }

	// RVA: 0x145AD60 Offset: 0x145A160 VA: 0x18145AD60 Slot: 25
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x145B050 Offset: 0x145A450 VA: 0x18145B050
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x145AF30 Offset: 0x145A330 VA: 0x18145AF30
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x145B0F0 Offset: 0x145A4F0 VA: 0x18145B0F0 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x145B360 Offset: 0x145A760 VA: 0x18145B360
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x145D4F0 Offset: 0x145C8F0 VA: 0x18145D4F0 Slot: 27
	public virtual object get_Item(object key) { }

	// RVA: 0x145DBC0 Offset: 0x145CFC0 VA: 0x18145DBC0 Slot: 28
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x145D410 Offset: 0x145C810 VA: 0x18145D410
	private void expand() { }

	// RVA: 0x145D9E0 Offset: 0x145CDE0 VA: 0x18145D9E0
	private void rehash() { }

	// RVA: 0x145CE50 Offset: 0x145C250 VA: 0x18145CE50
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x145DA10 Offset: 0x145CE10 VA: 0x18145DA10
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x145CDC0 Offset: 0x145C1C0 VA: 0x18145CDC0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x145B400 Offset: 0x145A800 VA: 0x18145B400 Slot: 29
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x145B490 Offset: 0x145A890 VA: 0x18145B490 Slot: 30
	protected virtual int GetHash(object key) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 31
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x145C0F0 Offset: 0x145B4F0 VA: 0x18145C0F0 Slot: 32
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x145D710 Offset: 0x145CB10 VA: 0x18145D710 Slot: 33
	public virtual ICollection get_Keys() { }

	// RVA: 0x145D810 Offset: 0x145CC10 VA: 0x18145D810 Slot: 34
	public virtual ICollection get_Values() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x145BA90 Offset: 0x145AE90 VA: 0x18145BA90
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x145D8A0 Offset: 0x145CCA0 VA: 0x18145D8A0
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x145CA40 Offset: 0x145BE40 VA: 0x18145CA40 Slot: 35
	public virtual void Remove(object key) { }

	// RVA: 0x145D7A0 Offset: 0x145CBA0 VA: 0x18145D7A0 Slot: 36
	public virtual object get_SyncRoot() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200 Slot: 37
	public virtual int get_Count() { }

	// RVA: 0x145CD20 Offset: 0x145C120 VA: 0x18145CD20
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x145B510 Offset: 0x145A910 VA: 0x18145B510 Slot: 38
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x145C210 Offset: 0x145B610 VA: 0x18145C210 Slot: 39
	public virtual void OnDeserialization(object sender) { }

}

private struct Hashtable.bucket // TypeDefIndex: 1390
{	// Fields
	public object key; // 0x0
	public object val; // 0x8
	public int hash_coll; // 0x10

}

private class Hashtable.KeyCollection : ICollection, IEnumerable // TypeDefIndex: 1391
{	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x145F2D0 Offset: 0x145E6D0 VA: 0x18145F2D0 Slot: 8
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x145F4C0 Offset: 0x145E8C0 VA: 0x18145F4C0 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xBC4250 Offset: 0xBC3650 VA: 0x180BC4250 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0xA4F990 Offset: 0xA4ED90 VA: 0x180A4F990 Slot: 11
	public virtual int get_Count() { }

}

private class Hashtable.ValueCollection : ICollection, IEnumerable // TypeDefIndex: 1392
{	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x1468010 Offset: 0x1467410 VA: 0x181468010 Slot: 8
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1468210 Offset: 0x1467610 VA: 0x181468210 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xBC4250 Offset: 0xBC3650 VA: 0x180BC4250 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0xA4F990 Offset: 0xA4ED90 VA: 0x180A4F990 Slot: 11
	public virtual int get_Count() { }

}

private class Hashtable.SyncHashtable : Hashtable, IEnumerable // TypeDefIndex: 1393
{	// Fields
	protected Hashtable _table; // 0x50

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override ICollection Keys { get; }
	public override ICollection Values { get; }

	// Methods

	// RVA: 0x14667D0 Offset: 0x1465BD0 VA: 0x1814667D0
	internal void .ctor(Hashtable table) { }

	// RVA: 0x1466800 Offset: 0x1465C00 VA: 0x181466800
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1466560 Offset: 0x1465960 VA: 0x181466560 Slot: 38
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14669A0 Offset: 0x1465DA0 VA: 0x1814669A0 Slot: 37
	public override int get_Count() { }

	// RVA: 0x14669D0 Offset: 0x1465DD0 VA: 0x1814669D0 Slot: 31
	public override bool get_IsReadOnly() { }

	// RVA: 0x1466A00 Offset: 0x1465E00 VA: 0x181466A00 Slot: 27
	public override object get_Item(object key) { }

	// RVA: 0x1466C60 Offset: 0x1466060 VA: 0x181466C60 Slot: 28
	public override void set_Item(object key, object value) { }

	// RVA: 0x1466B30 Offset: 0x1465F30 VA: 0x181466B30 Slot: 36
	public override object get_SyncRoot() { }

	// RVA: 0x1465F80 Offset: 0x1465380 VA: 0x181465F80 Slot: 21
	public override void Add(object key, object value) { }

	// RVA: 0x1466080 Offset: 0x1465480 VA: 0x181466080 Slot: 22
	public override void Clear() { }

	// RVA: 0x1466400 Offset: 0x1465800 VA: 0x181466400 Slot: 24
	public override bool Contains(object key) { }

	// RVA: 0x1466350 Offset: 0x1465750 VA: 0x181466350 Slot: 25
	public override bool ContainsKey(object key) { }

	// RVA: 0x1466430 Offset: 0x1465830 VA: 0x181466430 Slot: 26
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1466160 Offset: 0x1465560 VA: 0x181466160 Slot: 23
	public override object Clone() { }

	// RVA: 0x1466530 Offset: 0x1465930 VA: 0x181466530 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1466530 Offset: 0x1465930 VA: 0x181466530 Slot: 29
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1466A30 Offset: 0x1465E30 VA: 0x181466A30 Slot: 33
	public override ICollection get_Keys() { }

	// RVA: 0x1466B60 Offset: 0x1465F60 VA: 0x181466B60 Slot: 34
	public override ICollection get_Values() { }

	// RVA: 0x14666E0 Offset: 0x1465AE0 VA: 0x1814666E0 Slot: 35
	public override void Remove(object key) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 39
	public override void OnDeserialization(object sender) { }

}

private class Hashtable.HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1394
{	// Fields
	private Hashtable hashtable; // 0x10
	private int bucket; // 0x18
	private int version; // 0x1C
	private bool current; // 0x20
	private int getObjectRetType; // 0x24
	private object currentKey; // 0x28
	private object currentValue; // 0x30

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x145A7B0 Offset: 0x1459BB0 VA: 0x18145A7B0
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 10
	public object Clone() { }

	// RVA: 0x145A9D0 Offset: 0x1459DD0 VA: 0x18145A9D0 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x145A560 Offset: 0x1459960 VA: 0x18145A560 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x145A920 Offset: 0x1459D20 VA: 0x18145A920 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x145A820 Offset: 0x1459C20 VA: 0x18145A820 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x145AA50 Offset: 0x1459E50 VA: 0x18145AA50 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x145A6D0 Offset: 0x1459AD0 VA: 0x18145A6D0 Slot: 16
	public virtual void Reset() { }

}

