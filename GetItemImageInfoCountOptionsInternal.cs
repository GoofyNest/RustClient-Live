internal struct GetItemImageInfoCountOptionsInternal : ISettable<GetItemImageInfoCountOptions>, IDisposable // TypeDefIndex: 9466
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_ItemId;

	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_ItemId(Utf8String value) { }

	public void Set(ref GetItemImageInfoCountOptions other) { }

	public void Set(ref Nullable<GetItemImageInfoCountOptions> other) { }

	public void Dispose() { }

}

