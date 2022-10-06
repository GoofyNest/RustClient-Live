internal struct GetPermissionByKeyOptionsInternal : ISettable<GetPermissionByKeyOptions>, IDisposable // TypeDefIndex: 9321
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Key; 

	public ProductUserId LocalUserId { set; }
	public Utf8String Key { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Key(Utf8String value) { }

	public void Set(ref GetPermissionByKeyOptions other) { }

	public void Set(ref Nullable<GetPermissionByKeyOptions> other) { }

	public void Dispose() { }

}

