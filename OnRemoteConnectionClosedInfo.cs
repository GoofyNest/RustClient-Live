public struct OnRemoteConnectionClosedInfo : ICallbackInfo // TypeDefIndex: 8992
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
	private ConnectionClosedReason <Reason>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public ConnectionClosedReason Reason { get; set; }


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
	public ConnectionClosedReason get_Reason() { }

	[CompilerGeneratedAttribute]
	public void set_Reason(ConnectionClosedReason value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnRemoteConnectionClosedInfoInternal other) { }

}

