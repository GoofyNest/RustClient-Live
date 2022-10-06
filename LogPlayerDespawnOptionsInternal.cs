internal struct LogPlayerDespawnOptionsInternal : ISettable<LogPlayerDespawnOptions>, IDisposable // TypeDefIndex: 9764
{
	private int m_ApiVersion; 
	private IntPtr m_DespawnedPlayerHandle; 

	public IntPtr DespawnedPlayerHandle { set; }


	public void set_DespawnedPlayerHandle(IntPtr value) { }

	public void Set(ref LogPlayerDespawnOptions other) { }

	public void Set(ref Nullable<LogPlayerDespawnOptions> other) { }

	public void Dispose() { }

}

