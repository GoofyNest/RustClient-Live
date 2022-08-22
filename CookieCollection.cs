public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 2940
{	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private bool m_IsReadOnly; // 0x29

	public Cookie Item { get; }
	public int Count { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }


	public void .ctor() { }

	public Cookie get_Item(int index) { }

	public void Add(Cookie cookie) { }

	public void Add(CookieCollection cookies) { }

	public int get_Count() { }

	public object get_SyncRoot() { }

	public void CopyTo(Array array, int index) { }

	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	internal bool get_IsOtherVersionSeen() { }

	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	internal int IndexOf(Cookie cookie) { }

	internal void RemoveAt(int idx) { }

	public IEnumerator GetEnumerator() { }

}

internal enum CookieCollection.Stamp // TypeDefIndex: 2941
{	public int value__; // 0x0
	public const CookieCollection.Stamp Check = 0;
	public const CookieCollection.Stamp Set = 1;
	public const CookieCollection.Stamp SetToUnused = 2;
	public const CookieCollection.Stamp SetToMaxUsed = 3;

}

private class CookieCollection.CookieCollectionEnumerator : IEnumerator // TypeDefIndex: 2942
{	private CookieCollection m_cookies; // 0x10
	private int m_count; // 0x18
	private int m_index; // 0x1C
	private int m_version; // 0x20

	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(CookieCollection cookies) { }

	private object System.Collections.IEnumerator.get_Current() { }

	private bool System.Collections.IEnumerator.MoveNext() { }

	private void System.Collections.IEnumerator.Reset() { }

}

