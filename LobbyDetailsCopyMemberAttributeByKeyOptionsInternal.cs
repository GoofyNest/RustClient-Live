internal struct LobbyDetailsCopyMemberAttributeByKeyOptionsInternal : ISettable<LobbyDetailsCopyMemberAttributeByKeyOptions>, IDisposable // TypeDefIndex: 9096
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_AttrKey; 

	public ProductUserId TargetUserId { set; }
	public Utf8String AttrKey { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_AttrKey(Utf8String value) { }

	public void Set(ref LobbyDetailsCopyMemberAttributeByKeyOptions other) { }

	public void Set(ref Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions> other) { }

	public void Dispose() { }

}

