internal struct JoinSessionOptionsInternal : ISettable<JoinSessionOptions>, IDisposable // TypeDefIndex: 8501
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 
	private IntPtr m_SessionHandle; 
	private IntPtr m_LocalUserId; 
	private int m_PresenceEnabled; 

	public Utf8String SessionName { set; }
	public SessionDetails SessionHandle { set; }
	public ProductUserId LocalUserId { set; }
	public bool PresenceEnabled { set; }


	public void set_SessionName(Utf8String value) { }

	public void set_SessionHandle(SessionDetails value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_PresenceEnabled(bool value) { }

	public void Set(ref JoinSessionOptions other) { }

	public void Set(ref Nullable<JoinSessionOptions> other) { }

	public void Dispose() { }

}

