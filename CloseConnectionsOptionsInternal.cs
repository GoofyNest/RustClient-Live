internal struct CloseConnectionsOptionsInternal : ISettable<CloseConnectionsOptions>, IDisposable // TypeDefIndex: 8907
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_SocketId; 

	public ProductUserId LocalUserId { set; }
	public Nullable<SocketId> SocketId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_SocketId(Nullable<SocketId> value) { }

	public void Set(ref CloseConnectionsOptions other) { }

	public void Set(ref Nullable<CloseConnectionsOptions> other) { }

	public void Dispose() { }

}

