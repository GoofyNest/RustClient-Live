internal struct QueryLeaderboardUserScoresOptionsInternal : ISettable<QueryLeaderboardUserScoresOptions>, IDisposable // TypeDefIndex: 9275
{
	private int m_ApiVersion; 
	private IntPtr m_UserIds; 
	private uint m_UserIdsCount; 
	private IntPtr m_StatInfo; 
	private uint m_StatInfoCount; 
	private long m_StartTime; 
	private long m_EndTime; 
	private IntPtr m_LocalUserId; 

	public ProductUserId[] UserIds { set; }
	public UserScoresQueryStatInfo[] StatInfo { set; }
	public Nullable<DateTimeOffset> StartTime { set; }
	public Nullable<DateTimeOffset> EndTime { set; }
	public ProductUserId LocalUserId { set; }


	public void set_UserIds(ProductUserId[] value) { }

	public void set_StatInfo(UserScoresQueryStatInfo[] value) { }

	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref QueryLeaderboardUserScoresOptions other) { }

	public void Set(ref Nullable<QueryLeaderboardUserScoresOptions> other) { }

	public void Dispose() { }

}

