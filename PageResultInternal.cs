internal struct PageResultInternal : IGettable<PageResult>, ISettable<PageResult>, IDisposable // TypeDefIndex: 8294
{
	private int m_StartIndex;
	private int m_Count;
	private int m_TotalCount;

	public int StartIndex { get; set; }
	public int Count { get; set; }
	public int TotalCount { get; set; }


	public int get_StartIndex() { }

	public void set_StartIndex(int value) { }

	public int get_Count() { }

	public void set_Count(int value) { }

	public int get_TotalCount() { }

	public void set_TotalCount(int value) { }

	public void Set(ref PageResult other) { }

	public void Set(ref Nullable<PageResult> other) { }

	public void Dispose() { }

	public void Get(out PageResult output) { }

}

