internal struct GetOfferItemCountOptionsInternal : ISettable<GetOfferItemCountOptions>, IDisposable // TypeDefIndex: 9465
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_OfferId; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_OfferId(Utf8String value) { }

	public void Set(ref GetOfferItemCountOptions other) { }

	public void Set(ref Nullable<GetOfferItemCountOptions> other) { }

	public void Dispose() { }

}

