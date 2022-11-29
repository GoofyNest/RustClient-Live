internal struct QueryProductUserIdMappingsOptionsInternal : ISettable<QueryProductUserIdMappingsOptions>, IDisposable // TypeDefIndex: 9630
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private ExternalAccountType m_AccountIdType_DEPRECATED; 
	private IntPtr m_ProductUserIds; 
	private uint m_ProductUserIdCount; 

	public ProductUserId LocalUserId { set; }
	public ExternalAccountType AccountIdType_DEPRECATED { set; }
	public ProductUserId[] ProductUserIds { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_AccountIdType_DEPRECATED(ExternalAccountType value) { }

	public void set_ProductUserIds(ProductUserId[] value) { }

	public void Set(ref QueryProductUserIdMappingsOptions other) { }

	public void Set(ref Nullable<QueryProductUserIdMappingsOptions> other) { }

	public void Dispose() { }

}

