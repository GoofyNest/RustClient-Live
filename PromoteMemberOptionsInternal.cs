internal struct PromoteMemberOptionsInternal : ISettable<PromoteMemberOptions>, IDisposable // TypeDefIndex: 9244
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyId; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }


	public void set_LobbyId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref PromoteMemberOptions other) { }

	public void Set(ref Nullable<PromoteMemberOptions> other) { }

	public void Dispose() { }

}

