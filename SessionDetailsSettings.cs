public struct SessionDetailsSettings // TypeDefIndex: 8562
{
	[CompilerGeneratedAttribute]
	private Utf8String <BucketId>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <NumPublicConnections>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <AllowJoinInProgress>k__BackingField;
	[CompilerGeneratedAttribute]
	private OnlineSessionPermissionLevel <PermissionLevel>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <InvitesAllowed>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <SanctionsEnabled>k__BackingField;

	public Utf8String BucketId { get; set; }
	public uint NumPublicConnections { get; set; }
	public bool AllowJoinInProgress { get; set; }
	public OnlineSessionPermissionLevel PermissionLevel { get; set; }
	public bool InvitesAllowed { get; set; }
	public bool SanctionsEnabled { get; set; }


	[CompilerGeneratedAttribute]
	public Utf8String get_BucketId() { }

	[CompilerGeneratedAttribute]
	public void set_BucketId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public uint get_NumPublicConnections() { }

	[CompilerGeneratedAttribute]
	public void set_NumPublicConnections(uint value) { }

	[CompilerGeneratedAttribute]
	public bool get_AllowJoinInProgress() { }

	[CompilerGeneratedAttribute]
	public void set_AllowJoinInProgress(bool value) { }

	[CompilerGeneratedAttribute]
	public OnlineSessionPermissionLevel get_PermissionLevel() { }

	[CompilerGeneratedAttribute]
	public void set_PermissionLevel(OnlineSessionPermissionLevel value) { }

	[CompilerGeneratedAttribute]
	public bool get_InvitesAllowed() { }

	[CompilerGeneratedAttribute]
	public void set_InvitesAllowed(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_SanctionsEnabled() { }

	[CompilerGeneratedAttribute]
	public void set_SanctionsEnabled(bool value) { }

	internal void Set(ref SessionDetailsSettingsInternal other) { }

}

