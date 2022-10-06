internal struct IngestStatOptionsInternal : ISettable<IngestStatOptions>, IDisposable // TypeDefIndex: 8427
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Stats; 
	private uint m_StatsCount; 
	private IntPtr m_TargetUserId; 

	public ProductUserId LocalUserId { set; }
	public IngestData[] Stats { set; }
	public ProductUserId TargetUserId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Stats(IngestData[] value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref IngestStatOptions other) { }

	public void Set(ref Nullable<IngestStatOptions> other) { }

	public void Dispose() { }

}

