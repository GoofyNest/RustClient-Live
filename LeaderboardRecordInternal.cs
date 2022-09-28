internal struct LeaderboardRecordInternal : IGettable<LeaderboardRecord>, ISettable<LeaderboardRecord>, IDisposable // TypeDefIndex: 9254
{
	private int m_ApiVersion; 
	private IntPtr m_UserId; 
	private uint m_Rank; 
	private int m_Score; 
	private IntPtr m_UserDisplayName; 

	public ProductUserId UserId { get; set; }
	public uint Rank { get; set; }
	public int Score { get; set; }
	public Utf8String UserDisplayName { get; set; }


	public ProductUserId get_UserId() { }

	public void set_UserId(ProductUserId value) { }

	public uint get_Rank() { }

	public void set_Rank(uint value) { }

	public int get_Score() { }

	public void set_Score(int value) { }

	public Utf8String get_UserDisplayName() { }

	public void set_UserDisplayName(Utf8String value) { }

	public void Set(ref LeaderboardRecord other) { }

	public void Set(ref Nullable<LeaderboardRecord> other) { }

	public void Dispose() { }

	public void Get(out LeaderboardRecord output) { }

}

