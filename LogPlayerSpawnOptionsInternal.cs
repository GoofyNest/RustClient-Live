internal struct LogPlayerSpawnOptionsInternal : ISettable<LogPlayerSpawnOptions>, IDisposable // TypeDefIndex: 9769
{
	private int m_ApiVersion; 
	private IntPtr m_SpawnedPlayerHandle; 
	private uint m_TeamId; 
	private uint m_CharacterId; 

	public IntPtr SpawnedPlayerHandle { set; }
	public uint TeamId { set; }
	public uint CharacterId { set; }


	public void set_SpawnedPlayerHandle(IntPtr value) { }

	public void set_TeamId(uint value) { }

	public void set_CharacterId(uint value) { }

	public void Set(ref LogPlayerSpawnOptions other) { }

	public void Set(ref Nullable<LogPlayerSpawnOptions> other) { }

	public void Dispose() { }

}

