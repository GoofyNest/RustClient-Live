internal struct QueryLeaderboardRanksOptionsInternal : ISettable<QueryLeaderboardRanksOptions>, IDisposable // TypeDefIndex: 9273
{
	private int m_ApiVersion; 
	private IntPtr m_LeaderboardId; 
	private IntPtr m_LocalUserId; 

	public Utf8String LeaderboardId { set; }
	public ProductUserId LocalUserId { set; }


	public void set_LeaderboardId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref QueryLeaderboardRanksOptions other) { }

	public void Set(ref Nullable<QueryLeaderboardRanksOptions> other) { }

	public void Dispose() { }

}

