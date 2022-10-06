public struct LobbyDetailsInfo // TypeDefIndex: 9141
{
	[CompilerGeneratedAttribute] 
	private Utf8String <LobbyId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LobbyOwnerUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LobbyPermissionLevel <PermissionLevel>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <AvailableSlots>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <MaxMembers>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <AllowInvites>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <BucketId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <AllowHostMigration>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <RTCRoomEnabled>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <AllowJoinById>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <RejoinAfterKickRequiresInvite>k__BackingField; 

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


	[CompilerGeneratedAttribute] 
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute] 
	public void set_LobbyId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LobbyOwnerUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LobbyOwnerUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public LobbyPermissionLevel get_PermissionLevel() { }

	[CompilerGeneratedAttribute] 
	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	[CompilerGeneratedAttribute] 
	public uint get_AvailableSlots() { }

	[CompilerGeneratedAttribute] 
	public void set_AvailableSlots(uint value) { }

	[CompilerGeneratedAttribute] 
	public uint get_MaxMembers() { }

	[CompilerGeneratedAttribute] 
	public void set_MaxMembers(uint value) { }

	[CompilerGeneratedAttribute] 
	public bool get_AllowInvites() { }

	[CompilerGeneratedAttribute] 
	public void set_AllowInvites(bool value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_BucketId() { }

	[CompilerGeneratedAttribute] 
	public void set_BucketId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public bool get_AllowHostMigration() { }

	[CompilerGeneratedAttribute] 
	public void set_AllowHostMigration(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_RTCRoomEnabled() { }

	[CompilerGeneratedAttribute] 
	public void set_RTCRoomEnabled(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_AllowJoinById() { }

	[CompilerGeneratedAttribute] 
	public void set_AllowJoinById(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_RejoinAfterKickRequiresInvite() { }

	[CompilerGeneratedAttribute] 
	public void set_RejoinAfterKickRequiresInvite(bool value) { }

	internal void Set(ref LobbyDetailsInfoInternal other) { }

}

