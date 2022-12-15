public struct SendPacketOptions // TypeDefIndex: 9003
{
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <RemoteUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Nullable<SocketId> <SocketId>k__BackingField;
	[CompilerGeneratedAttribute]
	private byte <Channel>k__BackingField;
	[CompilerGeneratedAttribute]
	private ArraySegment<byte> <Data>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <AllowDelayedDelivery>k__BackingField;
	[CompilerGeneratedAttribute]
	private PacketReliability <Reliability>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <DisableAutoAcceptConnection>k__BackingField;

	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public byte Channel { get; set; }
	public ArraySegment<byte> Data { get; set; }
	public bool AllowDelayedDelivery { get; set; }
	public PacketReliability Reliability { get; set; }
	public bool DisableAutoAcceptConnection { get; set; }


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
	public byte get_Channel() { }

	[CompilerGeneratedAttribute]
	public void set_Channel(byte value) { }

	[CompilerGeneratedAttribute]
	public ArraySegment<byte> get_Data() { }

	[CompilerGeneratedAttribute]
	public void set_Data(ArraySegment<byte> value) { }

	[CompilerGeneratedAttribute]
	public bool get_AllowDelayedDelivery() { }

	[CompilerGeneratedAttribute]
	public void set_AllowDelayedDelivery(bool value) { }

	[CompilerGeneratedAttribute]
	public PacketReliability get_Reliability() { }

	[CompilerGeneratedAttribute]
	public void set_Reliability(PacketReliability value) { }

	[CompilerGeneratedAttribute]
	public bool get_DisableAutoAcceptConnection() { }

	[CompilerGeneratedAttribute]
	public void set_DisableAutoAcceptConnection(bool value) { }

}

