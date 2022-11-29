internal struct SessionModificationSetMaxPlayersOptionsInternal : ISettable<SessionModificationSetMaxPlayersOptions>, IDisposable // TypeDefIndex: 8580
{
	private int m_ApiVersion; 
	private uint m_MaxPlayers; 

	public uint MaxPlayers { set; }


	public void set_MaxPlayers(uint value) { }

	public void Set(ref SessionModificationSetMaxPlayersOptions other) { }

	public void Set(ref Nullable<SessionModificationSetMaxPlayersOptions> other) { }

	public void Dispose() { }

}

