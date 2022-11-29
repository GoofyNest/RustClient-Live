internal struct GetOfferImageInfoCountOptionsInternal : ISettable<GetOfferImageInfoCountOptions>, IDisposable // TypeDefIndex: 9472
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_OfferId; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_OfferId(Utf8String value) { }

	public void Set(ref GetOfferImageInfoCountOptions other) { }

	public void Set(ref Nullable<GetOfferImageInfoCountOptions> other) { }

	public void Dispose() { }

}

