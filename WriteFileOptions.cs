public struct WriteFileOptions // TypeDefIndex: 8922
{
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Filename>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <ChunkLengthBytes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private OnWriteFileDataCallback <WriteFileDataCallback>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private OnFileTransferProgressCallback <FileTransferProgressCallback>k__BackingField; 

	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint ChunkLengthBytes { get; set; }
	public OnWriteFileDataCallback WriteFileDataCallback { get; set; }
	public OnFileTransferProgressCallback FileTransferProgressCallback { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Filename() { }

	[CompilerGeneratedAttribute] 
	public void set_Filename(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public uint get_ChunkLengthBytes() { }

	[CompilerGeneratedAttribute] 
	public void set_ChunkLengthBytes(uint value) { }

	[CompilerGeneratedAttribute] 
	public OnWriteFileDataCallback get_WriteFileDataCallback() { }

	[CompilerGeneratedAttribute] 
	public void set_WriteFileDataCallback(OnWriteFileDataCallback value) { }

	[CompilerGeneratedAttribute] 
	public OnFileTransferProgressCallback get_FileTransferProgressCallback() { }

	[CompilerGeneratedAttribute] 
	public void set_FileTransferProgressCallback(OnFileTransferProgressCallback value) { }

}

