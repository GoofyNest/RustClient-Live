internal struct LobbyModificationSetPermissionLevelOptionsInternal : ISettable<LobbyModificationSetPermissionLevelOptions>, IDisposable // TypeDefIndex: 9181
{
	private int m_ApiVersion; 
	private LobbyPermissionLevel m_PermissionLevel; 

	public LobbyPermissionLevel PermissionLevel { set; }


	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	public void Set(ref LobbyModificationSetPermissionLevelOptions other) { }

	public void Set(ref Nullable<LobbyModificationSetPermissionLevelOptions> other) { }

	public void Dispose() { }

}

