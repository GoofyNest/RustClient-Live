public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 3106
{	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }
	public string Item { get; }
	public virtual string[] AllKeys { get; }

	// Methods

	// RVA: 0x15A8250 Offset: 0x15A7650 VA: 0x1815A8250
	public void .ctor() { }

	// RVA: 0x15A81D0 Offset: 0x15A75D0 VA: 0x1815A81D0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x15A8410 Offset: 0x15A7810 VA: 0x1815A8410
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x15A8160 Offset: 0x15A7560 VA: 0x1815A8160
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15A7F40 Offset: 0x15A7340 VA: 0x1815A7F40
	protected void InvalidateCachedArrays() { }

	// RVA: 0x15A79E0 Offset: 0x15A6DE0 VA: 0x1815A79E0
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x15A7BC0 Offset: 0x15A6FC0 VA: 0x1815A7BC0
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x15A7850 Offset: 0x15A6C50 VA: 0x1815A7850 Slot: 14
	public virtual void Add(string name, string value) { }

	// RVA: 0x15A7DE0 Offset: 0x15A71E0 VA: 0x1815A7DE0 Slot: 15
	public virtual string Get(string name) { }

	// RVA: 0x15A7D30 Offset: 0x15A7130 VA: 0x1815A7D30 Slot: 16
	public virtual string[] GetValues(string name) { }

	// RVA: 0x15A7FD0 Offset: 0x15A73D0 VA: 0x1815A7FD0 Slot: 17
	public virtual void Set(string name, string value) { }

	// RVA: 0x15A7F80 Offset: 0x15A7380 VA: 0x1815A7F80 Slot: 18
	public virtual void Remove(string name) { }

	// RVA: 0x15A85A0 Offset: 0x15A79A0 VA: 0x1815A85A0
	public string get_Item(string name) { }

	// RVA: 0x15A85C0 Offset: 0x15A79C0 VA: 0x1815A85C0
	public void set_Item(string name, string value) { }

	// RVA: 0x15A7E90 Offset: 0x15A7290 VA: 0x1815A7E90 Slot: 19
	public virtual string Get(int index) { }

	// RVA: 0x15A7C80 Offset: 0x15A7080 VA: 0x1815A7C80 Slot: 20
	public virtual string[] GetValues(int index) { }

	// RVA: 0x15A7C70 Offset: 0x15A7070 VA: 0x1815A7C70 Slot: 21
	public virtual string GetKey(int index) { }

	// RVA: 0x159F7A0 Offset: 0x159EBA0 VA: 0x18159F7A0
	public string get_Item(int index) { }

	// RVA: 0x15A8470 Offset: 0x15A7870 VA: 0x1815A8470 Slot: 22
	public virtual string[] get_AllKeys() { }

}

