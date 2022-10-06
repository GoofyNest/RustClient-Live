internal struct HardMuteMemberOptionsInternal : ISettable<HardMuteMemberOptions>, IDisposable // TypeDefIndex: 9098
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyId; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 
	private int m_HardMute; 

	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public bool HardMute { set; }


	public void set_LobbyId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void set_HardMute(bool value) { }

	public void Set(ref HardMuteMemberOptions other) { }

	public void Set(ref Nullable<HardMuteMemberOptions> other) { }

	public void Dispose() { }

}

