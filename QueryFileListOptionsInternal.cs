internal struct QueryFileListOptionsInternal : ISettable<QueryFileListOptions>, IDisposable // TypeDefIndex: 8416
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_ListOfTags;
	private uint m_ListOfTagsCount;

	public ProductUserId LocalUserId { set; }
	public Utf8String[] ListOfTags { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_ListOfTags(Utf8String[] value) { }

	public void Set(ref QueryFileListOptions other) { }

	public void Set(ref Nullable<QueryFileListOptions> other) { }

	public void Dispose() { }

}

internal struct QueryFileListOptionsInternal : ISettable<QueryFileListOptions>, IDisposable // TypeDefIndex: 8919
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;

	public ProductUserId LocalUserId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref QueryFileListOptions other) { }

	public void Set(ref Nullable<QueryFileListOptions> other) { }

	public void Dispose() { }

}

