internal struct CreateSessionModificationOptionsInternal : ISettable<CreateSessionModificationOptions>, IDisposable // TypeDefIndex: 8468
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 
	private IntPtr m_BucketId; 
	private uint m_MaxPlayers; 
	private IntPtr m_LocalUserId; 
	private int m_PresenceEnabled; 
	private IntPtr m_SessionId; 
	private int m_SanctionsEnabled; 

	public Utf8String SessionName { set; }
	public Utf8String BucketId { set; }
	public uint MaxPlayers { set; }
	public ProductUserId LocalUserId { set; }
	public bool PresenceEnabled { set; }
	public Utf8String SessionId { set; }
	public bool SanctionsEnabled { set; }


	public void set_SessionName(Utf8String value) { }

	public void set_BucketId(Utf8String value) { }

	public void set_MaxPlayers(uint value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_PresenceEnabled(bool value) { }

	public void set_SessionId(Utf8String value) { }

	public void set_SanctionsEnabled(bool value) { }

	public void Set(ref CreateSessionModificationOptions other) { }

	public void Set(ref Nullable<CreateSessionModificationOptions> other) { }

	public void Dispose() { }

}

