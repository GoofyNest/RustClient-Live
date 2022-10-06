internal struct ExternalUserInfoInternal : IGettable<ExternalUserInfo>, ISettable<ExternalUserInfo>, IDisposable // TypeDefIndex: 8296
{
	private int m_ApiVersion; 
	private ExternalAccountType m_AccountType; 
	private IntPtr m_AccountId; 
	private IntPtr m_DisplayName; 
	private IntPtr m_DisplayNameSanitized; 

	public ExternalAccountType AccountType { get; set; }
	public Utf8String AccountId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String DisplayNameSanitized { get; set; }


	public ExternalAccountType get_AccountType() { }

	public void set_AccountType(ExternalAccountType value) { }

	public Utf8String get_AccountId() { }

	public void set_AccountId(Utf8String value) { }

	public Utf8String get_DisplayName() { }

	public void set_DisplayName(Utf8String value) { }

	public Utf8String get_DisplayNameSanitized() { }

	public void set_DisplayNameSanitized(Utf8String value) { }

	public void Set(ref ExternalUserInfo other) { }

	public void Set(ref Nullable<ExternalUserInfo> other) { }

	public void Dispose() { }

	public void Get(out ExternalUserInfo output) { }

}

