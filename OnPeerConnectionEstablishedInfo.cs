public struct OnPeerConnectionEstablishedInfo : ICallbackInfo // TypeDefIndex: 8932
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <RemoteUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<SocketId> <SocketId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ConnectionEstablishedType <ConnectionType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private NetworkConnectionType <NetworkType>k__BackingField; 

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public ConnectionEstablishedType ConnectionType { get; set; }
	public NetworkConnectionType NetworkType { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_RemoteUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_RemoteUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGeneratedAttribute] 
	public void set_SocketId(Nullable<SocketId> value) { }

	[CompilerGeneratedAttribute] 
	public ConnectionEstablishedType get_ConnectionType() { }

	[CompilerGeneratedAttribute] 
	public void set_ConnectionType(ConnectionEstablishedType value) { }

	[CompilerGeneratedAttribute] 
	public NetworkConnectionType get_NetworkType() { }

	[CompilerGeneratedAttribute] 
	public void set_NetworkType(NetworkConnectionType value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnPeerConnectionEstablishedInfoInternal other) { }

}

