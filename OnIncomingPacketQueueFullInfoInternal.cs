internal struct OnIncomingPacketQueueFullInfoInternal : ICallbackInfoInternal, IGettable<OnIncomingPacketQueueFullInfo>, ISettable<OnIncomingPacketQueueFullInfo>, IDisposable // TypeDefIndex: 8975
{
	private IntPtr m_ClientData;
	private ulong m_PacketQueueMaxSizeBytes;
	private ulong m_PacketQueueCurrentSizeBytes;
	private IntPtr m_OverflowPacketLocalUserId;
	private byte m_OverflowPacketChannel;
	private uint m_OverflowPacketSizeBytes;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ulong PacketQueueMaxSizeBytes { get; set; }
	public ulong PacketQueueCurrentSizeBytes { get; set; }
	public ProductUserId OverflowPacketLocalUserId { get; set; }
	public byte OverflowPacketChannel { get; set; }
	public uint OverflowPacketSizeBytes { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ulong get_PacketQueueMaxSizeBytes() { }

	public void set_PacketQueueMaxSizeBytes(ulong value) { }

	public ulong get_PacketQueueCurrentSizeBytes() { }

	public void set_PacketQueueCurrentSizeBytes(ulong value) { }

	public ProductUserId get_OverflowPacketLocalUserId() { }

	public void set_OverflowPacketLocalUserId(ProductUserId value) { }

	public byte get_OverflowPacketChannel() { }

	public void set_OverflowPacketChannel(byte value) { }

	public uint get_OverflowPacketSizeBytes() { }

	public void set_OverflowPacketSizeBytes(uint value) { }

	public void Set(ref OnIncomingPacketQueueFullInfo other) { }

	public void Set(ref Nullable<OnIncomingPacketQueueFullInfo> other) { }

	public void Dispose() { }

	public void Get(out OnIncomingPacketQueueFullInfo output) { }

}

