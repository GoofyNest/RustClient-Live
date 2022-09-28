internal struct CopyStatByNameOptionsInternal : ISettable<CopyStatByNameOptions>, IDisposable // TypeDefIndex: 8385
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_Name; 

	public ProductUserId TargetUserId { set; }
	public Utf8String Name { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_Name(Utf8String value) { }

	public void Set(ref CopyStatByNameOptions other) { }

	public void Set(ref Nullable<CopyStatByNameOptions> other) { }

	public void Dispose() { }

}

