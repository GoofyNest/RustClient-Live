public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
{
// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1416
	// Fields
	private ArrayList list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x14632B0 Offset: 0x14626B0 VA: 0x1814632B0
	protected ArrayList get_InnerList() { }

	// RVA: 0x1463220 Offset: 0x1462620 VA: 0x181463220 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0x1463190 Offset: 0x1462590 VA: 0x181463190 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x14630E0 Offset: 0x14624E0 VA: 0x1814630E0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1463050 Offset: 0x1462450 VA: 0x181463050 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

