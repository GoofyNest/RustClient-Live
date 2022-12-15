internal struct QueryEntitlementsOptionsInternal : ISettable<QueryEntitlementsOptions>, IDisposable // TypeDefIndex: 9501
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_EntitlementNames;
	private uint m_EntitlementNameCount;
	private int m_IncludeRedeemed;

	public EpicAccountId LocalUserId { set; }
	public Utf8String[] EntitlementNames { set; }
	public bool IncludeRedeemed { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_EntitlementNames(Utf8String[] value) { }

	public void set_IncludeRedeemed(bool value) { }

	public void Set(ref QueryEntitlementsOptions other) { }

	public void Set(ref Nullable<QueryEntitlementsOptions> other) { }

	public void Dispose() { }

}

