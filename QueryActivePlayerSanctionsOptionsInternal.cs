internal struct QueryActivePlayerSanctionsOptionsInternal : ISettable<QueryActivePlayerSanctionsOptions>, IDisposable // TypeDefIndex: 8621
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_LocalUserId; 

	public ProductUserId TargetUserId { set; }
	public ProductUserId LocalUserId { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref QueryActivePlayerSanctionsOptions other) { }

	public void Set(ref Nullable<QueryActivePlayerSanctionsOptions> other) { }

	public void Dispose() { }

}

