internal class LongList // TypeDefIndex: 1041
{	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	internal int Count { get; }
	internal long Current { get; }


	internal void .ctor() { }

	internal void .ctor(int startingSize) { }

	internal void Add(long value) { }

	internal int get_Count() { }

	internal void StartEnumeration() { }

	internal bool MoveNext() { }

	internal long get_Current() { }

	internal bool RemoveElement(long value) { }

	private void EnlargeArray() { }

}

