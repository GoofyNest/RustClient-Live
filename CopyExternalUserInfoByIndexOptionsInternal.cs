internal struct CopyExternalUserInfoByIndexOptionsInternal : ISettable<CopyExternalUserInfoByIndexOptions>, IDisposable // TypeDefIndex: 8302
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 
	private uint m_Index; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }
	public uint Index { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void set_Index(uint value) { }

	public void Set(ref CopyExternalUserInfoByIndexOptions other) { }

	public void Set(ref Nullable<CopyExternalUserInfoByIndexOptions> other) { }

	public void Dispose() { }

}

