public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 4167
{	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x12730

	// Properties
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public virtual int Count { get; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0xE9FD00 Offset: 0xE9F100 VA: 0x180E9FD00 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0xE9FB20 Offset: 0xE9EF20 VA: 0x180E9FB20 Slot: 9
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0xE9FB70 Offset: 0xE9EF70 VA: 0x180E9FB70 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xE9FBB0 Offset: 0xE9EFB0 VA: 0x180E9FBB0
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 11
	protected virtual ArrayList get_List() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE9FCA0 Offset: 0xE9F0A0 VA: 0x180E9FCA0
	private static void .cctor() { }

}

