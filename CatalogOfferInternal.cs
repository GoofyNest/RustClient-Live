internal struct CatalogOfferInternal : IGettable<CatalogOffer>, ISettable<CatalogOffer>, IDisposable // TypeDefIndex: 9411
{
	private int m_ApiVersion; 
	private int m_ServerIndex; 
	private IntPtr m_CatalogNamespace; 
	private IntPtr m_Id; 
	private IntPtr m_TitleText; 
	private IntPtr m_DescriptionText; 
	private IntPtr m_LongDescriptionText; 
	private IntPtr m_TechnicalDetailsText_DEPRECATED; 
	private IntPtr m_CurrencyCode; 
	private Result m_PriceResult; 
	private uint m_OriginalPrice_DEPRECATED; 
	private uint m_CurrentPrice_DEPRECATED; 
	private byte m_DiscountPercentage; 
	private long m_ExpirationTimestamp; 
	private uint m_PurchasedCount_DEPRECATED; 
	private int m_PurchaseLimit; 
	private int m_AvailableForPurchase; 
	private ulong m_OriginalPrice64; 
	private ulong m_CurrentPrice64; 
	private uint m_DecimalPoint; 
	private long m_ReleaseDateTimestamp; 
	private long m_EffectiveDateTimestamp; 

	public int ServerIndex { get; set; }
	public Utf8String CatalogNamespace { get; set; }
	public Utf8String Id { get; set; }
	public Utf8String TitleText { get; set; }
	public Utf8String DescriptionText { get; set; }
	public Utf8String LongDescriptionText { get; set; }
	public Utf8String TechnicalDetailsText_DEPRECATED { get; set; }
	public Utf8String CurrencyCode { get; set; }
	public Result PriceResult { get; set; }
	public uint OriginalPrice_DEPRECATED { get; set; }
	public uint CurrentPrice_DEPRECATED { get; set; }
	public byte DiscountPercentage { get; set; }
	public long ExpirationTimestamp { get; set; }
	public uint PurchasedCount_DEPRECATED { get; set; }
	public int PurchaseLimit { get; set; }
	public bool AvailableForPurchase { get; set; }
	public ulong OriginalPrice64 { get; set; }
	public ulong CurrentPrice64 { get; set; }
	public uint DecimalPoint { get; set; }
	public long ReleaseDateTimestamp { get; set; }
	public long EffectiveDateTimestamp { get; set; }


	public int get_ServerIndex() { }

	public void set_ServerIndex(int value) { }

	public Utf8String get_CatalogNamespace() { }

	public void set_CatalogNamespace(Utf8String value) { }

	public Utf8String get_Id() { }

	public void set_Id(Utf8String value) { }

	public Utf8String get_TitleText() { }

	public void set_TitleText(Utf8String value) { }

	public Utf8String get_DescriptionText() { }

	public void set_DescriptionText(Utf8String value) { }

	public Utf8String get_LongDescriptionText() { }

	public void set_LongDescriptionText(Utf8String value) { }

	public Utf8String get_TechnicalDetailsText_DEPRECATED() { }

	public void set_TechnicalDetailsText_DEPRECATED(Utf8String value) { }

	public Utf8String get_CurrencyCode() { }

	public void set_CurrencyCode(Utf8String value) { }

	public Result get_PriceResult() { }

	public void set_PriceResult(Result value) { }

	public uint get_OriginalPrice_DEPRECATED() { }

	public void set_OriginalPrice_DEPRECATED(uint value) { }

	public uint get_CurrentPrice_DEPRECATED() { }

	public void set_CurrentPrice_DEPRECATED(uint value) { }

	public byte get_DiscountPercentage() { }

	public void set_DiscountPercentage(byte value) { }

	public long get_ExpirationTimestamp() { }

	public void set_ExpirationTimestamp(long value) { }

	public uint get_PurchasedCount_DEPRECATED() { }

	public void set_PurchasedCount_DEPRECATED(uint value) { }

	public int get_PurchaseLimit() { }

	public void set_PurchaseLimit(int value) { }

	public bool get_AvailableForPurchase() { }

	public void set_AvailableForPurchase(bool value) { }

	public ulong get_OriginalPrice64() { }

	public void set_OriginalPrice64(ulong value) { }

	public ulong get_CurrentPrice64() { }

	public void set_CurrentPrice64(ulong value) { }

	public uint get_DecimalPoint() { }

	public void set_DecimalPoint(uint value) { }

	public long get_ReleaseDateTimestamp() { }

	public void set_ReleaseDateTimestamp(long value) { }

	public long get_EffectiveDateTimestamp() { }

	public void set_EffectiveDateTimestamp(long value) { }

	public void Set(ref CatalogOffer other) { }

	public void Set(ref Nullable<CatalogOffer> other) { }

	public void Dispose() { }

	public void Get(out CatalogOffer output) { }

}

