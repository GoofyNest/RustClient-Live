internal struct LobbyModificationAddAttributeOptionsInternal : ISettable<LobbyModificationAddAttributeOptions>, IDisposable // TypeDefIndex: 9171
{
	private int m_ApiVersion;
	private IntPtr m_Attribute;
	private LobbyAttributeVisibility m_Visibility;

	public Nullable<AttributeData> Attribute { set; }
	public LobbyAttributeVisibility Visibility { set; }


	public void set_Attribute(Nullable<AttributeData> value) { }

	public void set_Visibility(LobbyAttributeVisibility value) { }

	public void Set(ref LobbyModificationAddAttributeOptions other) { }

	public void Set(ref Nullable<LobbyModificationAddAttributeOptions> other) { }

	public void Dispose() { }

}

