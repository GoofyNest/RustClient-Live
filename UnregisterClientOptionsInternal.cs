internal struct UnregisterClientOptionsInternal : ISettable<UnregisterClientOptions>, IDisposable // TypeDefIndex: 9739
{
	private int m_ApiVersion; 
	private IntPtr m_ClientHandle; 

	public IntPtr ClientHandle { set; }


	public void set_ClientHandle(IntPtr value) { }

	public void Set(ref UnregisterClientOptions other) { }

	public void Set(ref Nullable<UnregisterClientOptions> other) { }

	public void Dispose() { }

}

