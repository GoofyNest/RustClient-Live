internal struct ExternalAccountInfoInternal : IGettable<ExternalAccountInfo>, ISettable<ExternalAccountInfo>, IDisposable // TypeDefIndex: 9571
{
	private int m_ApiVersion; 
	private IntPtr m_ProductUserId; 
	private IntPtr m_DisplayName; 
	private IntPtr m_AccountId; 
	private ExternalAccountType m_AccountIdType; 
	private long m_LastLoginTime; 

	public ProductUserId ProductUserId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String AccountId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Nullable<DateTimeOffset> LastLoginTime { get; set; }


	public ProductUserId get_ProductUserId() { }

	public void set_ProductUserId(ProductUserId value) { }

	public Utf8String get_DisplayName() { }

	public void set_DisplayName(Utf8String value) { }

	public Utf8String get_AccountId() { }

	public void set_AccountId(Utf8String value) { }

	public ExternalAccountType get_AccountIdType() { }

	public void set_AccountIdType(ExternalAccountType value) { }

	public Nullable<DateTimeOffset> get_LastLoginTime() { }

	public void set_LastLoginTime(Nullable<DateTimeOffset> value) { }

	public void Set(ref ExternalAccountInfo other) { }

	public void Set(ref Nullable<ExternalAccountInfo> other) { }

	public void Dispose() { }

	public void Get(out ExternalAccountInfo output) { }

}

