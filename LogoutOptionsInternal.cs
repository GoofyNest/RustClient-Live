internal struct LogoutOptionsInternal : ISettable<LogoutOptions>, IDisposable // TypeDefIndex: 9679
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public EpicAccountId LocalUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref LogoutOptions other) { }

	public void Set(ref Nullable<LogoutOptions> other) { }

	public void Dispose() { }

}

