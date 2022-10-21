internal struct AcceptConnectionOptionsInternal : ISettable<AcceptConnectionOptions>, IDisposable // TypeDefIndex: 8926
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RemoteUserId; 
	private IntPtr m_SocketId; 

	public ProductUserId LocalUserId { set; }
	public ProductUserId RemoteUserId { set; }
	public Nullable<SocketId> SocketId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RemoteUserId(ProductUserId value) { }

	public void set_SocketId(Nullable<SocketId> value) { }

	public void Set(ref AcceptConnectionOptions other) { }

	public void Set(ref Nullable<AcceptConnectionOptions> other) { }

	public void Dispose() { }

}

