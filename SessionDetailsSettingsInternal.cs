internal struct SessionDetailsSettingsInternal : IGettable<SessionDetailsSettings>, ISettable<SessionDetailsSettings>, IDisposable // TypeDefIndex: 8517
{
	private int m_ApiVersion; 
	private IntPtr m_BucketId; 
	private uint m_NumPublicConnections; 
	private int m_AllowJoinInProgress; 
	private OnlineSessionPermissionLevel m_PermissionLevel; 
	private int m_InvitesAllowed; 
	private int m_SanctionsEnabled; 

	public Utf8String BucketId { get; set; }
	public uint NumPublicConnections { get; set; }
	public bool AllowJoinInProgress { get; set; }
	public OnlineSessionPermissionLevel PermissionLevel { get; set; }
	public bool InvitesAllowed { get; set; }
	public bool SanctionsEnabled { get; set; }


	public Utf8String get_BucketId() { }

	public void set_BucketId(Utf8String value) { }

	public uint get_NumPublicConnections() { }

	public void set_NumPublicConnections(uint value) { }

	public bool get_AllowJoinInProgress() { }

	public void set_AllowJoinInProgress(bool value) { }

	public OnlineSessionPermissionLevel get_PermissionLevel() { }

	public void set_PermissionLevel(OnlineSessionPermissionLevel value) { }

	public bool get_InvitesAllowed() { }

	public void set_InvitesAllowed(bool value) { }

	public bool get_SanctionsEnabled() { }

	public void set_SanctionsEnabled(bool value) { }

	public void Set(ref SessionDetailsSettings other) { }

	public void Set(ref Nullable<SessionDetailsSettings> other) { }

	public void Dispose() { }

	public void Get(out SessionDetailsSettings output) { }

}

