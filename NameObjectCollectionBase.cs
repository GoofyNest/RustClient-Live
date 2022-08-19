public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 3102
{	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x15A7460 Offset: 0x15A6860 VA: 0x1815A7460
	protected void .ctor() { }

	// RVA: 0x15A7320 Offset: 0x15A6720 VA: 0x1815A7320
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x15A72E0 Offset: 0x15A66E0 VA: 0x1815A72E0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x15A72B0 Offset: 0x15A66B0 VA: 0x1815A72B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15A5F60 Offset: 0x15A5360 VA: 0x1815A5F60 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15A6620 Offset: 0x15A5A20 VA: 0x1815A6620 Slot: 11
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x15A6D10 Offset: 0x15A6110 VA: 0x1815A6D10
	private void Reset() { }

	// RVA: 0x15A6DD0 Offset: 0x15A61D0 VA: 0x1815A6DD0
	private void Reset(int capacity) { }

	// RVA: 0x15A5E00 Offset: 0x15A5200 VA: 0x1815A5E00
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	protected bool get_IsReadOnly() { }

	// RVA: 0x15A5660 Offset: 0x15A4A60 VA: 0x1815A5660
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x15A5AF0 Offset: 0x15A4EF0 VA: 0x1815A5AF0
	protected void BaseRemove(string name) { }

	// RVA: 0x15A59E0 Offset: 0x15A4DE0 VA: 0x1815A59E0
	protected object BaseGet(string name) { }

	// RVA: 0x15A5D30 Offset: 0x15A5130 VA: 0x1815A5D30
	protected void BaseSet(string name, object value) { }

	// RVA: 0x15A5A00 Offset: 0x15A4E00 VA: 0x1815A5A00
	protected object BaseGet(int index) { }

	// RVA: 0x15A58F0 Offset: 0x15A4CF0 VA: 0x1815A58F0
	protected string BaseGetKey(int index) { }

	// RVA: 0x15A5ED0 Offset: 0x15A52D0 VA: 0x1815A5ED0 Slot: 12
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x154E6F0 Offset: 0x154DAF0 VA: 0x18154E6F0 Slot: 13
	public virtual int get_Count() { }

	// RVA: 0x15A6EA0 Offset: 0x15A62A0 VA: 0x1815A6EA0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x15A7190 Offset: 0x15A6590 VA: 0x1815A7190 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15A57E0 Offset: 0x15A4BE0 VA: 0x1815A57E0
	protected string[] BaseGetAllKeys() { }

	// RVA: 0x15A7200 Offset: 0x15A6600 VA: 0x1815A7200
	private static void .cctor() { }

}

internal class NameObjectCollectionBase.NameObjectEntry // TypeDefIndex: 3103
{	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(string name, object value) { }

}

internal class NameObjectCollectionBase.NameObjectKeysEnumerator : IEnumerator // TypeDefIndex: 3104
{	// Fields
	private int _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private int _version; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x15A7740 Offset: 0x15A6B40 VA: 0x1815A7740
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x15A75E0 Offset: 0x15A69E0 VA: 0x1815A75E0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x15A76B0 Offset: 0x15A6AB0 VA: 0x1815A76B0 Slot: 6
	public void Reset() { }

	// RVA: 0x15A77A0 Offset: 0x15A6BA0 VA: 0x1815A77A0 Slot: 5
	public object get_Current() { }

}

