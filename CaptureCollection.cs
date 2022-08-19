public class CaptureCollection : ICollection, IEnumerable // TypeDefIndex: 2606
{	// Fields
	internal Group _group; // 0x10
	internal int _capcount; // 0x18
	internal Capture[] _captures; // 0x20

	// Properties
	public object SyncRoot { get; }
	public int Count { get; }
	public Capture Item { get; }

	// Methods

	// RVA: 0x14C1AA0 Offset: 0x14C0EA0 VA: 0x1814C1AA0
	internal void .ctor(Group group) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200 Slot: 5
	public int get_Count() { }

	// RVA: 0x14C1B30 Offset: 0x14C0F30 VA: 0x1814C1B30
	public Capture get_Item(int i) { }

	// RVA: 0x14C1720 Offset: 0x14C0B20 VA: 0x1814C1720 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14C1A30 Offset: 0x14C0E30 VA: 0x1814C1A30 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14C17E0 Offset: 0x14C0BE0 VA: 0x1814C17E0
	internal Capture GetCapture(int i) { }

	// RVA: 0x14C1B00 Offset: 0x14C0F00 VA: 0x1814C1B00
	internal void .ctor() { }

}

