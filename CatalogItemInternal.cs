internal struct CatalogItemInternal : IGettable<CatalogItem>, ISettable<CatalogItem>, IDisposable // TypeDefIndex: 9418
{
	private int m_ApiVersion; 
	private IntPtr m_CatalogNamespace; 
	private IntPtr m_Id; 
	private IntPtr m_EntitlementName; 
	private IntPtr m_TitleText; 
	private IntPtr m_DescriptionText; 
	private IntPtr m_LongDescriptionText; 
	private IntPtr m_TechnicalDetailsText; 
	private IntPtr m_DeveloperText; 
	private EcomItemType m_ItemType; 
	private long m_EntitlementEndTimestamp; 

	public Utf8String CatalogNamespace { get; set; }
	public Utf8String Id { get; set; }
	public Utf8String EntitlementName { get; set; }
	public Utf8String TitleText { get; set; }
	public Utf8String DescriptionText { get; set; }
	public Utf8String LongDescriptionText { get; set; }
	public Utf8String TechnicalDetailsText { get; set; }
	public Utf8String DeveloperText { get; set; }
	public EcomItemType ItemType { get; set; }
	public long EntitlementEndTimestamp { get; set; }


	public Utf8String get_CatalogNamespace() { }

	public void set_CatalogNamespace(Utf8String value) { }

	public Utf8String get_Id() { }

	public void set_Id(Utf8String value) { }

	public Utf8String get_EntitlementName() { }

	public void set_EntitlementName(Utf8String value) { }

	public Utf8String get_TitleText() { }

	public void set_TitleText(Utf8String value) { }

	public Utf8String get_DescriptionText() { }

	public void set_DescriptionText(Utf8String value) { }

	public Utf8String get_LongDescriptionText() { }

	public void set_LongDescriptionText(Utf8String value) { }

	public Utf8String get_TechnicalDetailsText() { }

	public void set_TechnicalDetailsText(Utf8String value) { }

	public Utf8String get_DeveloperText() { }

	public void set_DeveloperText(Utf8String value) { }

	public EcomItemType get_ItemType() { }

	public void set_ItemType(EcomItemType value) { }

	public long get_EntitlementEndTimestamp() { }

	public void set_EntitlementEndTimestamp(long value) { }

	public void Set(ref CatalogItem other) { }

	public void Set(ref Nullable<CatalogItem> other) { }

	public void Dispose() { }

	public void Get(out CatalogItem output) { }

}

