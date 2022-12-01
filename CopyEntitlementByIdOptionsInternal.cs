internal struct CopyEntitlementByIdOptionsInternal : ISettable<CopyEntitlementByIdOptions>, IDisposable // TypeDefIndex: 9432
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_EntitlementId;

	public EpicAccountId LocalUserId { set; }
	public Utf8String EntitlementId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_EntitlementId(Utf8String value) { }

	public void Set(ref CopyEntitlementByIdOptions other) { }

	public void Set(ref Nullable<CopyEntitlementByIdOptions> other) { }

	public void Dispose() { }

}

