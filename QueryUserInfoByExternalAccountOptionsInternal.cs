internal struct QueryUserInfoByExternalAccountOptionsInternal : ISettable<QueryUserInfoByExternalAccountOptions>, IDisposable // TypeDefIndex: 8278
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ExternalAccountId; 
	private ExternalAccountType m_AccountType; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String ExternalAccountId { set; }
	public ExternalAccountType AccountType { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_ExternalAccountId(Utf8String value) { }

	public void set_AccountType(ExternalAccountType value) { }

	public void Set(ref QueryUserInfoByExternalAccountOptions other) { }

	public void Set(ref Nullable<QueryUserInfoByExternalAccountOptions> other) { }

	public void Dispose() { }

}

