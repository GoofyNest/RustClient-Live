internal struct GetEntitlementsByNameCountOptionsInternal : ISettable<GetEntitlementsByNameCountOptions>, IDisposable // TypeDefIndex: 9450
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_EntitlementName; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String EntitlementName { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_EntitlementName(Utf8String value) { }

	public void Set(ref GetEntitlementsByNameCountOptions other) { }

	public void Set(ref Nullable<GetEntitlementsByNameCountOptions> other) { }

	public void Dispose() { }

}

