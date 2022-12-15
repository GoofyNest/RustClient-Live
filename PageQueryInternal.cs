internal struct PageQueryInternal : IGettable<PageQuery>, ISettable<PageQuery>, IDisposable // TypeDefIndex: 8294
{
	private int m_ApiVersion;
	private int m_StartIndex;
	private int m_MaxCount;

	public int StartIndex { get; set; }
	public int MaxCount { get; set; }


	public int get_StartIndex() { }

	public void set_StartIndex(int value) { }

	public int get_MaxCount() { }

	public void set_MaxCount(int value) { }

	public void Set(ref PageQuery other) { }

	public void Set(ref Nullable<PageQuery> other) { }

	public void Dispose() { }

	public void Get(out PageQuery output) { }

}

