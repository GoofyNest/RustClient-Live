internal struct GetStatCountOptionsInternal : ISettable<GetStatCountOptions>, IDisposable // TypeDefIndex: 8422
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 

	public ProductUserId TargetUserId { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref GetStatCountOptions other) { }

	public void Set(ref Nullable<GetStatCountOptions> other) { }

	public void Dispose() { }

}

