internal struct JoinLobbyByIdOptionsInternal : ISettable<JoinLobbyByIdOptions>, IDisposable // TypeDefIndex: 9116
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyId; 
	private IntPtr m_LocalUserId; 
	private int m_PresenceEnabled; 
	private IntPtr m_LocalRTCOptions; 

	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public bool PresenceEnabled { set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { set; }


	public void set_LobbyId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_PresenceEnabled(bool value) { }

	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	public void Set(ref JoinLobbyByIdOptions other) { }

	public void Set(ref Nullable<JoinLobbyByIdOptions> other) { }

	public void Dispose() { }

}

