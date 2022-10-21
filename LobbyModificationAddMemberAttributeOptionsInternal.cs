internal struct LobbyModificationAddMemberAttributeOptionsInternal : ISettable<LobbyModificationAddMemberAttributeOptions>, IDisposable // TypeDefIndex: 9160
{
	private int m_ApiVersion; 
	private IntPtr m_Attribute; 
	private LobbyAttributeVisibility m_Visibility; 

	public Nullable<AttributeData> Attribute { set; }
	public LobbyAttributeVisibility Visibility { set; }


	public void set_Attribute(Nullable<AttributeData> value) { }

	public void set_Visibility(LobbyAttributeVisibility value) { }

	public void Set(ref LobbyModificationAddMemberAttributeOptions other) { }

	public void Set(ref Nullable<LobbyModificationAddMemberAttributeOptions> other) { }

	public void Dispose() { }

}

