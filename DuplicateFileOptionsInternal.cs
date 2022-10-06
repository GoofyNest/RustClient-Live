internal struct DuplicateFileOptionsInternal : ISettable<DuplicateFileOptions>, IDisposable // TypeDefIndex: 8873
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_SourceFilename; 
	private IntPtr m_DestinationFilename; 

	public ProductUserId LocalUserId { set; }
	public Utf8String SourceFilename { set; }
	public Utf8String DestinationFilename { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_SourceFilename(Utf8String value) { }

	public void set_DestinationFilename(Utf8String value) { }

	public void Set(ref DuplicateFileOptions other) { }

	public void Set(ref Nullable<DuplicateFileOptions> other) { }

	public void Dispose() { }

}

