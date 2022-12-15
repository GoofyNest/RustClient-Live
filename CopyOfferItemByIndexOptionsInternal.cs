internal struct CopyOfferItemByIndexOptionsInternal : ISettable<CopyOfferItemByIndexOptions>, IDisposable // TypeDefIndex: 9454
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_OfferId;
	private uint m_ItemIndex;

	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }
	public uint ItemIndex { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_OfferId(Utf8String value) { }

	public void set_ItemIndex(uint value) { }

	public void Set(ref CopyOfferItemByIndexOptions other) { }

	public void Set(ref Nullable<CopyOfferItemByIndexOptions> other) { }

	public void Dispose() { }

}

