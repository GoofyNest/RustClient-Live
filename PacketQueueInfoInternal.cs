internal struct PacketQueueInfoInternal : IGettable<PacketQueueInfo>, ISettable<PacketQueueInfo>, IDisposable // TypeDefIndex: 8948
{
	private ulong m_IncomingPacketQueueMaxSizeBytes; 
	private ulong m_IncomingPacketQueueCurrentSizeBytes; 
	private ulong m_IncomingPacketQueueCurrentPacketCount; 
	private ulong m_OutgoingPacketQueueMaxSizeBytes; 
	private ulong m_OutgoingPacketQueueCurrentSizeBytes; 
	private ulong m_OutgoingPacketQueueCurrentPacketCount; 

	public ulong IncomingPacketQueueMaxSizeBytes { get; set; }
	public ulong IncomingPacketQueueCurrentSizeBytes { get; set; }
	public ulong IncomingPacketQueueCurrentPacketCount { get; set; }
	public ulong OutgoingPacketQueueMaxSizeBytes { get; set; }
	public ulong OutgoingPacketQueueCurrentSizeBytes { get; set; }
	public ulong OutgoingPacketQueueCurrentPacketCount { get; set; }


	public ulong get_IncomingPacketQueueMaxSizeBytes() { }

	public void set_IncomingPacketQueueMaxSizeBytes(ulong value) { }

	public ulong get_IncomingPacketQueueCurrentSizeBytes() { }

	public void set_IncomingPacketQueueCurrentSizeBytes(ulong value) { }

	public ulong get_IncomingPacketQueueCurrentPacketCount() { }

	public void set_IncomingPacketQueueCurrentPacketCount(ulong value) { }

	public ulong get_OutgoingPacketQueueMaxSizeBytes() { }

	public void set_OutgoingPacketQueueMaxSizeBytes(ulong value) { }

	public ulong get_OutgoingPacketQueueCurrentSizeBytes() { }

	public void set_OutgoingPacketQueueCurrentSizeBytes(ulong value) { }

	public ulong get_OutgoingPacketQueueCurrentPacketCount() { }

	public void set_OutgoingPacketQueueCurrentPacketCount(ulong value) { }

	public void Set(ref PacketQueueInfo other) { }

	public void Set(ref Nullable<PacketQueueInfo> other) { }

	public void Dispose() { }

	public void Get(out PacketQueueInfo output) { }

}

