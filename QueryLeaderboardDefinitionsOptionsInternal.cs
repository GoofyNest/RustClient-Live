internal struct QueryLeaderboardDefinitionsOptionsInternal : ISettable<QueryLeaderboardDefinitionsOptions>, IDisposable // TypeDefIndex: 9306
{
	private int m_ApiVersion; 
	private long m_StartTime; 
	private long m_EndTime; 
	private IntPtr m_LocalUserId; 

	public Nullable<DateTimeOffset> StartTime { set; }
	public Nullable<DateTimeOffset> EndTime { set; }
	public ProductUserId LocalUserId { set; }


	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref QueryLeaderboardDefinitionsOptions other) { }

	public void Set(ref Nullable<QueryLeaderboardDefinitionsOptions> other) { }

	public void Dispose() { }

}

