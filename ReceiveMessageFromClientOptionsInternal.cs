internal struct ReceiveMessageFromClientOptionsInternal : ISettable<ReceiveMessageFromClientOptions>, IDisposable // TypeDefIndex: 9742
{
	private int m_ApiVersion;
	private IntPtr m_ClientHandle;
	private uint m_DataLengthBytes;
	private IntPtr m_Data;

	public IntPtr ClientHandle { set; }
	public ArraySegment<byte> Data { set; }


	public void set_ClientHandle(IntPtr value) { }

	public void set_Data(ArraySegment<byte> value) { }

	public void Set(ref ReceiveMessageFromClientOptions other) { }

	public void Set(ref Nullable<ReceiveMessageFromClientOptions> other) { }

	public void Dispose() { }

}

