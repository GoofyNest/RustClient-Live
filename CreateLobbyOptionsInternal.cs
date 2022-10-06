internal struct CreateLobbyOptionsInternal : ISettable<CreateLobbyOptions>, IDisposable // TypeDefIndex: 9082
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private uint m_MaxLobbyMembers; 
	private LobbyPermissionLevel m_PermissionLevel; 
	private int m_PresenceEnabled; 
	private int m_AllowInvites; 
	private IntPtr m_BucketId; 
	private int m_DisableHostMigration; 
	private int m_EnableRTCRoom; 
	private IntPtr m_LocalRTCOptions; 
	private IntPtr m_LobbyId; 
	private int m_EnableJoinById; 
	private int m_RejoinAfterKickRequiresInvite; 

	public ProductUserId LocalUserId { set; }
	public uint MaxLobbyMembers { set; }
	public LobbyPermissionLevel PermissionLevel { set; }
	public bool PresenceEnabled { set; }
	public bool AllowInvites { set; }
	public Utf8String BucketId { set; }
	public bool DisableHostMigration { set; }
	public bool EnableRTCRoom { set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { set; }
	public Utf8String LobbyId { set; }
	public bool EnableJoinById { set; }
	public bool RejoinAfterKickRequiresInvite { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_MaxLobbyMembers(uint value) { }

	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	public void set_PresenceEnabled(bool value) { }

	public void set_AllowInvites(bool value) { }

	public void set_BucketId(Utf8String value) { }

	public void set_DisableHostMigration(bool value) { }

	public void set_EnableRTCRoom(bool value) { }

	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	public void set_LobbyId(Utf8String value) { }

	public void set_EnableJoinById(bool value) { }

	public void set_RejoinAfterKickRequiresInvite(bool value) { }

	public void Set(ref CreateLobbyOptions other) { }

	public void Set(ref Nullable<CreateLobbyOptions> other) { }

	public void Dispose() { }

}

