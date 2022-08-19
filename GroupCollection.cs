public class GroupCollection : ICollection, IEnumerable // TypeDefIndex: 2617
{	// Fields
	internal Match _match; // 0x10
	internal Hashtable _captureMap; // 0x18
	internal Group[] _groups; // 0x20

	// Properties
	public object SyncRoot { get; }
	public int Count { get; }
	public Group Item { get; }
	public Group Item { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14C25F0 Offset: 0x14C19F0 VA: 0x1814C25F0 Slot: 5
	public int get_Count() { }

	// RVA: 0x14C2620 Offset: 0x14C1A20 VA: 0x1814C2620
	public Group get_Item(int groupnum) { }

	// RVA: 0x14C2630 Offset: 0x14C1A30 VA: 0x1814C2630
	public Group get_Item(string groupname) { }

	// RVA: 0x14C2480 Offset: 0x14C1880 VA: 0x1814C2480
	internal Group GetGroup(int groupnum) { }

	// RVA: 0x14C2030 Offset: 0x14C1430 VA: 0x1814C2030
	internal Group GetGroupImpl(int groupnum) { }

	// RVA: 0x14C1EE0 Offset: 0x14C12E0 VA: 0x1814C1EE0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14C1FC0 Offset: 0x14C13C0 VA: 0x1814C1FC0 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14C25C0 Offset: 0x14C19C0 VA: 0x1814C25C0
	internal void .ctor() { }

}

