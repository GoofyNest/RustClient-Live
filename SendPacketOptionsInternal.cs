internal struct SendPacketOptionsInternal : ISettable<SendPacketOptions>, IDisposable // TypeDefIndex: 9002
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_RemoteUserId;
	private IntPtr m_SocketId;
	private byte m_Channel;
	private uint m_DataLengthBytes;
	private IntPtr m_Data;
	private int m_AllowDelayedDelivery;
	private PacketReliability m_Reliability;
	private int m_DisableAutoAcceptConnection;

	public ProductUserId LocalUserId { set; }
	public ProductUserId RemoteUserId { set; }
	public Nullable<SocketId> SocketId { set; }
	public byte Channel { set; }
	public ArraySegment<byte> Data { set; }
	public bool AllowDelayedDelivery { set; }
	public PacketReliability Reliability { set; }
	public bool DisableAutoAcceptConnection { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RemoteUserId(ProductUserId value) { }

	public void set_SocketId(Nullable<SocketId> value) { }

	public void set_Channel(byte value) { }

	public void set_Data(ArraySegment<byte> value) { }

	public void set_AllowDelayedDelivery(bool value) { }

	public void set_Reliability(PacketReliability value) { }

	public void set_DisableAutoAcceptConnection(bool value) { }

	public void Set(ref SendPacketOptions other) { }

	public void Set(ref Nullable<SendPacketOptions> other) { }

	public void Dispose() { }

}

