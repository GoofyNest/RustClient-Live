internal struct SessionModificationSetPermissionLevelOptionsInternal : ISettable<SessionModificationSetPermissionLevelOptions>, IDisposable // TypeDefIndex: 8582
{
	private int m_ApiVersion; 
	private OnlineSessionPermissionLevel m_PermissionLevel; 

	public OnlineSessionPermissionLevel PermissionLevel { set; }


	public void set_PermissionLevel(OnlineSessionPermissionLevel value) { }

	public void Set(ref SessionModificationSetPermissionLevelOptions other) { }

	public void Set(ref Nullable<SessionModificationSetPermissionLevelOptions> other) { }

	public void Dispose() { }

}

