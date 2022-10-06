internal struct HasPresenceOptionsInternal : ISettable<HasPresenceOptions>, IDisposable // TypeDefIndex: 8820
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref HasPresenceOptions other) { }

	public void Set(ref Nullable<HasPresenceOptions> other) { }

	public void Dispose() { }

}

