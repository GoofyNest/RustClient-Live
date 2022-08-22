public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1389
{	internal const int HashPrime = 101;
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

	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }


	internal void .ctor(bool trash) { }

	public void .ctor() { }

	public void .ctor(int capacity) { }

	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xE75A0 Offset: 0xE69A0 VA: 0x1800E75A0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xE7640 Offset: 0xE6A40 VA: 0x1800E7640
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	public void .ctor(IEqualityComparer equalityComparer) { }

	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public virtual void Clear() { }

	public virtual object Clone() { }

	public virtual bool Contains(object key) { }

	public virtual bool ContainsKey(object key) { }

	private void CopyKeys(Array array, int arrayIndex) { }

	private void CopyEntries(Array array, int arrayIndex) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	private void CopyValues(Array array, int arrayIndex) { }

	public virtual object get_Item(object key) { }

	public virtual void set_Item(object key, object value) { }

	private void expand() { }

	private void rehash() { }

	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	private void rehash(int newsize, bool forceNewHashCode) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual IDictionaryEnumerator GetEnumerator() { }

	protected virtual int GetHash(object key) { }

	public virtual bool get_IsReadOnly() { }

	protected virtual bool KeyEquals(object item, object key) { }

	public virtual ICollection get_Keys() { }

	public virtual ICollection get_Values() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	private void Insert(object key, object nvalue, bool add) { }

	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public virtual void Remove(object key) { }

	public virtual object get_SyncRoot() { }

	public virtual int get_Count() { }

	public static Hashtable Synchronized(Hashtable table) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual void OnDeserialization(object sender) { }

}

private struct Hashtable.bucket // TypeDefIndex: 1390
{	public object key; // 0x0
	public object val; // 0x8
	public int hash_coll; // 0x10

}

private class Hashtable.KeyCollection : ICollection, IEnumerable // TypeDefIndex: 1391
{	private Hashtable _hashtable; // 0x10

	public virtual object SyncRoot { get; }
	public virtual int Count { get; }


	internal void .ctor(Hashtable hashtable) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual object get_SyncRoot() { }

	public virtual int get_Count() { }

}

private class Hashtable.ValueCollection : ICollection, IEnumerable // TypeDefIndex: 1392
{	private Hashtable _hashtable; // 0x10

	public virtual object SyncRoot { get; }
	public virtual int Count { get; }


	internal void .ctor(Hashtable hashtable) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual object get_SyncRoot() { }

	public virtual int get_Count() { }

}

private class Hashtable.SyncHashtable : Hashtable, IEnumerable // TypeDefIndex: 1393
{	protected Hashtable _table; // 0x50

	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override ICollection Keys { get; }
	public override ICollection Values { get; }


	internal void .ctor(Hashtable table) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override object get_Item(object key) { }

	public override void set_Item(object key, object value) { }

	public override object get_SyncRoot() { }

	public override void Add(object key, object value) { }

	public override void Clear() { }

	public override bool Contains(object key) { }

	public override bool ContainsKey(object key) { }

	public override void CopyTo(Array array, int arrayIndex) { }

	public override object Clone() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public override ICollection get_Keys() { }

	public override ICollection get_Values() { }

	public override void Remove(object key) { }

	public override void OnDeserialization(object sender) { }

}

private class Hashtable.HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1394
{	private Hashtable hashtable; // 0x10
	private int bucket; // 0x18
	private int version; // 0x1C
	private bool current; // 0x20
	private int getObjectRetType; // 0x24
	private object currentKey; // 0x28
	private object currentValue; // 0x30

	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }


	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	public object Clone() { }

	public virtual object get_Key() { }

	public virtual bool MoveNext() { }

	public virtual DictionaryEntry get_Entry() { }

	public virtual object get_Current() { }

	public virtual object get_Value() { }

	public virtual void Reset() { }

}

