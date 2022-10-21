internal struct QueryOwnershipOptionsInternal : ISettable<QueryOwnershipOptions>, IDisposable // TypeDefIndex: 9496
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_CatalogItemIds; 
	private uint m_CatalogItemIdCount; 
	private IntPtr m_CatalogNamespace; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String[] CatalogItemIds { set; }
	public Utf8String CatalogNamespace { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_CatalogItemIds(Utf8String[] value) { }

	public void set_CatalogNamespace(Utf8String value) { }

	public void Set(ref QueryOwnershipOptions other) { }

	public void Set(ref Nullable<QueryOwnershipOptions> other) { }

	public void Dispose() { }

}

