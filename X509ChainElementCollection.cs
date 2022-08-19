public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 2824
{	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x14D5600 Offset: 0x14D4A00 VA: 0x1814D5600
	internal void .ctor() { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 5
	public int get_Count() { }

	// RVA: 0x14D5670 Offset: 0x14D4A70 VA: 0x1814D5670
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x1343750 Offset: 0x1342B50 VA: 0x181343750 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14D5530 Offset: 0x14D4930 VA: 0x1814D5530 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14D5490 Offset: 0x14D4890 VA: 0x1814D5490
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x14D5560 Offset: 0x14D4960 VA: 0x1814D5560 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14D5270 Offset: 0x14D4670 VA: 0x1814D5270
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0xBC3A50 Offset: 0xBC2E50 VA: 0x180BC3A50
	internal void Clear() { }

	// RVA: 0x14D5340 Offset: 0x14D4740 VA: 0x1814D5340
	internal bool Contains(X509Certificate2 certificate) { }

}

