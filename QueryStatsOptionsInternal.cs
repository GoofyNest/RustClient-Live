internal struct QueryStatsOptionsInternal : ISettable<QueryStatsOptions>, IDisposable // TypeDefIndex: 8447
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private long m_StartTime;
	private long m_EndTime;
	private IntPtr m_StatNames;
	private uint m_StatNamesCount;
	private IntPtr m_TargetUserId;

	public ProductUserId LocalUserId { set; }
	public Nullable<DateTimeOffset> StartTime { set; }
	public Nullable<DateTimeOffset> EndTime { set; }
	public Utf8String[] StatNames { set; }
	public ProductUserId TargetUserId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	public void set_StatNames(Utf8String[] value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref QueryStatsOptions other) { }

	public void Set(ref Nullable<QueryStatsOptions> other) { }

	public void Dispose() { }

}

