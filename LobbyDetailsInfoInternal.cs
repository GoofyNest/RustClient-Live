internal struct LobbyDetailsInfoInternal : IGettable<LobbyDetailsInfo>, ISettable<LobbyDetailsInfo>, IDisposable // TypeDefIndex: 9143
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyId; 
	private IntPtr m_LobbyOwnerUserId; 
	private LobbyPermissionLevel m_PermissionLevel; 
	private uint m_AvailableSlots; 
	private uint m_MaxMembers; 
	private int m_AllowInvites; 
	private IntPtr m_BucketId; 
	private int m_AllowHostMigration; 
	private int m_RTCRoomEnabled; 
	private int m_AllowJoinById; 
	private int m_RejoinAfterKickRequiresInvite; 

	public Utf8String LobbyId { get; set; }
	public ProductUserId LobbyOwnerUserId { get; set; }
	public LobbyPermissionLevel PermissionLevel { get; set; }
	public uint AvailableSlots { get; set; }
	public uint MaxMembers { get; set; }
	public bool AllowInvites { get; set; }
	public Utf8String BucketId { get; set; }
	public bool AllowHostMigration { get; set; }
	public bool RTCRoomEnabled { get; set; }
	public bool AllowJoinById { get; set; }
	public bool RejoinAfterKickRequiresInvite { get; set; }


	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public ProductUserId get_LobbyOwnerUserId() { }

	public void set_LobbyOwnerUserId(ProductUserId value) { }

	public LobbyPermissionLevel get_PermissionLevel() { }

	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	public uint get_AvailableSlots() { }

	public void set_AvailableSlots(uint value) { }

	public uint get_MaxMembers() { }

	public void set_MaxMembers(uint value) { }

	public bool get_AllowInvites() { }

	public void set_AllowInvites(bool value) { }

	public Utf8String get_BucketId() { }

	public void set_BucketId(Utf8String value) { }

	public bool get_AllowHostMigration() { }

	public void set_AllowHostMigration(bool value) { }

	public bool get_RTCRoomEnabled() { }

	public void set_RTCRoomEnabled(bool value) { }

	public bool get_AllowJoinById() { }

	public void set_AllowJoinById(bool value) { }

	public bool get_RejoinAfterKickRequiresInvite() { }

	public void set_RejoinAfterKickRequiresInvite(bool value) { }

	public void Set(ref LobbyDetailsInfo other) { }

	public void Set(ref Nullable<LobbyDetailsInfo> other) { }

	public void Dispose() { }

	public void Get(out LobbyDetailsInfo output) { }

}

