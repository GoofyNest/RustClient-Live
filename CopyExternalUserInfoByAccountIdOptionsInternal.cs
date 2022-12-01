internal struct CopyExternalUserInfoByAccountIdOptionsInternal : ISettable<CopyExternalUserInfoByAccountIdOptions>, IDisposable // TypeDefIndex: 8300
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_TargetUserId;
	private IntPtr m_AccountId;

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }
	public Utf8String AccountId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void set_AccountId(Utf8String value) { }

	public void Set(ref CopyExternalUserInfoByAccountIdOptions other) { }

	public void Set(ref Nullable<CopyExternalUserInfoByAccountIdOptions> other) { }

	public void Dispose() { }

}

