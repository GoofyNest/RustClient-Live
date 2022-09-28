internal struct CopyItemByIdOptionsInternal : ISettable<CopyItemByIdOptions>, IDisposable // TypeDefIndex: 9392
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ItemId; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_ItemId(Utf8String value) { }

	public void Set(ref CopyItemByIdOptions other) { }

	public void Set(ref Nullable<CopyItemByIdOptions> other) { }

	public void Dispose() { }

}

