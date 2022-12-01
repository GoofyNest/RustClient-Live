internal class LongList // TypeDefIndex: 1041
{
	private long[] m_values;
	private int m_count;
	private int m_totalItems;
	private int m_currentItem;

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

