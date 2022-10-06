internal struct ReceiveMessageFromServerOptionsInternal : ISettable<ReceiveMessageFromServerOptions>, IDisposable // TypeDefIndex: 9839
{
	private int m_ApiVersion; 
	private uint m_DataLengthBytes; 
	private IntPtr m_Data; 

	public ArraySegment<byte> Data { set; }


	public void set_Data(ArraySegment<byte> value) { }

	public void Set(ref ReceiveMessageFromServerOptions other) { }

	public void Set(ref Nullable<ReceiveMessageFromServerOptions> other) { }

	public void Dispose() { }

}

