internal struct StartSessionOptionsInternal : ISettable<StartSessionOptions>, IDisposable // TypeDefIndex: 8598
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 

	public Utf8String SessionName { set; }


	public void set_SessionName(Utf8String value) { }

	public void Set(ref StartSessionOptions other) { }

	public void Set(ref Nullable<StartSessionOptions> other) { }

	public void Dispose() { }

}

