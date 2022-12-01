public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 3102
{
	private bool _readOnly;
	private ArrayList _entriesArray;
	private IEqualityComparer _keyComparer;
	private Hashtable _entriesTable;
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry;
	private SerializationInfo _serializationInfo;
	private int _version;
	private object _syncRoot;
	private static StringComparer defaultComparer;

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
{
	internal string Key;
	internal object Value;


	internal void .ctor(string name, object value) { }

}

internal class NameObjectCollectionBase.NameObjectKeysEnumerator : IEnumerator // TypeDefIndex: 3104
{
	private int _pos;
	private NameObjectCollectionBase _coll;
	private int _version;

	public object Current { get; }


	internal void .ctor(NameObjectCollectionBase coll) { }

	public bool MoveNext() { }

	public void Reset() { }

	public object get_Current() { }

}

