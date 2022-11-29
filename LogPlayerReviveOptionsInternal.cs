internal struct LogPlayerReviveOptionsInternal : ISettable<LogPlayerReviveOptions>, IDisposable // TypeDefIndex: 9776
{
	private int m_ApiVersion; 
	private IntPtr m_RevivedPlayerHandle; 
	private IntPtr m_ReviverPlayerHandle; 

	public IntPtr RevivedPlayerHandle { set; }
	public IntPtr ReviverPlayerHandle { set; }


	public void set_RevivedPlayerHandle(IntPtr value) { }

	public void set_ReviverPlayerHandle(IntPtr value) { }

	public void Set(ref LogPlayerReviveOptions other) { }

	public void Set(ref Nullable<LogPlayerReviveOptions> other) { }

	public void Dispose() { }

}

