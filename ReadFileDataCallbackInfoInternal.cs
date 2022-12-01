internal struct ReadFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileDataCallbackInfo>, ISettable<ReadFileDataCallbackInfo>, IDisposable // TypeDefIndex: 8422
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_Filename;
	private uint m_TotalFileSizeBytes;
	private int m_IsLastChunk;
	private uint m_DataChunkLengthBytes;
	private IntPtr m_DataChunk;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint TotalFileSizeBytes { get; set; }
	public bool IsLastChunk { get; set; }
	public ArraySegment<byte> DataChunk { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public uint get_TotalFileSizeBytes() { }

	public void set_TotalFileSizeBytes(uint value) { }

	public bool get_IsLastChunk() { }

	public void set_IsLastChunk(bool value) { }

	public ArraySegment<byte> get_DataChunk() { }

	public void set_DataChunk(ArraySegment<byte> value) { }

	public void Set(ref ReadFileDataCallbackInfo other) { }

	public void Set(ref Nullable<ReadFileDataCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out ReadFileDataCallbackInfo output) { }

}

internal struct ReadFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileDataCallbackInfo>, ISettable<ReadFileDataCallbackInfo>, IDisposable // TypeDefIndex: 8925
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_Filename;
	private uint m_TotalFileSizeBytes;
	private int m_IsLastChunk;
	private uint m_DataChunkLengthBytes;
	private IntPtr m_DataChunk;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint TotalFileSizeBytes { get; set; }
	public bool IsLastChunk { get; set; }
	public ArraySegment<byte> DataChunk { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public uint get_TotalFileSizeBytes() { }

	public void set_TotalFileSizeBytes(uint value) { }

	public bool get_IsLastChunk() { }

	public void set_IsLastChunk(bool value) { }

	public ArraySegment<byte> get_DataChunk() { }

	public void set_DataChunk(ArraySegment<byte> value) { }

	public void Set(ref ReadFileDataCallbackInfo other) { }

	public void Set(ref Nullable<ReadFileDataCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out ReadFileDataCallbackInfo output) { }

}

