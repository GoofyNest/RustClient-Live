internal struct ReceivePacketOptionsInternal : ISettable<ReceivePacketOptions>, IDisposable // TypeDefIndex: 8988
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private uint m_MaxDataSizeBytes; 
	private IntPtr m_RequestedChannel; 

	public ProductUserId LocalUserId { set; }
	public uint MaxDataSizeBytes { set; }
	public Nullable<byte> RequestedChannel { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_MaxDataSizeBytes(uint value) { }

	public void set_RequestedChannel(Nullable<byte> value) { }

	public void Set(ref ReceivePacketOptions other) { }

	public void Set(ref Nullable<ReceivePacketOptions> other) { }

	public void Dispose() { }

}

