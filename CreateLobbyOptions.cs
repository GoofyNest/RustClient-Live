public struct CreateLobbyOptions // TypeDefIndex: 9095
{
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <MaxLobbyMembers>k__BackingField;
	[CompilerGeneratedAttribute]
	private LobbyPermissionLevel <PermissionLevel>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <PresenceEnabled>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <AllowInvites>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <BucketId>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <DisableHostMigration>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <EnableRTCRoom>k__BackingField;
	[CompilerGeneratedAttribute]
	private Nullable<LocalRTCOptions> <LocalRTCOptions>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <LobbyId>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <EnableJoinById>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <RejoinAfterKickRequiresInvite>k__BackingField;

	public ProductUserId LocalUserId { get; set; }
	public uint MaxLobbyMembers { get; set; }
	public LobbyPermissionLevel PermissionLevel { get; set; }
	public bool PresenceEnabled { get; set; }
	public bool AllowInvites { get; set; }
	public Utf8String BucketId { get; set; }
	public bool DisableHostMigration { get; set; }
	public bool EnableRTCRoom { get; set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { get; set; }
	public Utf8String LobbyId { get; set; }
	public bool EnableJoinById { get; set; }
	public bool RejoinAfterKickRequiresInvite { get; set; }


	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public uint get_MaxLobbyMembers() { }

	[CompilerGeneratedAttribute]
	public void set_MaxLobbyMembers(uint value) { }

	[CompilerGeneratedAttribute]
	public LobbyPermissionLevel get_PermissionLevel() { }

	[CompilerGeneratedAttribute]
	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	[CompilerGeneratedAttribute]
	public bool get_PresenceEnabled() { }

	[CompilerGeneratedAttribute]
	public void set_PresenceEnabled(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_AllowInvites() { }

	[CompilerGeneratedAttribute]
	public void set_AllowInvites(bool value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_BucketId() { }

	[CompilerGeneratedAttribute]
	public void set_BucketId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public bool get_DisableHostMigration() { }

	[CompilerGeneratedAttribute]
	public void set_DisableHostMigration(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_EnableRTCRoom() { }

	[CompilerGeneratedAttribute]
	public void set_EnableRTCRoom(bool value) { }

	[CompilerGeneratedAttribute]
	public Nullable<LocalRTCOptions> get_LocalRTCOptions() { }

	[CompilerGeneratedAttribute]
	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute]
	public void set_LobbyId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public bool get_EnableJoinById() { }

	[CompilerGeneratedAttribute]
	public void set_EnableJoinById(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_RejoinAfterKickRequiresInvite() { }

	[CompilerGeneratedAttribute]
	public void set_RejoinAfterKickRequiresInvite(bool value) { }

}

