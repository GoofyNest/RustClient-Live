internal struct RedeemEntitlementsOptionsInternal : ISettable<RedeemEntitlementsOptions>, IDisposable // TypeDefIndex: 9517
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private uint m_EntitlementIdCount;
	private IntPtr m_EntitlementIds;

	public EpicAccountId LocalUserId { set; }
	public Utf8String[] EntitlementIds { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_EntitlementIds(Utf8String[] value) { }

	public void Set(ref RedeemEntitlementsOptions other) { }

	public void Set(ref Nullable<RedeemEntitlementsOptions> other) { }

	public void Dispose() { }

}

