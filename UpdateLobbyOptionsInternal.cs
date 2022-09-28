internal struct UpdateLobbyOptionsInternal : ISettable<UpdateLobbyOptions>, IDisposable // TypeDefIndex: 9231
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyModificationHandle; 

	public LobbyModification LobbyModificationHandle { set; }


	public void set_LobbyModificationHandle(LobbyModification value) { }

	public void Set(ref UpdateLobbyOptions other) { }

	public void Set(ref Nullable<UpdateLobbyOptions> other) { }

	public void Dispose() { }

}

