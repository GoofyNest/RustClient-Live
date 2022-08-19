public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 2940
{	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x154E650 Offset: 0x154DA50 VA: 0x18154E650
	public void .ctor() { }

	// RVA: 0x154E720 Offset: 0x154DB20 VA: 0x18154E720
	public Cookie get_Item(int index) { }

	// RVA: 0x154DE10 Offset: 0x154D210 VA: 0x18154DE10
	public void Add(Cookie cookie) { }

	// RVA: 0x154DB10 Offset: 0x154CF10 VA: 0x18154DB10
	public void Add(CookieCollection cookies) { }

	// RVA: 0x154E6F0 Offset: 0x154DAF0 VA: 0x18154E6F0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x154DEE0 Offset: 0x154D2E0 VA: 0x18154DEE0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x154E540 Offset: 0x154D940 VA: 0x18154E540
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x154E1E0 Offset: 0x154D5E0 VA: 0x18154E1E0
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x154DFB0 Offset: 0x154D3B0 VA: 0x18154DFB0
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x154E510 Offset: 0x154D910 VA: 0x18154E510
	internal void RemoveAt(int idx) { }

	// RVA: 0x154DF10 Offset: 0x154D310 VA: 0x18154DF10 Slot: 7
	public IEnumerator GetEnumerator() { }

}

internal enum CookieCollection.Stamp // TypeDefIndex: 2941
{	// Fields
	public int value__; // 0x0
	public const CookieCollection.Stamp Check = 0;
	public const CookieCollection.Stamp Set = 1;
	public const CookieCollection.Stamp SetToUnused = 2;
	public const CookieCollection.Stamp SetToMaxUsed = 3;

}

private class CookieCollection.CookieCollectionEnumerator : IEnumerator // TypeDefIndex: 2942
{	// Fields
	private CookieCollection m_cookies; // 0x10
	private int m_count; // 0x18
	private int m_index; // 0x1C
	private int m_version; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x154DAA0 Offset: 0x154CEA0 VA: 0x18154DAA0
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x154D9C0 Offset: 0x154CDC0 VA: 0x18154D9C0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x154D900 Offset: 0x154CD00 VA: 0x18154D900 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x154D9B0 Offset: 0x154CDB0 VA: 0x18154D9B0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

}

