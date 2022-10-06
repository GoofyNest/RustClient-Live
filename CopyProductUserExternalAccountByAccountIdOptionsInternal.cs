internal struct CopyProductUserExternalAccountByAccountIdOptionsInternal : ISettable<CopyProductUserExternalAccountByAccountIdOptions>, IDisposable // TypeDefIndex: 9548
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_AccountId; 

	public ProductUserId TargetUserId { set; }
	public Utf8String AccountId { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_AccountId(Utf8String value) { }

	public void Set(ref CopyProductUserExternalAccountByAccountIdOptions other) { }

	public void Set(ref Nullable<CopyProductUserExternalAccountByAccountIdOptions> other) { }

	public void Dispose() { }

}

