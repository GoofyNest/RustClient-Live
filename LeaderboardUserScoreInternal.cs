internal struct LeaderboardUserScoreInternal : IGettable<LeaderboardUserScore>, ISettable<LeaderboardUserScore>, IDisposable // TypeDefIndex: 9304
{
	private int m_ApiVersion;
	private IntPtr m_UserId;
	private int m_Score;

	public ProductUserId UserId { get; set; }
	public int Score { get; set; }


	public ProductUserId get_UserId() { }

	public void set_UserId(ProductUserId value) { }

	public int get_Score() { }

	public void set_Score(int value) { }

	public void Set(ref LeaderboardUserScore other) { }

	public void Set(ref Nullable<LeaderboardUserScore> other) { }

	public void Dispose() { }

	public void Get(out LeaderboardUserScore output) { }

}

