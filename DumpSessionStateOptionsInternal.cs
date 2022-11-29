internal struct DumpSessionStateOptionsInternal : ISettable<DumpSessionStateOptions>, IDisposable // TypeDefIndex: 8485
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 

	public Utf8String SessionName { set; }


	public void set_SessionName(Utf8String value) { }

	public void Set(ref DumpSessionStateOptions other) { }

	public void Set(ref Nullable<DumpSessionStateOptions> other) { }

	public void Dispose() { }

}

