internal struct ReceiveMessageFromPeerOptionsInternal : ISettable<ReceiveMessageFromPeerOptions>, IDisposable // TypeDefIndex: 9851
{
	private int m_ApiVersion;
	private IntPtr m_PeerHandle;
	private uint m_DataLengthBytes;
	private IntPtr m_Data;

	public IntPtr PeerHandle { set; }
	public ArraySegment<byte> Data { set; }


	public void set_PeerHandle(IntPtr value) { }

	public void set_Data(ArraySegment<byte> value) { }

	public void Set(ref ReceiveMessageFromPeerOptions other) { }

	public void Set(ref Nullable<ReceiveMessageFromPeerOptions> other) { }

	public void Dispose() { }

}

