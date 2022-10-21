internal struct GetProductUserIdMappingOptionsInternal : ISettable<GetProductUserIdMappingOptions>, IDisposable // TypeDefIndex: 9577
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private ExternalAccountType m_AccountIdType; 
	private IntPtr m_TargetProductUserId; 

	public ProductUserId LocalUserId { set; }
	public ExternalAccountType AccountIdType { set; }
	public ProductUserId TargetProductUserId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_AccountIdType(ExternalAccountType value) { }

	public void set_TargetProductUserId(ProductUserId value) { }

	public void Set(ref GetProductUserIdMappingOptions other) { }

	public void Set(ref Nullable<GetProductUserIdMappingOptions> other) { }

	public void Dispose() { }

}

