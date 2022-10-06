internal struct OnPeerConnectionEstablishedInfoInternal : ICallbackInfoInternal, IGettable<OnPeerConnectionEstablishedInfo>, ISettable<OnPeerConnectionEstablishedInfo>, IDisposable // TypeDefIndex: 8967
{
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RemoteUserId; 
	private IntPtr m_SocketId; 
	private ConnectionEstablishedType m_ConnectionType; 
	private NetworkConnectionType m_NetworkType; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public ConnectionEstablishedType ConnectionType { get; set; }
	public NetworkConnectionType NetworkType { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public ProductUserId get_RemoteUserId() { }

	public void set_RemoteUserId(ProductUserId value) { }

	public Nullable<SocketId> get_SocketId() { }

	public void set_SocketId(Nullable<SocketId> value) { }

	public ConnectionEstablishedType get_ConnectionType() { }

	public void set_ConnectionType(ConnectionEstablishedType value) { }

	public NetworkConnectionType get_NetworkType() { }

	public void set_NetworkType(NetworkConnectionType value) { }

	public void Set(ref OnPeerConnectionEstablishedInfo other) { }

	public void Set(ref Nullable<OnPeerConnectionEstablishedInfo> other) { }

	public void Dispose() { }

	public void Get(out OnPeerConnectionEstablishedInfo output) { }

}

