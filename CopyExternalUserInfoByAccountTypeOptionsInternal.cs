internal struct CopyExternalUserInfoByAccountTypeOptionsInternal : ISettable<CopyExternalUserInfoByAccountTypeOptions>, IDisposable // TypeDefIndex: 8256
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 
	private ExternalAccountType m_AccountType; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }
	public ExternalAccountType AccountType { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void set_AccountType(ExternalAccountType value) { }

	public void Set(ref CopyExternalUserInfoByAccountTypeOptions other) { }

	public void Set(ref Nullable<CopyExternalUserInfoByAccountTypeOptions> other) { }

	public void Dispose() { }

}

