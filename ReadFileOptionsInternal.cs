internal struct ReadFileOptionsInternal : ISettable<ReadFileOptions>, IDisposable // TypeDefIndex: 8378
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Filename; 
	private uint m_ReadChunkLengthBytes; 
	private IntPtr m_ReadFileDataCallback; 
	private IntPtr m_FileTransferProgressCallback; 
	private static OnReadFileDataCallbackInternal s_ReadFileDataCallback; 
	private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback; 

	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }
	public uint ReadChunkLengthBytes { set; }
	public static OnReadFileDataCallbackInternal ReadFileDataCallback { get; }
	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback { get; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Filename(Utf8String value) { }

	public void set_ReadChunkLengthBytes(uint value) { }

	public static OnReadFileDataCallbackInternal get_ReadFileDataCallback() { }

	public static OnFileTransferProgressCallbackInternal get_FileTransferProgressCallback() { }

	public void Set(ref ReadFileOptions other) { }

	public void Set(ref Nullable<ReadFileOptions> other) { }

	public void Dispose() { }

}

internal struct ReadFileOptionsInternal : ISettable<ReadFileOptions>, IDisposable // TypeDefIndex: 8881
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Filename; 
	private uint m_ReadChunkLengthBytes; 
	private IntPtr m_ReadFileDataCallback; 
	private IntPtr m_FileTransferProgressCallback; 
	private static OnReadFileDataCallbackInternal s_ReadFileDataCallback; 
	private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback; 

	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }
	public uint ReadChunkLengthBytes { set; }
	public static OnReadFileDataCallbackInternal ReadFileDataCallback { get; }
	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback { get; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Filename(Utf8String value) { }

	public void set_ReadChunkLengthBytes(uint value) { }

	public static OnReadFileDataCallbackInternal get_ReadFileDataCallback() { }

	public static OnFileTransferProgressCallbackInternal get_FileTransferProgressCallback() { }

	public void Set(ref ReadFileOptions other) { }

	public void Set(ref Nullable<ReadFileOptions> other) { }

	public void Dispose() { }

}

