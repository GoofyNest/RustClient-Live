internal struct CopyOfferByIndexOptionsInternal : ISettable<CopyOfferByIndexOptions>, IDisposable // TypeDefIndex: 9446
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private uint m_OfferIndex; 

	public EpicAccountId LocalUserId { set; }
	public uint OfferIndex { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_OfferIndex(uint value) { }

	public void Set(ref CopyOfferByIndexOptions other) { }

	public void Set(ref Nullable<CopyOfferByIndexOptions> other) { }

	public void Dispose() { }

}

