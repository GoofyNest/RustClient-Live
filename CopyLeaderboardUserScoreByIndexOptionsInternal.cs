internal struct CopyLeaderboardUserScoreByIndexOptionsInternal : ISettable<CopyLeaderboardUserScoreByIndexOptions>, IDisposable // TypeDefIndex: 9285
{
	private int m_ApiVersion; 
	private uint m_LeaderboardUserScoreIndex; 
	private IntPtr m_StatName; 

	public uint LeaderboardUserScoreIndex { set; }
	public Utf8String StatName { set; }


	public void set_LeaderboardUserScoreIndex(uint value) { }

	public void set_StatName(Utf8String value) { }

	public void Set(ref CopyLeaderboardUserScoreByIndexOptions other) { }

	public void Set(ref Nullable<CopyLeaderboardUserScoreByIndexOptions> other) { }

	public void Dispose() { }

}

