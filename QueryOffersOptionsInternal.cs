internal struct QueryOffersOptionsInternal : ISettable<QueryOffersOptions>, IDisposable // TypeDefIndex: 9505
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_OverrideCatalogNamespace;

	public EpicAccountId LocalUserId { set; }
	public Utf8String OverrideCatalogNamespace { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_OverrideCatalogNamespace(Utf8String value) { }

	public void Set(ref QueryOffersOptions other) { }

	public void Set(ref Nullable<QueryOffersOptions> other) { }

	public void Dispose() { }

}

