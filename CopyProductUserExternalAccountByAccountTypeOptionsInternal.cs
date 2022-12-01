internal struct CopyProductUserExternalAccountByAccountTypeOptionsInternal : ISettable<CopyProductUserExternalAccountByAccountTypeOptions>, IDisposable // TypeDefIndex: 9562
{
	private int m_ApiVersion;
	private IntPtr m_TargetUserId;
	private ExternalAccountType m_AccountIdType;

	public ProductUserId TargetUserId { set; }
	public ExternalAccountType AccountIdType { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_AccountIdType(ExternalAccountType value) { }

	public void Set(ref CopyProductUserExternalAccountByAccountTypeOptions other) { }

	public void Set(ref Nullable<CopyProductUserExternalAccountByAccountTypeOptions> other) { }

	public void Dispose() { }

}

