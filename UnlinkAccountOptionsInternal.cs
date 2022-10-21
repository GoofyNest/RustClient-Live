internal struct UnlinkAccountOptionsInternal : ISettable<UnlinkAccountOptions>, IDisposable // TypeDefIndex: 9629
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public ProductUserId LocalUserId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref UnlinkAccountOptions other) { }

	public void Set(ref Nullable<UnlinkAccountOptions> other) { }

	public void Dispose() { }

}

