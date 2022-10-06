internal struct AddNotifyPeerConnectionEstablishedOptionsInternal : ISettable<AddNotifyPeerConnectionEstablishedOptions>, IDisposable // TypeDefIndex: 8931
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_SocketId; 

	public ProductUserId LocalUserId { set; }
	public Nullable<SocketId> SocketId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_SocketId(Nullable<SocketId> value) { }

	public void Set(ref AddNotifyPeerConnectionEstablishedOptions other) { }

	public void Set(ref Nullable<AddNotifyPeerConnectionEstablishedOptions> other) { }

	public void Dispose() { }

}

