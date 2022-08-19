public class TraceListenerCollection : IList, ICollection, IEnumerable // TypeDefIndex: 2644
{	// Fields
	private ArrayList list; // 0x10

	// Properties
	public int Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x17325D0 Offset: 0x17319D0 VA: 0x1817325D0
	internal void .ctor() { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 16
	public int get_Count() { }

	// RVA: 0x17317E0 Offset: 0x1730BE0 VA: 0x1817317E0
	public int Add(TraceListener listener) { }

	// RVA: 0x1731920 Offset: 0x1730D20 VA: 0x181731920 Slot: 8
	public void Clear() { }

	// RVA: 0xBC3BA0 Offset: 0xBC2FA0 VA: 0x180BC3BA0 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1731980 Offset: 0x1730D80 VA: 0x181731980
	internal void InitializeListener(TraceListener listener) { }

	// RVA: 0x1731AD0 Offset: 0x1730ED0 VA: 0x181731AD0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0xBC3A20 Offset: 0xBC2E20 VA: 0x180BC3A20 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x17323D0 Offset: 0x17317D0 VA: 0x1817323D0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1731D30 Offset: 0x1731130 VA: 0x181731D30 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1468390 Offset: 0x1467790 VA: 0x181468390 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15B1A20 Offset: 0x15B0E20 VA: 0x1815B1A20 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1731FF0 Offset: 0x17313F0 VA: 0x181731FF0 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x17322A0 Offset: 0x17316A0 VA: 0x1817322A0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1731C00 Offset: 0x1731000 VA: 0x181731C00 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

}

