internal struct CheckoutOptionsInternal : ISettable<CheckoutOptions>, IDisposable // TypeDefIndex: 9432
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_OverrideCatalogNamespace;
	private uint m_EntryCount;
	private IntPtr m_Entries;

	public EpicAccountId LocalUserId { set; }
	public Utf8String OverrideCatalogNamespace { set; }
	public CheckoutEntry[] Entries { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_OverrideCatalogNamespace(Utf8String value) { }

	public void set_Entries(CheckoutEntry[] value) { }

	public void Set(ref CheckoutOptions other) { }

	public void Set(ref Nullable<CheckoutOptions> other) { }

	public void Dispose() { }

}

