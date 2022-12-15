internal struct QueryOwnershipTokenOptionsInternal : ISettable<QueryOwnershipTokenOptions>, IDisposable // TypeDefIndex: 9513
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

	public void Set(ref QueryOwnershipTokenOptions other) { }

	public void Set(ref Nullable<QueryOwnershipTokenOptions> other) { }

	public void Dispose() { }

}

