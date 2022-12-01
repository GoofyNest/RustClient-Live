internal struct WriteFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<WriteFileDataCallbackInfo>, ISettable<WriteFileDataCallbackInfo>, IDisposable // TypeDefIndex: 8932
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_Filename;
	private uint m_DataBufferLengthBytes;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint DataBufferLengthBytes { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public uint get_DataBufferLengthBytes() { }

	public void set_DataBufferLengthBytes(uint value) { }

	public void Set(ref WriteFileDataCallbackInfo other) { }

	public void Set(ref Nullable<WriteFileDataCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out WriteFileDataCallbackInfo output) { }

}

