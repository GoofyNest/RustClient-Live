internal struct UnregisterPeerOptionsInternal : ISettable<UnregisterPeerOptions>, IDisposable // TypeDefIndex: 9855
{
	private int m_ApiVersion; 
	private IntPtr m_PeerHandle; 

	public IntPtr PeerHandle { set; }


	public void set_PeerHandle(IntPtr value) { }

	public void Set(ref UnregisterPeerOptions other) { }

	public void Set(ref Nullable<UnregisterPeerOptions> other) { }

	public void Dispose() { }

}

