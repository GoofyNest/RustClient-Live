internal struct CopyLeaderboardUserScoreByUserIdOptionsInternal : ISettable<CopyLeaderboardUserScoreByUserIdOptions>, IDisposable // TypeDefIndex: 9243
{
	private int m_ApiVersion; 
	private IntPtr m_UserId; 
	private IntPtr m_StatName; 

	public ProductUserId UserId { set; }
	public Utf8String StatName { set; }


	public void set_UserId(ProductUserId value) { }

	public void set_StatName(Utf8String value) { }

	public void Set(ref CopyLeaderboardUserScoreByUserIdOptions other) { }

	public void Set(ref Nullable<CopyLeaderboardUserScoreByUserIdOptions> other) { }

	public void Dispose() { }

}

