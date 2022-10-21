internal struct GetItemReleaseCountOptionsInternal : ISettable<GetItemReleaseCountOptions>, IDisposable // TypeDefIndex: 9457
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ItemId; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_ItemId(Utf8String value) { }

	public void Set(ref GetItemReleaseCountOptions other) { }

	public void Set(ref Nullable<GetItemReleaseCountOptions> other) { }

	public void Dispose() { }

}

