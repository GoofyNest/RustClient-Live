internal struct DestroySessionOptionsInternal : ISettable<DestroySessionOptions>, IDisposable // TypeDefIndex: 8483
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 

	public Utf8String SessionName { set; }


	public void set_SessionName(Utf8String value) { }

	public void Set(ref DestroySessionOptions other) { }

	public void Set(ref Nullable<DestroySessionOptions> other) { }

	public void Dispose() { }

}

