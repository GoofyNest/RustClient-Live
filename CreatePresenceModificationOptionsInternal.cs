internal struct CreatePresenceModificationOptionsInternal : ISettable<CreatePresenceModificationOptions>, IDisposable // TypeDefIndex: 8814
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public EpicAccountId LocalUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref CreatePresenceModificationOptions other) { }

	public void Set(ref Nullable<CreatePresenceModificationOptions> other) { }

	public void Dispose() { }

}

