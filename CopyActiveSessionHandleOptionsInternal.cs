internal struct CopyActiveSessionHandleOptionsInternal : ISettable<CopyActiveSessionHandleOptions>, IDisposable // TypeDefIndex: 8459
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 

	public Utf8String SessionName { set; }


	public void set_SessionName(Utf8String value) { }

	public void Set(ref CopyActiveSessionHandleOptions other) { }

	public void Set(ref Nullable<CopyActiveSessionHandleOptions> other) { }

	public void Dispose() { }

}

