internal struct LogGameRoundEndOptionsInternal : ISettable<LogGameRoundEndOptions>, IDisposable // TypeDefIndex: 9726
{
	private int m_ApiVersion; 
	private uint m_WinningTeamId; 

	public uint WinningTeamId { set; }


	public void set_WinningTeamId(uint value) { }

	public void Set(ref LogGameRoundEndOptions other) { }

	public void Set(ref Nullable<LogGameRoundEndOptions> other) { }

	public void Dispose() { }

}

