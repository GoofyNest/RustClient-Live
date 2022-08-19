public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 3110
{	// Fields
	private ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x15B1D70 Offset: 0x15B1170 VA: 0x1815B1D70
	public string get_Item(int index) { }

	// RVA: 0x15B1EF0 Offset: 0x15B12F0 VA: 0x1815B1EF0
	public void set_Item(int index, string value) { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 16
	public int get_Count() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1176A00 Offset: 0x1175E00 VA: 0x181176A00
	public int Add(string value) { }

	// RVA: 0xBC3A50 Offset: 0xBC2E50 VA: 0x180BC3A50 Slot: 8
	public void Clear() { }

	// RVA: 0x1468390 Offset: 0x1467790 VA: 0x181468390
	public bool Contains(string value) { }

	// RVA: 0x14D5530 Offset: 0x14D4930 VA: 0x1814D5530
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x15B1A20 Offset: 0x15B0E20 VA: 0x1815B1A20
	public int IndexOf(string value) { }

	// RVA: 0x15B1A50 Offset: 0x15B0E50 VA: 0x1815B1A50
	public void Insert(int index, string value) { }

	// RVA: 0x15B1AB0 Offset: 0x15B0EB0 VA: 0x1815B1AB0
	public void Remove(string value) { }

	// RVA: 0x15B1A80 Offset: 0x15B0E80 VA: 0x1815B1A80 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1343750 Offset: 0x1342B50 VA: 0x181343750 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x15B1D70 Offset: 0x15B1170 VA: 0x1815B1D70 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15B1DF0 Offset: 0x15B11F0 VA: 0x1815B1DF0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15B1AE0 Offset: 0x15B0EE0 VA: 0x1815B1AE0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15B1B60 Offset: 0x15B0F60 VA: 0x1815B1B60 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15B1BE0 Offset: 0x15B0FE0 VA: 0x1815B1BE0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15B1C60 Offset: 0x15B1060 VA: 0x1815B1C60 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x15B1CF0 Offset: 0x15B10F0 VA: 0x1815B1CF0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x14D5530 Offset: 0x14D4930 VA: 0x1814D5530 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xBC3BA0 Offset: 0xBC2FA0 VA: 0x180BC3BA0 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15B1E80 Offset: 0x15B1280 VA: 0x1815B1E80
	public void .ctor() { }

}

