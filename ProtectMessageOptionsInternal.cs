internal struct ProtectMessageOptionsInternal : ISettable<ProtectMessageOptions>, IDisposable // TypeDefIndex: 9742
{
	private int m_ApiVersion;
	private IntPtr m_ClientHandle;
	private uint m_DataLengthBytes;
	private IntPtr m_Data;
	private uint m_OutBufferSizeBytes;

	public IntPtr ClientHandle { set; }
	public ArraySegment<byte> Data { set; }
	public uint OutBufferSizeBytes { set; }


	public void set_ClientHandle(IntPtr value) { }

	public void set_Data(ArraySegment<byte> value) { }

	public void set_OutBufferSizeBytes(uint value) { }

	public void Set(ref ProtectMessageOptions other) { }

	public void Set(ref Nullable<ProtectMessageOptions> other) { }

	public void Dispose() { }

}

internal struct ProtectMessageOptionsInternal : ISettable<ProtectMessageOptions>, IDisposable // TypeDefIndex: 9849
{
	private int m_ApiVersion;
	private uint m_DataLengthBytes;
	private IntPtr m_Data;
	private uint m_OutBufferSizeBytes;

	public ArraySegment<byte> Data { set; }
	public uint OutBufferSizeBytes { set; }


	public void set_Data(ArraySegment<byte> value) { }

	public void set_OutBufferSizeBytes(uint value) { }

	public void Set(ref ProtectMessageOptions other) { }

	public void Set(ref Nullable<ProtectMessageOptions> other) { }

	public void Dispose() { }

}

