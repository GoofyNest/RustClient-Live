internal struct CopyItemImageInfoByIndexOptionsInternal : ISettable<CopyItemImageInfoByIndexOptions>, IDisposable // TypeDefIndex: 9394
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ItemId; 
	private uint m_ImageInfoIndex; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }
	public uint ImageInfoIndex { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_ItemId(Utf8String value) { }

	public void set_ImageInfoIndex(uint value) { }

	public void Set(ref CopyItemImageInfoByIndexOptions other) { }

	public void Set(ref Nullable<CopyItemImageInfoByIndexOptions> other) { }

	public void Dispose() { }

}

