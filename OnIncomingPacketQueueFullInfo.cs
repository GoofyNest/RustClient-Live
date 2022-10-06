public struct OnIncomingPacketQueueFullInfo : ICallbackInfo // TypeDefIndex: 8962
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <PacketQueueMaxSizeBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <PacketQueueCurrentSizeBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <OverflowPacketLocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private byte <OverflowPacketChannel>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <OverflowPacketSizeBytes>k__BackingField; 

	public object ClientData { get; set; }
	public ulong PacketQueueMaxSizeBytes { get; set; }
	public ulong PacketQueueCurrentSizeBytes { get; set; }
	public ProductUserId OverflowPacketLocalUserId { get; set; }
	public byte OverflowPacketChannel { get; set; }
	public uint OverflowPacketSizeBytes { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_PacketQueueMaxSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_PacketQueueMaxSizeBytes(ulong value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_PacketQueueCurrentSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_PacketQueueCurrentSizeBytes(ulong value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_OverflowPacketLocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_OverflowPacketLocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public byte get_OverflowPacketChannel() { }

	[CompilerGeneratedAttribute] 
	public void set_OverflowPacketChannel(byte value) { }

	[CompilerGeneratedAttribute] 
	public uint get_OverflowPacketSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_OverflowPacketSizeBytes(uint value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnIncomingPacketQueueFullInfoInternal other) { }

}

