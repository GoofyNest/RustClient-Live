internal struct SetPacketQueueSizeOptionsInternal : ISettable<SetPacketQueueSizeOptions>, IDisposable // TypeDefIndex: 8958
{
	private int m_ApiVersion; 
	private ulong m_IncomingPacketQueueMaxSizeBytes; 
	private ulong m_OutgoingPacketQueueMaxSizeBytes; 

	public ulong IncomingPacketQueueMaxSizeBytes { set; }
	public ulong OutgoingPacketQueueMaxSizeBytes { set; }


	public void set_IncomingPacketQueueMaxSizeBytes(ulong value) { }

	public void set_OutgoingPacketQueueMaxSizeBytes(ulong value) { }

	public void Set(ref SetPacketQueueSizeOptions other) { }

	public void Set(ref Nullable<SetPacketQueueSizeOptions> other) { }

	public void Dispose() { }

}

