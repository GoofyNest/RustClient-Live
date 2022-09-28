internal struct JoinLobbyOptionsInternal : ISettable<JoinLobbyOptions>, IDisposable // TypeDefIndex: 9076
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyDetailsHandle; 
	private IntPtr m_LocalUserId; 
	private int m_PresenceEnabled; 
	private IntPtr m_LocalRTCOptions; 

	public LobbyDetails LobbyDetailsHandle { set; }
	public ProductUserId LocalUserId { set; }
	public bool PresenceEnabled { set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { set; }


	public void set_LobbyDetailsHandle(LobbyDetails value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_PresenceEnabled(bool value) { }

	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	public void Set(ref JoinLobbyOptions other) { }

	public void Set(ref Nullable<JoinLobbyOptions> other) { }

	public void Dispose() { }

}

