internal struct UserScoresQueryStatInfoInternal : IGettable<UserScoresQueryStatInfo>, ISettable<UserScoresQueryStatInfo>, IDisposable // TypeDefIndex: 9277
{
	private int m_ApiVersion; 
	private IntPtr m_StatName; 
	private LeaderboardAggregation m_Aggregation; 

	public Utf8String StatName { get; set; }
	public LeaderboardAggregation Aggregation { get; set; }


	public Utf8String get_StatName() { }

	public void set_StatName(Utf8String value) { }

	public LeaderboardAggregation get_Aggregation() { }

	public void set_Aggregation(LeaderboardAggregation value) { }

	public void Set(ref UserScoresQueryStatInfo other) { }

	public void Set(ref Nullable<UserScoresQueryStatInfo> other) { }

	public void Dispose() { }

	public void Get(out UserScoresQueryStatInfo output) { }

}

