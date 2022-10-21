internal struct CopyItemReleaseByIndexOptionsInternal : ISettable<CopyItemReleaseByIndexOptions>, IDisposable // TypeDefIndex: 9431
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ItemId; 
	private uint m_ReleaseIndex; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }
	public uint ReleaseIndex { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_ItemId(Utf8String value) { }

	public void set_ReleaseIndex(uint value) { }

	public void Set(ref CopyItemReleaseByIndexOptions other) { }

	public void Set(ref Nullable<CopyItemReleaseByIndexOptions> other) { }

	public void Dispose() { }

}

