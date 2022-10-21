public struct PacketQueueInfo // TypeDefIndex: 8982
{
	[CompilerGeneratedAttribute] 
	private ulong <IncomingPacketQueueMaxSizeBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <IncomingPacketQueueCurrentSizeBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <IncomingPacketQueueCurrentPacketCount>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <OutgoingPacketQueueMaxSizeBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <OutgoingPacketQueueCurrentSizeBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <OutgoingPacketQueueCurrentPacketCount>k__BackingField; 

	public ulong IncomingPacketQueueMaxSizeBytes { get; set; }
	public ulong IncomingPacketQueueCurrentSizeBytes { get; set; }
	public ulong IncomingPacketQueueCurrentPacketCount { get; set; }
	public ulong OutgoingPacketQueueMaxSizeBytes { get; set; }
	public ulong OutgoingPacketQueueCurrentSizeBytes { get; set; }
	public ulong OutgoingPacketQueueCurrentPacketCount { get; set; }


	[CompilerGeneratedAttribute] 
	public ulong get_IncomingPacketQueueMaxSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_IncomingPacketQueueMaxSizeBytes(ulong value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_IncomingPacketQueueCurrentSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_IncomingPacketQueueCurrentSizeBytes(ulong value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_IncomingPacketQueueCurrentPacketCount() { }

	[CompilerGeneratedAttribute] 
	public void set_IncomingPacketQueueCurrentPacketCount(ulong value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_OutgoingPacketQueueMaxSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_OutgoingPacketQueueMaxSizeBytes(ulong value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_OutgoingPacketQueueCurrentSizeBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_OutgoingPacketQueueCurrentSizeBytes(ulong value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_OutgoingPacketQueueCurrentPacketCount() { }

	[CompilerGeneratedAttribute] 
	public void set_OutgoingPacketQueueCurrentPacketCount(ulong value) { }

	internal void Set(ref PacketQueueInfoInternal other) { }

}

