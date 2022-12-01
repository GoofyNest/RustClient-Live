internal struct CopyEntitlementByIndexOptionsInternal : ISettable<CopyEntitlementByIndexOptions>, IDisposable // TypeDefIndex: 9434
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private uint m_EntitlementIndex;

	public EpicAccountId LocalUserId { set; }
	public uint EntitlementIndex { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_EntitlementIndex(uint value) { }

	public void Set(ref CopyEntitlementByIndexOptions other) { }

	public void Set(ref Nullable<CopyEntitlementByIndexOptions> other) { }

	public void Dispose() { }

}

