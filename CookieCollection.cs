public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 2940
{
	internal int m_version; 
	private ArrayList m_list; 
	private DateTime m_TimeStamp; 
	private bool m_has_other_versions; 
	[OptionalFieldAttribute] 
	private bool m_IsReadOnly; 

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
{
	public int value__; 
	public const CookieCollection.Stamp Check = 0;
	public const CookieCollection.Stamp Set = 1;
	public const CookieCollection.Stamp SetToUnused = 2;
	public const CookieCollection.Stamp SetToMaxUsed = 3;

}

private class CookieCollection.CookieCollectionEnumerator : IEnumerator // TypeDefIndex: 2942
{
	private CookieCollection m_cookies; 
	private int m_count; 
	private int m_index; 
	private int m_version; 

	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(CookieCollection cookies) { }

	private object System.Collections.IEnumerator.get_Current() { }

	private bool System.Collections.IEnumerator.MoveNext() { }

	private void System.Collections.IEnumerator.Reset() { }

}

