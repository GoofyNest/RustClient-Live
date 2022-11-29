internal struct DeleteFileOptionsInternal : ISettable<DeleteFileOptions>, IDisposable // TypeDefIndex: 8879
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Filename; 

	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Filename(Utf8String value) { }

	public void Set(ref DeleteFileOptions other) { }

	public void Set(ref Nullable<DeleteFileOptions> other) { }

	public void Dispose() { }

}

