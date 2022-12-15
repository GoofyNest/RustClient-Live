internal struct WriteFileOptionsInternal : ISettable<WriteFileOptions>, IDisposable // TypeDefIndex: 8936
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_Filename;
	private uint m_ChunkLengthBytes;
	private IntPtr m_WriteFileDataCallback;
	private IntPtr m_FileTransferProgressCallback;
	private static OnWriteFileDataCallbackInternal s_WriteFileDataCallback;
	private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback;

	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }
	public uint ChunkLengthBytes { set; }
	public static OnWriteFileDataCallbackInternal WriteFileDataCallback { get; }
	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback { get; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Filename(Utf8String value) { }

	public void set_ChunkLengthBytes(uint value) { }

	public static OnWriteFileDataCallbackInternal get_WriteFileDataCallback() { }

	public static OnFileTransferProgressCallbackInternal get_FileTransferProgressCallback() { }

	public void Set(ref WriteFileOptions other) { }

	public void Set(ref Nullable<WriteFileOptions> other) { }

	public void Dispose() { }

}

