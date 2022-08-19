public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 1384
{	// Fields
	private ArrayList list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	protected IList List { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x144CD80 Offset: 0x144C180 VA: 0x18144CD80
	protected void .ctor() { }

	// RVA: 0x144CE10 Offset: 0x144C210 VA: 0x18144CE10
	protected ArrayList get_InnerList() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	protected IList get_List() { }

	// RVA: 0x144CDF0 Offset: 0x144C1F0 VA: 0x18144CDF0 Slot: 16
	public int get_Count() { }

	// RVA: 0x144BEF0 Offset: 0x144B2F0 VA: 0x18144BEF0 Slot: 8
	public void Clear() { }

	// RVA: 0x144C0A0 Offset: 0x144B4A0 VA: 0x18144C0A0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x144CA50 Offset: 0x144BE50 VA: 0x18144CA50 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x144C9C0 Offset: 0x144BDC0 VA: 0x18144C9C0 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x144C300 Offset: 0x144B700 VA: 0x18144C300 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x144C250 Offset: 0x144B650 VA: 0x18144C250 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x144CAE0 Offset: 0x144BEE0 VA: 0x18144CAE0 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x144CBB0 Offset: 0x144BFB0 VA: 0x18144CBB0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x144C540 Offset: 0x144B940 VA: 0x18144C540 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x144C390 Offset: 0x144B790 VA: 0x18144C390 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x144C800 Offset: 0x144BC00 VA: 0x18144C800 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x144C5E0 Offset: 0x144B9E0 VA: 0x18144C5E0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x144C680 Offset: 0x144BA80 VA: 0x18144C680 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x144BFB0 Offset: 0x144B3B0 VA: 0x18144BFB0 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 19
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 21
	protected virtual void OnClear() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 22
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x144C040 Offset: 0x144B440 VA: 0x18144C040 Slot: 23
	protected virtual void OnValidate(object value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 24
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 25
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 26
	protected virtual void OnClearComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 27
	protected virtual void OnRemoveComplete(int index, object value) { }

}

