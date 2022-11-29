internal struct QueryExternalAccountMappingsOptionsInternal : ISettable<QueryExternalAccountMappingsOptions>, IDisposable // TypeDefIndex: 9626
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private ExternalAccountType m_AccountIdType; 
	private IntPtr m_ExternalAccountIds; 
	private uint m_ExternalAccountIdCount; 

	public ProductUserId LocalUserId { set; }
	public ExternalAccountType AccountIdType { set; }
	public Utf8String[] ExternalAccountIds { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_AccountIdType(ExternalAccountType value) { }

	public void set_ExternalAccountIds(Utf8String[] value) { }

	public void Set(ref QueryExternalAccountMappingsOptions other) { }

	public void Set(ref Nullable<QueryExternalAccountMappingsOptions> other) { }

	public void Dispose() { }

}

