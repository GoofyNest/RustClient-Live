internal struct SendCustomInviteOptionsInternal : ISettable<SendCustomInviteOptions>, IDisposable // TypeDefIndex: 9501
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserIds; 
	private uint m_TargetUserIdsCount; 

	public ProductUserId LocalUserId { set; }
	public ProductUserId[] TargetUserIds { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_TargetUserIds(ProductUserId[] value) { }

	public void Set(ref SendCustomInviteOptions other) { }

	public void Set(ref Nullable<SendCustomInviteOptions> other) { }

	public void Dispose() { }

}

