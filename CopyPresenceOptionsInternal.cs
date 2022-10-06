internal struct CopyPresenceOptionsInternal : ISettable<CopyPresenceOptions>, IDisposable // TypeDefIndex: 8812
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref CopyPresenceOptions other) { }

	public void Set(ref Nullable<CopyPresenceOptions> other) { }

	public void Dispose() { }

}

