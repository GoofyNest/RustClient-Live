internal struct IngestDataInternal : IGettable<IngestData>, ISettable<IngestData>, IDisposable // TypeDefIndex: 8424
{
	private int m_ApiVersion; 
	private IntPtr m_StatName; 
	private int m_IngestAmount; 

	public Utf8String StatName { get; set; }
	public int IngestAmount { get; set; }


	public Utf8String get_StatName() { }

	public void set_StatName(Utf8String value) { }

	public int get_IngestAmount() { }

	public void set_IngestAmount(int value) { }

	public void Set(ref IngestData other) { }

	public void Set(ref Nullable<IngestData> other) { }

	public void Dispose() { }

	public void Get(out IngestData output) { }

}

