internal struct UnprotectMessageOptionsInternal : ISettable<UnprotectMessageOptions>, IDisposable // TypeDefIndex: 9746
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

	public void Set(ref UnprotectMessageOptions other) { }

	public void Set(ref Nullable<UnprotectMessageOptions> other) { }

	public void Dispose() { }

}

internal struct UnprotectMessageOptionsInternal : ISettable<UnprotectMessageOptions>, IDisposable // TypeDefIndex: 9853
{
	private int m_ApiVersion; 
	private uint m_DataLengthBytes; 
	private IntPtr m_Data; 
	private uint m_OutBufferSizeBytes; 

	public ArraySegment<byte> Data { set; }
	public uint OutBufferSizeBytes { set; }


	public void set_Data(ArraySegment<byte> value) { }

	public void set_OutBufferSizeBytes(uint value) { }

	public void Set(ref UnprotectMessageOptions other) { }

	public void Set(ref Nullable<UnprotectMessageOptions> other) { }

	public void Dispose() { }

}

