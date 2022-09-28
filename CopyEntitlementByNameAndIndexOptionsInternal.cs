internal struct CopyEntitlementByNameAndIndexOptionsInternal : ISettable<CopyEntitlementByNameAndIndexOptions>, IDisposable // TypeDefIndex: 9390
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_EntitlementName; 
	private uint m_Index; 

	public EpicAccountId LocalUserId { set; }
	public Utf8String EntitlementName { set; }
	public uint Index { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_EntitlementName(Utf8String value) { }

	public void set_Index(uint value) { }

	public void Set(ref CopyEntitlementByNameAndIndexOptions other) { }

	public void Set(ref Nullable<CopyEntitlementByNameAndIndexOptions> other) { }

	public void Dispose() { }

}

