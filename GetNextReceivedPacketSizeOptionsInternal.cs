internal struct GetNextReceivedPacketSizeOptionsInternal : ISettable<GetNextReceivedPacketSizeOptions>, IDisposable // TypeDefIndex: 8947
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RequestedChannel; 

	public ProductUserId LocalUserId { set; }
	public Nullable<byte> RequestedChannel { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RequestedChannel(Nullable<byte> value) { }

	public void Set(ref GetNextReceivedPacketSizeOptions other) { }

	public void Set(ref Nullable<GetNextReceivedPacketSizeOptions> other) { }

	public void Dispose() { }

}

