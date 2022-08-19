public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 2793
{	// Fields
	private ArrayList m_list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1176D00 Offset: 0x1176100 VA: 0x181176D00
	public void .ctor() { }

	// RVA: 0x1176A00 Offset: 0x1175E00 VA: 0x181176A00
	public int Add(Oid oid) { }

	// RVA: 0x1176D70 Offset: 0x1176170 VA: 0x181176D70
	public Oid get_Item(int index) { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 5
	public int get_Count() { }

	// RVA: 0x1176C90 Offset: 0x1176090 VA: 0x181176C90 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1176A30 Offset: 0x1175E30 VA: 0x181176A30 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 6
	public object get_SyncRoot() { }

}

