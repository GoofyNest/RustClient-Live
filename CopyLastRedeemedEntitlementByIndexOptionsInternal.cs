internal struct CopyLastRedeemedEntitlementByIndexOptionsInternal : ISettable<CopyLastRedeemedEntitlementByIndexOptions>, IDisposable // TypeDefIndex: 9432
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private uint m_RedeemedEntitlementIndex; 

	public EpicAccountId LocalUserId { set; }
	public uint RedeemedEntitlementIndex { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_RedeemedEntitlementIndex(uint value) { }

	public void Set(ref CopyLastRedeemedEntitlementByIndexOptions other) { }

	public void Set(ref Nullable<CopyLastRedeemedEntitlementByIndexOptions> other) { }

	public void Dispose() { }

}

