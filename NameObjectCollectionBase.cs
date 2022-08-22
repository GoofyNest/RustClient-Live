public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 3102
{	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }


	protected void .ctor() { }

	protected void .ctor(IEqualityComparer equalityComparer) { }

	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	internal void .ctor(DBNull dummy) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual void OnDeserialization(object sender) { }

	private void Reset() { }

	private void Reset(int capacity) { }

	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	protected bool get_IsReadOnly() { }

	protected void BaseAdd(string name, object value) { }

	protected void BaseRemove(string name) { }

	protected object BaseGet(string name) { }

	protected void BaseSet(string name, object value) { }

	protected object BaseGet(int index) { }

	protected string BaseGetKey(int index) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual int get_Count() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private object System.Collections.ICollection.get_SyncRoot() { }

	protected string[] BaseGetAllKeys() { }

	private static void .cctor() { }

}

internal class NameObjectCollectionBase.NameObjectEntry // TypeDefIndex: 3103
{	internal string Key; // 0x10
	internal object Value; // 0x18


	internal void .ctor(string name, object value) { }

}

internal class NameObjectCollectionBase.NameObjectKeysEnumerator : IEnumerator // TypeDefIndex: 3104
{	private int _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private int _version; // 0x20

	public object Current { get; }


	internal void .ctor(NameObjectCollectionBase coll) { }

	public bool MoveNext() { }

	public void Reset() { }

	public object get_Current() { }

}

