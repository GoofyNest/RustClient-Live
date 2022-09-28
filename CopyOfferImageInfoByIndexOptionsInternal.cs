internal struct CopyOfferImageInfoByIndexOptionsInternal : ISettable<CopyOfferImageInfoByIndexOptions>, IDisposable // TypeDefIndex: 9404
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_OfferId; 
	private uint m_ImageInfoIndex; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }
	public uint ImageInfoIndex { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_OfferId(Utf8String value) { }

	public void set_ImageInfoIndex(uint value) { }

	public void Set(ref CopyOfferImageInfoByIndexOptions other) { }

	public void Set(ref Nullable<CopyOfferImageInfoByIndexOptions> other) { }

	public void Dispose() { }

}

