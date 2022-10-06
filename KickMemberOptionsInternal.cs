internal struct KickMemberOptionsInternal : ISettable<KickMemberOptions>, IDisposable // TypeDefIndex: 9114
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

	public void Set(ref KickMemberOptions other) { }

	public void Set(ref Nullable<KickMemberOptions> other) { }

	public void Dispose() { }

}

